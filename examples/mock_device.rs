//! ============================================================================
//! FAUX ÉQUIPEMENT MODBUS TCP — pour tester sans matériel réel
//! ============================================================================
//! Simule un équipement Modbus TCP (le futur "MODBUS_DEC") pour pouvoir
//! tester ModbusClient (src/communication/modbus.rs) sans avoir le vrai
//! matériel branché :
//!   - input register 0  (adresse décimale 30001) : température, monte
//!     toute seule dans une tâche de fond, comme un vrai capteur
//!   - coil 0             (adresse décimale 00001) : alarme, modifiable
//!     depuis l'extérieur (donc depuis notre ModbusClient côté automate)
//!
//! Lance-le avec : cargo run --example mock_device
//! (dans un terminal séparé de `cargo run` qui lance le simulateur)
//!
//! Ce fichier tourne en dehors du programme principal (dossier examples/,
//! pas src/) : c'est un outil de test, pas une brique du simulateur.
//!
//! ➜ Pour ajouter un autre registre simulé (ex: une pression sur
//! l'input register 1 = adresse 30002), copie le modèle utilisé pour la
//! température : ajoute une entrée dans `input_registers` dans
//! MockDevice::new(), et fais-la évoluer dans la tâche de fond plus bas
//! si tu veux qu'elle bouge automatiquement.

use std::{
    collections::HashMap,
    future,
    net::SocketAddr,
    sync::{Arc, Mutex},
    time::Duration,
};
use tokio::net::TcpListener;
use tokio_modbus::{
    prelude::*,
    server::tcp::{accept_tcp_connection, Server},
};

#[derive(Clone)]
struct MockDevice {
    input_registers: Arc<Mutex<HashMap<u16, u16>>>,
    coils: Arc<Mutex<HashMap<u16, bool>>>,
}

impl MockDevice {
    fn new() -> Self {
        let mut input_registers = HashMap::new();
        input_registers.insert(0, 25); // "température" de départ

        let mut coils = HashMap::new();
        coils.insert(0, false); // "alarme"

        Self {
            input_registers: Arc::new(Mutex::new(input_registers)),
            coils: Arc::new(Mutex::new(coils)),
        }
    }
}

impl tokio_modbus::server::Service for MockDevice {
    type Request = Request<'static>;
    type Response = Response;
    type Exception = ExceptionCode;
    type Future = future::Ready<Result<Self::Response, Self::Exception>>;

    fn call(&self, req: Self::Request) -> Self::Future {
        let res = match req {
            Request::ReadInputRegisters(addr, cnt) => {
                let regs = self.input_registers.lock().unwrap();
                let mut values = Vec::with_capacity(cnt as usize);
                let mut ok = true;
                for i in 0..cnt {
                    match regs.get(&(addr + i)) {
                        Some(v) => values.push(*v),
                        None => {
                            ok = false;
                            break;
                        }
                    }
                }
                if ok {
                    Ok(Response::ReadInputRegisters(values))
                } else {
                    Err(ExceptionCode::IllegalDataAddress)
                }
            }
            Request::ReadCoils(addr, cnt) => {
                let coils = self.coils.lock().unwrap();
                let mut values = Vec::with_capacity(cnt as usize);
                let mut ok = true;
                for i in 0..cnt {
                    match coils.get(&(addr + i)) {
                        Some(v) => values.push(*v),
                        None => {
                            ok = false;
                            break;
                        }
                    }
                }
                if ok {
                    Ok(Response::ReadCoils(values))
                } else {
                    Err(ExceptionCode::IllegalDataAddress)
                }
            }
            Request::WriteSingleCoil(addr, value) => {
                let mut coils = self.coils.lock().unwrap();
                coils.insert(addr, value);
                println!("MOCK DEVICE: coil {addr} <- {value}");
                Ok(Response::WriteSingleCoil(addr, value))
            }
            _ => {
                println!("MOCK DEVICE: fonction non gérée dans ce mock: {req:?}");
                Err(ExceptionCode::IllegalFunction)
            }
        };
        future::ready(res)
    }
}

#[tokio::main]
async fn main() -> anyhow::Result<()> {
    let socket_addr: SocketAddr = "127.0.0.1:5502".parse()?;
    let device = MockDevice::new();

    // La "température" monte toute seule, comme un vrai capteur.
    let registers_for_bg = device.input_registers.clone();
    tokio::spawn(async move {
        loop {
            tokio::time::sleep(Duration::from_millis(500)).await;
            let mut regs = registers_for_bg.lock().unwrap();
            let t = regs.entry(0).or_insert(25);
            *t += 1;
        }
    });

    println!("=== Mock équipement Modbus TCP sur {socket_addr} ===");
    println!("  input register 0   -> température (monte toute seule)");
    println!("  coil 0             -> alarme (écrite par le client)");

    let listener = TcpListener::bind(socket_addr).await?;
    let server = Server::new(listener);
    let on_connected = |stream, socket_addr| {
        let device = device.clone();
        async move {
            let new_service = move |_socket_addr| Ok(Some(device.clone()));
            accept_tcp_connection(stream, socket_addr, new_service)
        }
    };
    let on_process_error = |err| eprintln!("{err}");
    server.serve(&on_connected, on_process_error).await?;
    Ok(())
}
