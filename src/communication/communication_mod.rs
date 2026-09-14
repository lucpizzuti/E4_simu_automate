//! Regroupe tout ce qui parle à des équipements externes. Aujourd'hui :
//! le client Modbus TCP (modbus.rs). Si tu ajoutes un jour un autre
//! protocole (OPC-UA, MQTT...), c'est ici que tu ajouterais un nouveau
//! sous-module, ex: pub mod opcua;

pub mod modbus;
