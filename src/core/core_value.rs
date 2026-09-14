//! ============================================================================
//! VALUE — la valeur réellement stockée pour chaque variable
//! ============================================================================
//! Différence avec datatype.rs : DataType dit "quel type", Value contient
//! "la donnée elle-même" (25, true, 1024...). Chaque variable de la Memory
//! (voir memory.rs) est un Value.
//!
//! ➜ Tu n'as normalement pas besoin de modifier ce fichier pour utiliser
//! des variables existantes (Bool, Int16, UInt16, Word, UInt32, DWord).
//! Regarde plutôt main.rs pour savoir comment créer/lire/écrire une
//! variable avec mem.set()/mem.get().
//!
//! Tu devrais y toucher seulement si tu ajoutes un nouveau type dans
//! datatype.rs (ex: Float32) : il faut alors ajouter la variante
//! correspondante ici, ET mettre à jour as_f64(), type_name() et to_json().

use std::fmt;

/// Une valeur typée. C'est ce qui est réellement stocké en mémoire
/// pour chaque adresse/variable.
#[derive(Debug, Clone, Copy, PartialEq)]
pub enum Value {
    Bool(bool),
    Int16(i16),
    UInt16(u16),
    Word(u16),
    UInt32(u32),
    DWord(u32),
    // ➜ AJOUTE ICI un nouveau type si besoin, ex: Float32(f32),
    //   (et pense à faire pareil dans datatype.rs)
}

impl Value {
    /// Comparaison "numérique" utilisée par la logique métier (>, <, ==,
    /// etc. dans run_logic() de main.rs). On convertit tout en f64 pour
    /// rester simple : un bool devient 1.0/0.0, un entier devient son
    /// équivalent flottant.
    pub fn as_f64(&self) -> f64 {
        match self {
            Value::Bool(b) => if *b { 1.0 } else { 0.0 },
            Value::Int16(v) => *v as f64,
            Value::UInt16(v) => *v as f64,
            Value::Word(v) => *v as f64,
            Value::UInt32(v) => *v as f64,
            Value::DWord(v) => *v as f64,
        }
    }

    /// Interprétation booléenne : un Bool reste lui-même, tout le reste
    /// est "vrai" si différent de zéro (convention classique en automatisme).
    pub fn as_bool(&self) -> bool {
        match self {
            Value::Bool(b) => *b,
            other => other.as_f64() != 0.0,
        }
    }

    /// Nom du type affiché dans l'interface web (colonne "Type" du tableau,
    /// voir src/web/index.html) et dans les logs.
    pub fn type_name(&self) -> &'static str {
        match self {
            Value::Bool(_) => "BOOL",
            Value::Int16(_) => "INT16",
            Value::UInt16(_) => "UINT16",
            Value::Word(_) => "WORD",
            Value::UInt32(_) => "UINT32",
            Value::DWord(_) => "DWORD",
        }
    }

    /// Valeur JSON envoyée au frontend via WebSocket (voir state_json()
    /// dans main.rs). Un bool reste un booléen JSON (true/false), tout le
    /// reste devient un nombre JSON.
    pub fn to_json(&self) -> serde_json::Value {
        match self {
            Value::Bool(b) => serde_json::Value::Bool(*b),
            other => serde_json::json!(other.as_f64()),
        }
    }
}

impl fmt::Display for Value {
    /// Affichage texte (utilisé par les logs console dans les anciennes
    /// versions du programme et par Debug/println!("{}", value)).
    fn fmt(&self, f: &mut fmt::Formatter<'_>) -> fmt::Result {
        match self {
            Value::Bool(b) => write!(f, "{}", b),
            Value::Int16(v) => write!(f, "{}", v),
            Value::UInt16(v) => write!(f, "{}", v),
            Value::Word(v) => write!(f, "{}", v),
            Value::UInt32(v) => write!(f, "{}", v),
            Value::DWord(v) => write!(f, "{}", v),
        }
    }
}
