//! ============================================================================
//! DATATYPE — les types de données que peut prendre une variable
//! ============================================================================
//! Ce fichier définit UNIQUEMENT la liste des types possibles. C'est une
//! sorte de "catalogue". La vraie valeur (le nombre ou le booléen lui-même)
//! est stockée dans `Value` (voir value.rs).
//!
//! ➜ Tu n'as normalement PAS besoin de modifier ce fichier pour ajouter une
//! variable — les types existants (Bool, Int16, UInt16, Word, UInt32, DWord)
//! couvrent la grande majorité des besoins d'un automate.
//!
//! Tu devrais y toucher seulement si tu as besoin d'un type qui n'existe pas
//! encore (par exemple Float32 pour des valeurs décimales). Dans ce cas :
//!   1. ajoute la variante ici (ex: Float32)
//!   2. ajoute-la aussi dans l'enum Value de value.rs (ex: Value::Float32(f32))
//!   3. mets à jour size_bytes() ci-dessous et les méthodes as_f64()/to_json()
//!      dans value.rs

/// Types de données supportés par l'automate.
/// On garde WORD/DWORD distincts de UINT16/UINT32 même si la taille
/// mémoire est identique : la sémantique n'est pas la même côté PLC
/// (un "mot" WORD est souvent une valeur binaire/bitfield, alors qu'un
/// UINT16 est un nombre qu'on additionne/compare).
#[derive(Debug, Clone, Copy, PartialEq, Eq, Hash)]
pub enum DataType {
    Bool,
    Int16,
    UInt16,
    Word,
    UInt32,
    DWord,
    // ➜ AJOUTE ICI un nouveau type si besoin, ex: Float32,
}

impl DataType {
    /// Taille en octets de ce type. Utile plus tard pour calculer des
    /// adresses mémoire contiguës (façon DB1.0, DB1.2, DB1.4...) ou pour
    /// dimensionner des trames Modbus qui font plusieurs registres.
    pub fn size_bytes(&self) -> usize {
        match self {
            DataType::Bool => 1,
            DataType::Int16 | DataType::UInt16 | DataType::Word => 2,
            DataType::UInt32 | DataType::DWord => 4,
            // ➜ si tu ajoutes un type dans l'enum ci-dessus, ajoute son
            //   cas ici aussi (le compilateur te le rappellera de toute façon).
        }
    }
}
