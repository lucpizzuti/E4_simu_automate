//! ============================================================================
//! MEMORY — la mémoire de l'automate (toutes les variables, nom -> valeur)
//! ============================================================================
//! C'est le "tableau de variables" central. Toutes les fonctions de main.rs
//! (run_logic, simulate_input, state_json...) passent par cette structure.
//!
//! ➜ Tu n'as normalement pas besoin de modifier ce fichier. Pour ajouter
//! une variable, va dans main.rs et utilise mem.set("nom", Value::...).
//!
//! Note d'architecture : aujourd'hui l'adressage se fait par NOM
//! ("temperature", "alarm"...). Une évolution possible plus tard serait un
//! adressage façon PLC (DB1.10, DB1.12...) mais ce n'est pas nécessaire
//! tant que le nombre de variables reste raisonnable — le nom est plus
//! lisible et suffit largement pour un simulateur.

use super::value::Value;
use std::collections::HashMap;

/// Mémoire de l'automate : une simple table nom -> valeur.
#[derive(Debug, Default)]
pub struct Memory {
    values: HashMap<String, Value>,
}

impl Memory {
    pub fn new() -> Self {
        Self { values: HashMap::new() }
    }

    /// Crée ou met à jour une variable. Si le nom existe déjà, l'ancienne
    /// valeur (même si elle était d'un type différent) est remplacée.
    pub fn set(&mut self, name: &str, value: Value) {
        self.values.insert(name.to_string(), value);
    }

    /// Lit une variable. Retourne None si le nom n'existe pas encore —
    /// pense à bien faire mem.set(...) au démarrage (voir main.rs) avant
    /// de faire mem.get(...) dessus dans la boucle, sinon .unwrap() paniquera.
    pub fn get(&self, name: &str) -> Option<Value> {
        self.values.get(name).copied()
    }

    /// Renvoie toutes les variables triées par nom. Utilisé pour :
    ///   - l'affichage dans l'interface web (state_json() dans main.rs)
    ///   - le débogage / les logs
    pub fn dump(&self) -> Vec<(String, Value)> {
        let mut items: Vec<_> = self.values.iter().map(|(k, v)| (k.clone(), *v)).collect();
        items.sort_by(|a, b| a.0.cmp(&b.0));
        items
    }
}
