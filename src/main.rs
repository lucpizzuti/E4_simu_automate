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

use core::memory::Memory;
use core::value::Value;
use serde_json::json;
use std::sync::Arc;
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
fn run_logic(mem: &mut Memory) {
    let temperature = mem.get("temperature").unwrap().as_f64();
    mem.set("alarm", Value::Bool(temperature > 50.0));

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
fn state_json(cycle: u32, mem: &Memory) -> String {
    let variables: Vec<_> = mem
        .dump()
        .into_iter()
        .map(|(name, value)| {
            json!({
                "name": name,
                "type": value.type_name(),
                "value": value.to_json(),
            })
        })
        .collect();
    json!({ "cycle": cycle, "variables": variables }).to_string()
}

#[tokio::main]
async fn main() {
    // `tx` est le "haut-parleur" WebSocket : tout ce qu'on envoie avec
    // tx.send(...) est reçu par tous les navigateurs connectés à la page.
    let (tx, _rx) = broadcast::channel::<String>(16);
    let state = Arc::new(web::AppState { tx: tx.clone() });

    // --- Boucle de simulation (le "moteur automate") ---
    // Tourne dans sa propre tâche asynchrone, en parallèle du serveur web,
    // pour que l'un ne bloque jamais l'autre.
    tokio::spawn(async move {
        let mut mem = Memory::new();

        // ========================================================================
        // VARIABLES — ➜ AJOUTE ICI tes propres variables (mémoire de l'automate)
        // ========================================================================
        //
        // Chaque ligne mem.set(nom, valeur) crée une variable dans la mémoire.
        // Elle sera automatiquement :
        //   - visible dans l'interface web (table "Variable / Type / Valeur")
        //   - utilisable dans run_logic() ci-dessus via mem.get("nom")
        //   - mappable vers une adresse Modbus (voir le bloc suivant)
        //
        // Types disponibles (voir src/core/value.rs) :
        //   Value::Bool(bool)     -> un booléen (ex: alarme, marche/arrêt)
        //   Value::Int16(i16)     -> entier signé 16 bits (-32768 à 32767)
        //   Value::UInt16(u16)    -> entier non signé 16 bits (0 à 65535)
        //   Value::Word(u16)      -> comme UInt16, mais sémantique "mot" PLC
        //   Value::UInt32(u32)    -> entier non signé 32 bits
        //   Value::DWord(u32)     -> comme UInt32, mais sémantique "double mot" PLC
        //
        mem.set("temperature", Value::Int16(25));
        mem.set("alarm", Value::Bool(false));
        mem.set("counter", Value::UInt32(0));

        // ➜ AJOUTE ICI tes variables, par exemple :
        // mem.set("pressure", Value::UInt16(1013));
        // mem.set("motor", Value::Bool(false));
        // mem.set("overheat_count", Value::UInt32(0));

        // (Optionnel) Se connecter à un vrai équipement Modbus TCP.
        // Décommente et adapte l'IP/port pour brancher ton équipement réel
        // (voir aussi src/communication/modbus.rs pour le détail de l'API).
        //
        // use communication::modbus::ModbusClient;
        // let modbus_addr = "192.168.1.50:502".parse().unwrap();
        // let mut modbus = ModbusClient::connect(modbus_addr).await
        //     .expect("connexion Modbus impossible");

        let mut cycle: u32 = 0;
        loop {
            cycle += 1;

            // 1. LECTURE DES ENTRÉES
            // Aujourd'hui : simulation. Demain : lecture réelle sur l'équipement.
            simulate_input(&mut mem, cycle);

            // ================================================================
            // ENVOI / RÉCEPTION DE DONNÉES MODBUS — ➜ AJOUTE ICI
            // ================================================================
            //
            // C'est ICI, dans la boucle de cycle, qu'on lit/écrit le vrai
            // équipement Modbus, entre la lecture des entrées et la logique.
            // Modèle à décommenter/adapter une fois `modbus` connecté
            // ci-dessus :
            //
            // // Lire une température depuis le registre 30001 (input register 0)
            // // et l'écrire dans la mémoire locale de l'automate :
            // if let Ok(raw) = modbus.read_decimal(30001).await {
            //     mem.set("temperature", Value::Int16(raw as i16));
            // }
            //
            // // Écrire l'état de l'alarme locale vers le coil 00001 de
            // // l'équipement (donc APRÈS run_logic(), qui calcule "alarm") :
            // let alarm = mem.get("alarm").unwrap().as_bool();
            // let _ = modbus.write_decimal(1, alarm as u16).await;
            //
            // Rappel des familles d'adresses décimales (voir modbus.rs) :
            //   00001-09999 -> Coil            (lecture/écriture, 1 bit)
            //   10001-19999 -> DiscreteInput   (lecture seule, 1 bit)
            //   30001-39999 -> InputRegister   (lecture seule, 16 bits)
            //   40001-49999 -> HoldingRegister (lecture/écriture, 16 bits)

            // 2. LOGIQUE UTILISATEUR (le "programme" de l'automate)
            run_logic(&mut mem);

            // 3. écriture Modbus des sorties calculées : voir bloc ci-dessus,
            //    à placer ici si l'écriture doit avoir lieu APRÈS la logique
            //    (cas le plus courant : on calcule "alarm" puis on l'envoie).

            // Compteur de cycles interne (utile pour debug / supervision)
            if let Some(Value::UInt32(c)) = mem.get("counter") {
                mem.set("counter", Value::UInt32(c + 1));
            }

            // Diffusion de l'état complet vers l'interface web.
            // On ignore l'erreur : elle signifie juste "aucun client connecté".
            let _ = tx.send(state_json(cycle, &mem));

            // Durée d'un cycle. Un vrai automate tourne souvent entre 10ms
            // et quelques centaines de ms selon l'application.
            sleep(Duration::from_millis(200)).await;
        }
    });

    // --- Serveur web ---
    // Sert la page HTML (src/web/index.html) et le endpoint WebSocket /ws
    // qui diffuse l'état de la mémoire à chaque cycle. Voir src/web.rs.
    let app = web::build_router(state);
    let listener = tokio::net::TcpListener::bind("0.0.0.0:3000").await.unwrap();
    println!("=== Automate Simulator — serveur sur http://127.0.0.1:3000 ===");
    axum::serve(listener, app).await.unwrap();
}
