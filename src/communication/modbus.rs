//! ============================================================================
//! CLIENT MODBUS TCP — parle avec un vrai équipement (le "MODBUS_DEC")
//! ============================================================================
//! Ce fichier fait deux choses :
//!   1. parse_decimal_address() : traduit une adresse "humaine" façon
//!      Modicon (40001, 30001...) vers l'adresse technique 0-based que le
//!      protocole Modbus envoie réellement sur le réseau.
//!   2. ModbusClient : une petite façade autour de la crate tokio-modbus
//!      pour lire/écrire directement avec cette adresse décimale, sans se
//!      soucier de la conversion à chaque appel.
//!
//! ➜ Tu n'as normalement pas besoin de modifier ce fichier.
//!
//! COMMENT S'EN SERVIR DEPUIS main.rs (voir aussi les commentaires
//! "➜ AJOUTE ICI" dans main.rs, section "ENVOI / RÉCEPTION DE DONNÉES") :
//!
//!   use communication::modbus::ModbusClient;
//!
//!   // 1. se connecter une fois au démarrage, avec l'IP/port du vrai
//!   //    équipement (502 est le port standard Modbus TCP) :
//!   let addr = "192.168.1.50:502".parse().unwrap();
//!   let mut modbus = ModbusClient::connect(addr).await.unwrap();
//!
//!   // 1bis. si ton équipement demande un unit ID / adresse d'esclave
//!   //    précis (visible dans sa config, ex: 255) :
//!   modbus.set_slave(255);
//!
//!   // 2. dans la boucle de cycle, lire une valeur reçue de l'équipement :
//!   let temperature = modbus.read_decimal(30001).await.unwrap();
//!
//!   // 3. et/ou écrire une valeur calculée localement vers l'équipement :
//!   modbus.write_decimal(1, alarm as u16).await.unwrap();
//!
//! Pour tester SANS matériel réel, lance le faux équipement fourni :
//!   cargo run --example mock_device
//! puis connecte-toi sur 127.0.0.1:5502 au lieu de l'IP réelle.

use anyhow::{anyhow, Result};
use std::net::SocketAddr;
use tokio_modbus::client::{tcp, Context};
use tokio_modbus::prelude::*;
use tokio_modbus::slave::{Slave, SlaveContext};

/// Les 4 familles d'objets Modbus.
#[derive(Debug, Clone, Copy, PartialEq, Eq)]
pub enum RegisterKind {
    Coil,            // 0xxxx — lecture/écriture, 1 bit
    DiscreteInput,   // 1xxxx — lecture seule, 1 bit
    InputRegister,   // 3xxxx — lecture seule, 16 bits
    HoldingRegister, // 4xxxx — lecture/écriture, 16 bits
}

/// Une adresse Modbus décodée : la famille + l'offset 0-based réel
/// envoyé sur le fil.
#[derive(Debug, Clone, Copy)]
pub struct ModbusAddress {
    pub kind: RegisterKind,
    pub offset: u16,
}

/// Décode une adresse "décimale" façon Modicon/MODBUS_DEC :
///   00001-09999  -> Coil            (offset = addr - 1)
///   10001-19999  -> DiscreteInput   (offset = addr - 10001)
///   30001-39999  -> InputRegister   (offset = addr - 30001)
///   40001-49999  -> HoldingRegister (offset = addr - 40001)
///
/// C'est la convention 5 chiffres classique : le premier chiffre
/// indique le type d'objet, les 4 suivants l'adresse dans sa famille
/// en partant de 1 (donc offset réel = valeur - 1 dans la famille).
pub fn parse_decimal_address(addr: u32) -> Result<ModbusAddress> {
    let (kind, base) = match addr / 10000 {
        0 => (RegisterKind::Coil, 0),
        1 => (RegisterKind::DiscreteInput, 10000),
        3 => (RegisterKind::InputRegister, 30000),
        4 => (RegisterKind::HoldingRegister, 40000),
        _ => {
            return Err(anyhow!(
                "adresse décimale {} invalide : doit commencer par 0, 1, 3 ou 4",
                addr
            ))
        }
    };
    if addr <= base {
        return Err(anyhow!(
            "adresse décimale {} hors plage pour sa famille",
            addr
        ));
    }
    let offset = (addr - base - 1) as u16;
    Ok(ModbusAddress { kind, offset })
}

/// Client Modbus TCP. Se connecte à un équipement (le "MODBUS_DEC")
/// via son IP:port (502 par défaut) et lit/écrit par adresse décimale.
pub struct ModbusClient {
    ctx: Context,
}

impl ModbusClient {
    pub async fn connect(addr: SocketAddr) -> Result<Self> {
        let ctx = tcp::connect(addr).await?;
        Ok(Self { ctx })
    }

    /// Fixe l'unit ID (= "adresse d'esclave" dans certaines interfaces,
    /// ex: Device01 configuré avec 255 dans l'appli du client). En Modbus
    /// TCP direct (pas de passerelle vers un bus série), 255 (0xFF) est
    /// justement la valeur standard "device TCP direct" — donc si ton
    /// équipement affiche 255, c'est probablement la config normale, pas
    /// une erreur. Appelle cette méthode juste après connect() si besoin :
    ///
    ///   let mut modbus = ModbusClient::connect(addr).await?;
    ///   modbus.set_slave(255);
    pub fn set_slave(&mut self, unit_id: u8) {
        self.ctx.set_slave(Slave(unit_id));
    }

    /// Lit une valeur unique à l'adresse décimale donnée.
    /// Retourne un u16 (0/1 pour les bits, valeur brute pour les registres).
    ///
    /// ➜ Limite actuelle : ne lit qu'UNE seule adresse à la fois (count=1
    /// en interne). Si tu as besoin de lire plusieurs registres consécutifs
    /// d'un coup (ex: une valeur 32 bits sur 2 registres), il faudra ajouter
    /// une méthode read_decimal_many(decimal_addr, count) qui suit le même
    /// principe mais retourne un Vec<u16>.
    pub async fn read_decimal(&mut self, decimal_addr: u32) -> Result<u16> {
        let addr = parse_decimal_address(decimal_addr)?;
        let value = match addr.kind {
            RegisterKind::Coil => {
                let bits = self.ctx.read_coils(addr.offset, 1).await??;
                bits[0] as u16
            }
            RegisterKind::DiscreteInput => {
                let bits = self.ctx.read_discrete_inputs(addr.offset, 1).await??;
                bits[0] as u16
            }
            RegisterKind::InputRegister => {
                let regs = self.ctx.read_input_registers(addr.offset, 1).await??;
                regs[0]
            }
            RegisterKind::HoldingRegister => {
                let regs = self.ctx.read_holding_registers(addr.offset, 1).await??;
                regs[0]
            }
        };
        Ok(value)
    }

    /// Écrit une valeur à l'adresse décimale donnée (coil ou holding
    /// register uniquement — les entrées sont en lecture seule côté
    /// équipement).
    pub async fn write_decimal(&mut self, decimal_addr: u32, value: u16) -> Result<()> {
        let addr = parse_decimal_address(decimal_addr)?;
        match addr.kind {
            RegisterKind::Coil => {
                self.ctx
                    .write_single_coil(addr.offset, value != 0)
                    .await??;
            }
            RegisterKind::HoldingRegister => {
                self.ctx.write_single_register(addr.offset, value).await??;
            }
            _ => {
                return Err(anyhow!(
                    "l'adresse {} ({:?}) est en lecture seule, écriture impossible",
                    decimal_addr,
                    addr.kind
                ))
            }
        }
        Ok(())
    }
}

#[cfg(test)]
mod tests {
    use super::*;

    #[test]
    fn decode_coil() {
        let a = parse_decimal_address(1).unwrap();
        assert_eq!(a.kind, RegisterKind::Coil);
        assert_eq!(a.offset, 0);
    }

    #[test]
    fn decode_discrete_input() {
        let a = parse_decimal_address(10001).unwrap();
        assert_eq!(a.kind, RegisterKind::DiscreteInput);
        assert_eq!(a.offset, 0);
    }

    #[test]
    fn decode_input_register() {
        let a = parse_decimal_address(30012).unwrap();
        assert_eq!(a.kind, RegisterKind::InputRegister);
        assert_eq!(a.offset, 11);
    }

    #[test]
    fn decode_holding_register() {
        let a = parse_decimal_address(40001).unwrap();
        assert_eq!(a.kind, RegisterKind::HoldingRegister);
        assert_eq!(a.offset, 0);
    }

    #[test]
    fn rejects_invalid_family() {
        assert!(parse_decimal_address(20001).is_err());
    }
}
