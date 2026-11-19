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
use communication::modbus_server::{serve as serve_modbus, ModbusFrame, ModbusState};
use core::memory::Memory;
use core::value::Value;
use serde_json::json;
use std::sync::{Arc, RwLock};
use tokio::sync::broadcast;
use tokio::time::{sleep, Duration};

#[derive(Debug, Clone, Copy, PartialEq, Eq)]
#[repr(usize)]
enum Emplacement {
    Refroidissement1,
    Refroidissement2,
    Refroidissement3,
    Refroidissement4,
    Refroidissement5,
    Refroidissement6,

    Talquage,
    Demoulage,

    Robot1,
    Robot5,
    Robot2_1,
    Robot2_2,
    Robot3_1,
    Robot3_2,
    Robot4_1,
    Robot4_2,

    PSR1_1,
    PSR1_2,
    PSR2_1,
    PSR2_2,

    PST2,

    Reserve1,

    SCOAG1,
    SCOAG2,

    PST1_1,
    PST1_2,

    Tampon1,
    Tampon2,
    Tampon3,
    Tampon4,

    PPF1,
    PPF2,

    PPNC1,
    PPNC2,

    FourPS1,
    Reserve2,
    FourPS2,
    FourPS3,
    FourPS4,
    FourPS5,
    FourPS6,
    FourPS7,
    FourPS8,
    FourPS9,
    Reserve3,
    FourPS10,

    Four1,
    Four2,
    Four3,
    Four4,
    Four5,
    Four6,
    Four7,
    Four8,
    Four9,
    Four10,
    Four11,
    Four12,
    Four13,
    Four14,
    Four15,
    Four16,
    Four17,
    Four18,
    Four19,
    Four20,
    Four21,
    Four22,
    Four23,
    Four24,
    Four25,
    Four26,
    Four27,
    Four28,
    Four29,
    Four30,
    Four31,
    Four32,
    Four33,
    Four34,
    Four35,
    Four36,
    Four37,
    Four38,
    Four39,
    Four40,
    Four41,
    Four42,
    Four43,
    Four44,
    Four45,
    Four46,
    Four47,
    Four48,
    Four49,
    Four50,
    Four51,
    Four52,
    Four53,
    Four54,
    Four55,
    Four56,
    Four57,
    Four58,
    Four59,
    Four60,
    Four61,
    Four62,
    Four63,
    Four64,
}

impl Emplacement {
    fn index(self) -> usize {
        self as usize
    }

    fn est_reserve(self) -> bool {
        matches!(self, Self::Reserve1 | Self::Reserve2 | Self::Reserve3)
    }
}

// Liste de circulation dans l'ordre physique
const ORDRE: [Emplacement; 110] = [
    Emplacement::Refroidissement1,
    Emplacement::Refroidissement2,
    Emplacement::Refroidissement3,
    Emplacement::Refroidissement4,
    Emplacement::Refroidissement5,
    Emplacement::Refroidissement6,
    Emplacement::Talquage,
    Emplacement::Demoulage,
    Emplacement::Robot1,
    Emplacement::Robot5,
    Emplacement::Robot2_1,
    Emplacement::Robot2_2,
    Emplacement::Robot3_1,
    Emplacement::Robot3_2,
    Emplacement::Robot4_1,
    Emplacement::Robot4_2,
    Emplacement::PSR1_1,
    Emplacement::PSR1_2,
    Emplacement::PSR2_1,
    Emplacement::PSR2_2,
    Emplacement::PST2,
    Emplacement::Reserve1,
    Emplacement::SCOAG1,
    Emplacement::SCOAG2,
    Emplacement::PST1_1,
    Emplacement::PST1_2,
    Emplacement::Tampon1,
    Emplacement::Tampon2,
    Emplacement::Tampon3,
    Emplacement::Tampon4,
    Emplacement::PPF1,
    Emplacement::PPF2,
    Emplacement::PPNC1,
    Emplacement::PPNC2,
    Emplacement::FourPS1,
    Emplacement::Reserve2,
    Emplacement::FourPS2,
    Emplacement::FourPS3,
    Emplacement::FourPS4,
    Emplacement::FourPS5,
    Emplacement::FourPS6,
    Emplacement::FourPS7,
    Emplacement::FourPS8,
    Emplacement::FourPS9,
    Emplacement::Reserve3,
    Emplacement::FourPS10,
    Emplacement::Four1,
    Emplacement::Four2,
    Emplacement::Four3,
    Emplacement::Four4,
    Emplacement::Four5,
    Emplacement::Four6,
    Emplacement::Four7,
    Emplacement::Four8,
    Emplacement::Four9,
    Emplacement::Four10,
    Emplacement::Four11,
    Emplacement::Four12,
    Emplacement::Four13,
    Emplacement::Four14,
    Emplacement::Four15,
    Emplacement::Four16,
    Emplacement::Four17,
    Emplacement::Four18,
    Emplacement::Four19,
    Emplacement::Four20,
    Emplacement::Four21,
    Emplacement::Four22,
    Emplacement::Four23,
    Emplacement::Four24,
    Emplacement::Four25,
    Emplacement::Four26,
    Emplacement::Four27,
    Emplacement::Four28,
    Emplacement::Four29,
    Emplacement::Four30,
    Emplacement::Four31,
    Emplacement::Four32,
    Emplacement::Four33,
    Emplacement::Four34,
    Emplacement::Four35,
    Emplacement::Four36,
    Emplacement::Four37,
    Emplacement::Four38,
    Emplacement::Four39,
    Emplacement::Four40,
    Emplacement::Four41,
    Emplacement::Four42,
    Emplacement::Four43,
    Emplacement::Four44,
    Emplacement::Four45,
    Emplacement::Four46,
    Emplacement::Four47,
    Emplacement::Four48,
    Emplacement::Four49,
    Emplacement::Four50,
    Emplacement::Four51,
    Emplacement::Four52,
    Emplacement::Four53,
    Emplacement::Four54,
    Emplacement::Four55,
    Emplacement::Four56,
    Emplacement::Four57,
    Emplacement::Four58,
    Emplacement::Four59,
    Emplacement::Four60,
    Emplacement::Four61,
    Emplacement::Four62,
    Emplacement::Four63,
    Emplacement::Four64,
];

const TAILLE_PLATEAU: usize = 1;

// Lire le numéro du plateau à un emplacement.
fn lire_plateau(values: &[u16], emplacement: Emplacement) -> [u16; TAILLE_PLATEAU] {
    let index = emplacement.index();

    values[index..index + TAILLE_PLATEAU]
        .try_into()
        .expect("Index invalide")
}

// Avance chaque plateau d'un emplacement, sans toucher aux registres hors parcours.
fn decaler_plateaux(values: &mut [u16]) -> Result<()> {
    if values.len() < ORDRE.len() {
        anyhow::bail!(
            "FrameEmplPlateaux contient {} registres, {} sont nécessaires",
            values.len(),
            ORDRE.len()
        );
    }

    let circulation: Vec<_> = ORDRE
        .iter()
        .copied()
        .filter(|emplacement| !emplacement.est_reserve())
        .collect();
    let mut next = values.to_vec();
    for (index, emplacement) in circulation.iter().enumerate() {
        let destination = circulation[(index + 1) % circulation.len()].index();
        next[destination] = lire_plateau(values, *emplacement)[0];
    }
    next[Emplacement::Reserve1.index()] = 0;
    values.copy_from_slice(&next);
    Ok(())
}

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
fn run_logic(mem: &mut Memory, frames: &mut [ModbusFrame], compute_alarm: bool) -> Result<()> {
    if compute_alarm {
        let temperature = mem
            .get("temperature")
            .context("variable temperature absente")?
            .as_f64();
        mem.set("alarm", Value::Bool(temperature > 50.0));
    }

    if let Some(frame) = frames
        .iter_mut()
        .find(|frame| frame.name == "FrameEmplPlateaux")
    {
        decaler_plateaux(&mut frame.values)?;
    }

    // Toutes les frames sont accessibles par leur nom. Par exemple :
    // if let Some(frame) = frames.iter_mut().find(|frame| frame.name == "FrameEmplPlateaux") {
    //     if let Some(value) = frame.values.get_mut(0) {
    //         *value = value.wrapping_add(1);
    //     }
    // }
    // Les registres liés à une variable sont synchronisés depuis `mem`
    // après cette fonction ; pour les modifier, mettez à jour la variable.

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
    Ok(())
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

            let mut frames = match loop_modbus.snapshot() {
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
            let temperature_is_mapped = variable_is_mapped("temperature");
            let alarm_is_mapped = variable_is_mapped("alarm");
            {
                let Ok(mut mem) = loop_memory.write() else {
                    eprintln!("Erreur : verrou de mémoire indisponible");
                    break;
                };
                if !paused {
                    if !temperature_is_mapped {
                        simulate_input(&mut mem, cycle);
                    }
                    if let Err(error) = run_logic(&mut mem, &mut frames, !alarm_is_mapped) {
                        eprintln!("Erreur d'exécution de la logique : {error:#}");
                        break;
                    }

                    if let Some(Value::UInt32(c)) = mem.get("counter") {
                        mem.set("counter", Value::UInt32(c.wrapping_add(1)));
                    }
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

            if let Some(frame) = frames
                .iter()
                .find(|frame| frame.name == "FrameEmplPlateaux")
            {
                if let Err(error) = loop_modbus.update_runtime_frame_values(
                    &frame.name,
                    frame.address,
                    &frame.values,
                ) {
                    eprintln!("Erreur de mise à jour des emplacements : {error:#}");
                    break;
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
            sleep(Duration::from_millis(500)).await;
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

#[cfg(test)]
mod tests {
    use super::*;

    #[test]
    fn emplacement_indices_follow_frame_register_order() {
        assert_eq!(ORDRE.len(), 110);
        for (index, emplacement) in ORDRE.iter().enumerate() {
            assert_eq!(emplacement.index(), index);
        }
    }

    #[test]
    fn plateaux_advance_one_emplacement_and_wrap_continuously() {
        let mut values: Vec<u16> = (0..120).collect();
        let initial_values = values.clone();
        decaler_plateaux(&mut values).unwrap();

        assert_eq!(values[0], 109);
        assert_eq!(values[1], 0);
        assert_eq!(values[109], 108);
        assert_eq!(values[Emplacement::Reserve1.index()], 0);
        assert_eq!(values[Emplacement::Reserve2.index()], 35);
        assert_eq!(values[Emplacement::Reserve3.index()], 44);
        assert_eq!(&values[110..], &(110..120).collect::<Vec<_>>());

        let mut expected = initial_values;
        expected[Emplacement::Reserve1.index()] = 0;
        for _ in 1..(ORDRE.len() - 3) {
            decaler_plateaux(&mut values).unwrap();
        }
        assert_eq!(values, expected);
    }

    #[test]
    fn run_logic_updates_alarm_and_advances_plateaux() {
        let mut memory = Memory::new();
        memory.set("temperature", Value::Int16(55));
        memory.set("alarm", Value::Bool(false));
        let mut frames = vec![ModbusFrame {
            name: "FrameEmplPlateaux".to_string(),
            address: 2544,
            values: (0..120).collect(),
            minimum_registers: 120,
            read_only: false,
            bindings: Vec::new(),
        }];

        run_logic(&mut memory, &mut frames, true).unwrap();

        assert_eq!(memory.get("alarm"), Some(Value::Bool(true)));
        assert_eq!(frames[0].values[0], 109);
        assert_eq!(frames[0].values[1], 0);
    }
}
