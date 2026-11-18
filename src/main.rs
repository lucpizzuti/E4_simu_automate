//! ============================================================================
//! POINT D'ENTRÉE DU SIMULATEUR
//! ============================================================================
//! Ce fichier fait tourner deux choses en parallèle :
//!   1. Le "moteur automate" (fonction main, tâche tokio::spawn ci-dessous) :
//!      une boucle qui répète indéfiniment le cycle lecture → logique → écriture.
//!   2. Le serveur web (axum) qui sert la page HTML et diffuse l'état en
//!      direct via WebSocket (voir src/web.rs).
//!
//! C'est LE fichier à modifier pour :
//!   - ajouter de nouvelles variables dans la mémoire de l'automate
//!   - ajouter de la logique métier (des "if", des calculs...)
//!   - envoyer/recevoir des données vers un vrai équipement Modbus
//!
//! Cherche les commentaires "➜ AJOUTE ICI" ci-dessous : ce sont les 3 seuls
//! endroits où tu dois intervenir pour étendre le simulateur.

mod communication;
mod core;
mod web;

use anyhow::{Context, Result};
use communication::modbus_server::{serve as serve_modbus, ModbusState};
use core::memory::Memory;
use core::value::Value;
use serde_json::json;
use std::sync::{Arc, RwLock};
use tokio::sync::broadcast;
use tokio::time::{sleep, Duration};

// ============================================================================
// BLOC LOGIQUE — ➜ AJOUTE ICI tes règles métier ("if temperature > 50 { ... }")
// ============================================================================
//
// Cette fonction est appelée UNE FOIS PAR CYCLE, juste après la lecture des
// entrées et juste avant l'écriture des sorties (voir la boucle dans main()
// plus bas). C'est ici que vit "le programme" de l'automate.
//
// Aujourd'hui elle contient une seule règle, codée en dur en Rust. Plus tard,
// cette fonction sera remplacée par un interpréteur qui lira un vrai petit
// langage de script écrit par l'utilisateur — mais le principe restera le
// même : on lit des variables dans `mem`, on calcule, on écrit le résultat
// dans `mem`.
//
// Pour ajouter une nouvelle règle, copie-colle le modèle ci-dessous :
//
//   let ma_variable = mem.get("nom_de_la_variable").unwrap().as_f64();
//   mem.set("autre_variable", Value::Bool(ma_variable > 100.0));
//
fn run_logic(mem: &mut Memory, compute_alarm: bool) {
    if compute_alarm {
        let temperature = mem.get("temperature").unwrap().as_f64();
        mem.set("alarm", Value::Bool(temperature > 50.0));
    }

    // ➜ AJOUTE ICI tes propres règles, par exemple :
    //
    // // Un moteur qui s'arrête si l'alarme est active
    // let alarm = mem.get("alarm").unwrap().as_bool();
    // mem.set("motor", Value::Bool(!alarm));
    //
    // // Un compteur de dépassements
    // if temperature > 50.0 {
    //     if let Some(Value::UInt32(n)) = mem.get("overheat_count") {
    //         mem.set("overheat_count", Value::UInt32(n + 1));
    //     }
    // }
}

/// Simule une entrée externe (un capteur qui n'existe pas encore vraiment).
/// À terme, cette fonction sera remplacée par une vraie lecture Modbus
/// (voir le bloc "ENVOI / RÉCEPTION DE DONNÉES" plus bas).
fn simulate_input(mem: &mut Memory, cycle: u32) {
    // Rampe qui monte puis redescend, façon signal réel, pour que la
    // démo tourne en continu sans juste s'arrêter à la première alarme.
    let phase = (cycle % 80) as f64;
    let temperature = 20.0 + (phase - 40.0).abs() * -0.5 + 40.0; // triangle 20..60..20
    mem.set("temperature", Value::Int16(temperature.round() as i16));
}

/// Sérialise l'état complet de la mémoire en JSON pour l'envoyer aux
/// clients WebSocket (voir src/web/index.html qui l'affiche). Tu n'as
/// normalement pas besoin de toucher à cette fonction : elle boucle sur
/// TOUTES les variables présentes dans `mem`, donc toute variable ajoutée
/// via mem.set(...) apparaît automatiquement dans l'interface web.
fn state_json(
    cycle: u32,
    mem: &Memory,
    paused: bool,
    forced_variables: &std::collections::BTreeMap<String, Value>,
) -> String {
    let variables: Vec<_> = mem
        .dump()
        .into_iter()
        .map(|(name, value)| {
            json!({
                "name": name,
                "type": value.type_name(),
                "value": value.to_json(),
                "forced": forced_variables.contains_key(&name),
            })
        })
        .collect();
    json!({ "cycle": cycle, "paused": paused, "variables": variables }).to_string()
}

#[tokio::main]
async fn main() -> Result<()> {
    let mut initial_memory = Memory::new();
    initial_memory.set("temperature", Value::Int16(25));
    initial_memory.set("alarm", Value::Bool(false));
    initial_memory.set("counter", Value::UInt32(0));
    initial_memory.set("counter2", Value::Int16(50));
    let memory = Arc::new(RwLock::new(initial_memory));
    let (modbus, modbus_port) = ModbusState::load(
        std::path::Path::new("COMM.DAT"),
        std::path::Path::new("modbus_config.json"),
        memory.clone(),
    )?;
    // `tx` est le "haut-parleur" WebSocket : tout ce qu'on envoie avec
    // tx.send(...) est reçu par tous les navigateurs connectés à la page.
    let (tx, _rx) = broadcast::channel::<String>(16);
    let simulation = web::SimulationControl::default();
    let state = Arc::new(web::AppState {
        tx: tx.clone(),
        modbus: modbus.clone(),
        simulation: simulation.clone(),
    });

    // --- Boucle de simulation (le "moteur automate") ---
    // Tourne dans sa propre tâche asynchrone, en parallèle du serveur web,
    // pour que l'un ne bloque jamais l'autre.
    let loop_memory = memory.clone();
    let loop_modbus = modbus.clone();
    let loop_simulation = simulation;
    tokio::spawn(async move {
        let mut cycle: u32 = 0;
        loop {
            let paused = loop_simulation.is_paused();
            if !paused {
                cycle = cycle.wrapping_add(1);
            }

            let frames = match loop_modbus.snapshot() {
                Ok(frames) => frames,
                Err(error) => {
                    eprintln!("Erreur de lecture des associations Modbus : {error:#}");
                    break;
                }
            };
            let forced_values = match loop_simulation.forced_values() {
                Ok(values) => values,
                Err(error) => {
                    eprintln!("Erreur de lecture des variables forcées : {error:#}");
                    break;
                }
            };
            let variable_is_mapped = |name: &str| {
                frames.iter().any(|frame| {
                    frame
                        .bindings
                        .iter()
                        .any(|binding| binding.variable == name)
                })
            };
            {
                let Ok(mut mem) = loop_memory.write() else {
                    eprintln!("Erreur : verrou de mémoire indisponible");
                    break;
                };
                if !paused {
                    if !variable_is_mapped("temperature") {
                        simulate_input(&mut mem, cycle);
                    }
                    run_logic(&mut mem, !variable_is_mapped("alarm"));

                    if let Some(Value::UInt32(c)) = mem.get("counter") {
                        mem.set("counter", Value::UInt32(c.wrapping_add(1)));
                    }

                    if let Some(Value::Int16(c)) = mem.get("counter2") {
                        mem.set("counter2", Value::Int16(c.wrapping_sub(1)));
                    }
                }
                for (name, value) in &forced_values {
                    mem.set(name, *value);
                }
            }

            if let Err(error) = loop_modbus.sync_from_memory() {
                eprintln!("Erreur de synchronisation Modbus : {error:#}");
            }
            let state = {
                let Ok(mem) = loop_memory.read() else {
                    eprintln!("Erreur : verrou de mémoire indisponible");
                    break;
                };
                state_json(cycle, &mem, paused, &forced_values)
            };
            let _ = tx.send(state);
            sleep(Duration::from_millis(200)).await;
        }
    });

    let modbus_listener = tokio::net::TcpListener::bind(("0.0.0.0", modbus_port))
        .await
        .with_context(|| format!("impossible d'écouter sur le port Modbus {modbus_port}"))?;
    println!("=== Serveur Modbus TCP sur 0.0.0.0:{modbus_port} ===");
    tokio::spawn(async move {
        if let Err(error) = serve_modbus(modbus_listener, modbus).await {
            eprintln!("Erreur du serveur Modbus : {error:#}");
        }
    });

    // --- Serveur web ---
    // Sert la page HTML (src/web/index.html) et le endpoint WebSocket /ws
    // qui diffuse l'état de la mémoire à chaque cycle. Voir src/web.rs.
    let app = web::build_router(state);
    let listener = tokio::net::TcpListener::bind("0.0.0.0:3000")
        .await
        .context("impossible d'écouter sur le port web 3000")?;
    println!("=== Automate Simulator — serveur sur http://127.0.0.1:3000 ===");
    axum::serve(listener, app).await.unwrap();
    Ok(())
}
