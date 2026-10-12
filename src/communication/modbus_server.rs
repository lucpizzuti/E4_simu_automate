//! Modbus TCP server exposing the Holding Register frames declared in COMM.DAT.

use crate::core::{memory::Memory, value::Value};
use anyhow::{anyhow, bail, Context, Result};
use serde::{Deserialize, Serialize};
use std::{
    fs, future,
    net::SocketAddr,
    path::{Path, PathBuf},
    sync::{Arc, RwLock},
};
use tokio::net::TcpListener;
use tokio_modbus::{
    prelude::*,
    server::tcp::{accept_tcp_connection, Server},
};

#[derive(Debug, Clone, Serialize, Deserialize)]
pub struct ModbusFrame {
    pub name: String,
    pub address: u16,
    pub values: Vec<u16>,
    pub minimum_registers: usize,
    pub read_only: bool,
    pub bindings: Vec<VariableBinding>,
}

#[derive(Debug, Clone, Serialize, Deserialize, PartialEq, Eq)]
pub struct VariableBinding {
    pub variable: String,
    pub offset: usize,
}

#[derive(Debug, Clone, Serialize, Deserialize)]
pub struct FrameUpdate {
    pub name: String,
    pub address: u16,
    pub values: Vec<u16>,
    #[serde(default)]
    pub bindings: Vec<VariableBinding>,
}

#[derive(Clone)]
pub struct ModbusState {
    frames: Arc<RwLock<Vec<ModbusFrame>>>,
    config_path: Arc<PathBuf>,
    memory: Arc<RwLock<Memory>>,
}

#[derive(Debug)]
pub enum UpdateError {
    Invalid(String),
    Persistence(std::io::Error),
    LockPoisoned,
}

impl ModbusState {
    pub fn load(
        comm_path: &Path,
        config_path: &Path,
        memory: Arc<RwLock<Memory>>,
    ) -> Result<(Self, u16)> {
        let contents = fs::read_to_string(comm_path)
            .with_context(|| format!("impossible de lire {}", comm_path.display()))?;
        let port = parse_modbus_port(&contents)?;
        let mut frames = parse_frames(&contents)?;

        if config_path.exists() {
            let saved = fs::read(config_path)
                .with_context(|| format!("impossible de lire {}", config_path.display()))?;
            let updates: Vec<FrameUpdate> = serde_json::from_slice(&saved).with_context(|| {
                format!("configuration invalide dans {}", config_path.display())
            })?;
            frames = restore_saved_updates(&frames, updates, &memory)?;
        }
        sync_frame_bindings_to_memory(&frames, &memory)?;

        Ok((
            Self {
                frames: Arc::new(RwLock::new(frames)),
                config_path: Arc::new(config_path.to_path_buf()),
                memory,
            },
            port,
        ))
    }

    pub fn snapshot(&self) -> Result<Vec<ModbusFrame>> {
        self.frames
            .read()
            .map(|frames| frames.clone())
            .map_err(|_| anyhow!("verrou de configuration Modbus indisponible"))
    }

    pub fn update(&self, updates: Vec<FrameUpdate>) -> std::result::Result<(), UpdateError> {
        let current = self
            .frames
            .read()
            .map_err(|_| UpdateError::LockPoisoned)?
            .clone();
        let mut updated = apply_updates(&current, updates, &self.memory)
            .map_err(|error| UpdateError::Invalid(error.to_string()))?;
        initialize_new_bindings(&current, &mut updated, &self.memory)
            .map_err(|error| UpdateError::Invalid(error.to_string()))?;
        let persisted: Vec<_> = updated
            .iter()
            .map(|frame| FrameUpdate {
                name: frame.name.clone(),
                address: frame.address,
                values: frame.values.clone(),
                bindings: frame.bindings.clone(),
            })
            .collect();
        let contents = serde_json::to_vec_pretty(&persisted)
            .map_err(|error| UpdateError::Invalid(error.to_string()))?;
        fs::write(self.config_path.as_path(), contents).map_err(UpdateError::Persistence)?;
        sync_frame_bindings_to_memory(&updated, &self.memory)
            .map_err(|error| UpdateError::Invalid(error.to_string()))?;
        *self.frames.write().map_err(|_| UpdateError::LockPoisoned)? = updated;
        Ok(())
    }

    pub fn variable_snapshot(&self) -> Result<Vec<(String, &'static str, serde_json::Value)>> {
        self.memory
            .read()
            .map(|memory| {
                memory
                    .dump()
                    .into_iter()
                    .map(|(name, value)| (name, value.type_name(), value.to_json()))
                    .collect()
            })
            .map_err(|_| anyhow!("verrou de mémoire indisponible"))
    }

    pub fn sync_from_memory(&self) -> Result<()> {
        let memory = self
            .memory
            .read()
            .map_err(|_| anyhow!("verrou de mémoire indisponible"))?;
        let values: Vec<_> = self
            .frames
            .read()
            .map_err(|_| anyhow!("verrou de configuration Modbus indisponible"))?
            .iter()
            .map(|frame| {
                let bindings = frame
                    .bindings
                    .iter()
                    .filter_map(|binding| {
                        memory
                            .get(&binding.variable)
                            .map(|value| (binding.offset, value_to_registers(value)))
                    })
                    .collect::<Vec<_>>();
                (frame.name.clone(), bindings)
            })
            .collect();
        drop(memory);
        let mut frames = self
            .frames
            .write()
            .map_err(|_| anyhow!("verrou de configuration Modbus indisponible"))?;
        for frame in frames.iter_mut() {
            let Some((_, bindings)) = values.iter().find(|(name, _)| name == &frame.name) else {
                continue;
            };
            for (offset, words) in bindings {
                for (index, word) in words.iter().enumerate() {
                    if let Some(register) = frame.values.get_mut(offset + index) {
                        *register = *word;
                    }
                }
            }
        }
        Ok(())
    }
}

fn parse_frames(contents: &str) -> Result<Vec<ModbusFrame>> {
    let mut frames = Vec::new();
    for (line_number, line) in contents.lines().enumerate() {
        if !line.starts_with("FRAME,") {
            continue;
        }
        let fields = parse_csv_line(line)
            .with_context(|| format!("ligne {} de COMM.DAT invalide", line_number + 1))?;
        if !fields
            .get(10)
            .map(String::as_str)
            .unwrap_or("")
            .contains("Holding registers")
        {
            bail!(
                "famille Modbus non prise en charge à la ligne {} de COMM.DAT",
                line_number + 1
            );
        }
        let name = fields
            .get(4)
            .filter(|name| !name.is_empty())
            .ok_or_else(|| anyhow!("nom de frame absent à la ligne {}", line_number + 1))?
            .clone();
        let byte_count: usize = fields
            .get(6)
            .ok_or_else(|| anyhow!("taille absente à la ligne {}", line_number + 1))?
            .parse()
            .with_context(|| format!("taille invalide à la ligne {}", line_number + 1))?;
        if byte_count == 0 || byte_count % 2 != 0 {
            bail!(
                "taille de frame impaire ou nulle à la ligne {}",
                line_number + 1
            );
        }
        let address: u16 = fields
            .get(9)
            .ok_or_else(|| anyhow!("adresse absente à la ligne {}", line_number + 1))?
            .parse()
            .with_context(|| format!("adresse invalide à la ligne {}", line_number + 1))?;
        let access = fields.get(8).map(String::as_str).unwrap_or("");
        if access != "R" && access != "RW" {
            bail!("mode d'accès invalide pour {name} : {access}");
        }
        frames.push(ModbusFrame {
            name,
            address,
            values: vec![0; byte_count / 2],
            minimum_registers: byte_count / 2,
            read_only: access == "R",
            bindings: Vec::new(),
        });
    }
    if frames.is_empty() {
        bail!("aucune frame Holding registers trouvée dans COMM.DAT");
    }
    validate_ranges(&frames)?;
    Ok(frames)
}

fn parse_modbus_port(contents: &str) -> Result<u16> {
    for line in contents.lines().filter(|line| line.starts_with("EQT,")) {
        let fields = parse_csv_line(line)?;
        if let Some(endpoint) = fields.get(18) {
            if let Some(port) = endpoint.split('#').nth(4) {
                let port: u16 = port.parse().context("port Modbus invalide dans COMM.DAT")?;
                if port != 0 {
                    return Ok(port);
                }
            }
        }
    }
    bail!("adresse et port Modbus introuvables dans la ligne EQT de COMM.DAT")
}

fn parse_csv_line(line: &str) -> Result<Vec<String>> {
    let mut fields = Vec::new();
    let mut field = String::new();
    let mut quoted = false;
    let mut chars = line.chars().peekable();

    while let Some(ch) = chars.next() {
        match ch {
            '"' if quoted && chars.peek() == Some(&'"') => {
                field.push('"');
                chars.next();
            }
            '"' if quoted => quoted = false,
            '"' if field.trim().is_empty() => quoted = true,
            ',' if !quoted => {
                fields.push(field.trim().to_string());
                field.clear();
            }
            _ => field.push(ch),
        }
    }
    if quoted {
        bail!("guillemet non fermé");
    }
    fields.push(field.trim().to_string());
    Ok(fields)
}

fn apply_updates(
    current: &[ModbusFrame],
    updates: Vec<FrameUpdate>,
    memory: &Arc<RwLock<Memory>>,
) -> Result<Vec<ModbusFrame>> {
    if updates.len() != current.len() {
        bail!("le nombre de frames reçu ne correspond pas à COMM.DAT");
    }
    let mut updated = Vec::with_capacity(current.len());
    for frame in current {
        let matches: Vec<_> = updates
            .iter()
            .filter(|item| item.name == frame.name)
            .collect();
        if matches.len() != 1 {
            bail!(
                "configuration absente ou dupliquée pour la frame {}",
                frame.name
            );
        }
        let item = matches[0];
        if item.values.len() < frame.minimum_registers {
            bail!(
                "la frame {} doit contenir au moins {} registres (taille minimale de COMM.DAT)",
                frame.name,
                frame.minimum_registers
            );
        }
        updated.push(ModbusFrame {
            name: frame.name.clone(),
            address: item.address,
            values: item.values.clone(),
            minimum_registers: frame.minimum_registers,
            read_only: frame.read_only,
            bindings: item.bindings.clone(),
        });
    }
    validate_ranges(&updated)?;
    validate_bindings(&updated, memory)?;
    Ok(updated)
}

fn validate_bindings(frames: &[ModbusFrame], memory: &Arc<RwLock<Memory>>) -> Result<()> {
    let memory = memory
        .read()
        .map_err(|_| anyhow!("verrou de mémoire indisponible"))?;
    let mut variables = std::collections::HashSet::new();
    let mut occupied = std::collections::HashSet::new();
    for frame in frames {
        for binding in &frame.bindings {
            if !variables.insert(binding.variable.as_str()) {
                bail!(
                    "la variable {} est associée plusieurs fois",
                    binding.variable
                );
            }
            let value = memory
                .get(&binding.variable)
                .ok_or_else(|| anyhow!("variable inconnue : {}", binding.variable))?;
            let width = value_to_registers(value).len();
            if binding.offset + width > frame.values.len() {
                bail!(
                    "la variable {} nécessite {} registre(s) à partir de l'offset {} dans {}",
                    binding.variable,
                    width,
                    binding.offset,
                    frame.name
                );
            }
            for offset in binding.offset..binding.offset + width {
                if !occupied.insert((frame.name.as_str(), offset)) {
                    bail!(
                        "plusieurs variables utilisent le même registre dans {}",
                        frame.name
                    );
                }
            }
        }
    }
    Ok(())
}

fn sync_frame_bindings_to_memory(
    frames: &[ModbusFrame],
    memory: &Arc<RwLock<Memory>>,
) -> Result<()> {
    let mut memory = memory
        .write()
        .map_err(|_| anyhow!("verrou de mémoire indisponible"))?;
    for frame in frames {
        for binding in &frame.bindings {
            let Some(original) = memory.get(&binding.variable) else {
                continue;
            };
            let width = value_to_registers(original).len();
            let words = frame
                .values
                .get(binding.offset..binding.offset + width)
                .ok_or_else(|| anyhow!("registre incomplet pour {}", binding.variable))?;
            memory.set(&binding.variable, registers_to_value(original, words));
        }
    }
    Ok(())
}

fn initialize_new_bindings(
    current: &[ModbusFrame],
    updated: &mut [ModbusFrame],
    memory: &Arc<RwLock<Memory>>,
) -> Result<()> {
    let memory = memory
        .read()
        .map_err(|_| anyhow!("verrou de mémoire indisponible"))?;
    for frame in updated {
        let previous = current.iter().find(|item| item.name == frame.name);
        for binding in &frame.bindings {
            let already_bound =
                previous.is_some_and(|previous| previous.bindings.iter().any(|old| old == binding));
            if already_bound {
                continue;
            }
            if let Some(value) = memory.get(&binding.variable) {
                for (index, word) in value_to_registers(value).into_iter().enumerate() {
                    if let Some(register) = frame.values.get_mut(binding.offset + index) {
                        *register = word;
                    }
                }
            }
        }
    }
    Ok(())
}

fn restore_saved_updates(
    current: &[ModbusFrame],
    saved: Vec<FrameUpdate>,
    memory: &Arc<RwLock<Memory>>,
) -> Result<Vec<ModbusFrame>> {
    let mut updates = Vec::with_capacity(current.len());
    for frame in current {
        let matches: Vec<_> = saved
            .iter()
            .filter(|item| item.name == frame.name)
            .collect();
        if matches.len() > 1 {
            bail!("configuration dupliquée pour la frame {}", frame.name);
        }
        let mut update = matches.first().map_or_else(
            || FrameUpdate {
                name: frame.name.clone(),
                address: frame.address,
                values: frame.values.clone(),
                bindings: Vec::new(),
            },
            |item| (*item).clone(),
        );
        if update.values.len() < frame.values.len() {
            update.values.resize(frame.values.len(), 0);
        }
        updates.push(update);
    }
    apply_updates(current, updates, memory)
}

fn value_to_registers(value: Value) -> Vec<u16> {
    match value {
        Value::Bool(value) => vec![u16::from(value)],
        Value::Int16(value) => vec![value as u16],
        Value::UInt16(value) | Value::Word(value) => vec![value],
        Value::UInt32(value) | Value::DWord(value) => {
            vec![(value >> 16) as u16, value as u16]
        }
    }
}

fn registers_to_value(original: Value, words: &[u16]) -> Value {
    match original {
        Value::Bool(_) => Value::Bool(words[0] != 0),
        Value::Int16(_) => Value::Int16(words[0] as i16),
        Value::UInt16(_) => Value::UInt16(words[0]),
        Value::Word(_) => Value::Word(words[0]),
        Value::UInt32(_) => Value::UInt32(((words[0] as u32) << 16) | words[1] as u32),
        Value::DWord(_) => Value::DWord(((words[0] as u32) << 16) | words[1] as u32),
    }
}

fn validate_ranges(frames: &[ModbusFrame]) -> Result<()> {
    let mut ranges: Vec<_> = frames
        .iter()
        .map(|frame| {
            if frame.values.is_empty() {
                bail!("la frame {} ne peut pas être vide", frame.name);
            }
            let end = frame.address as usize + frame.values.len();
            if end > u16::MAX as usize + 1 {
                bail!(
                    "la plage de la frame {} dépasse l'adresse Modbus maximale",
                    frame.name
                );
            }
            Ok((frame.address as usize, end, frame.name.as_str()))
        })
        .collect::<Result<_>>()?;
    ranges.sort_by_key(|range| range.0);
    for pair in ranges.windows(2) {
        if pair[1].0 < pair[0].1 {
            bail!(
                "les frames {} et {} utilisent des registres qui se chevauchent",
                pair[0].2,
                pair[1].2
            );
        }
    }
    Ok(())
}

#[derive(Clone)]
struct ModbusService {
    frames: Arc<RwLock<Vec<ModbusFrame>>>,
    memory: Arc<RwLock<Memory>>,
}

impl ModbusService {
    fn register_location(frames: &[ModbusFrame], address: u16) -> Option<(usize, usize)> {
        frames.iter().enumerate().find_map(|(frame_index, frame)| {
            let index = address.checked_sub(frame.address)? as usize;
            (index < frame.values.len()).then_some((frame_index, index))
        })
    }

    fn read_registers(
        &self,
        address: u16,
        count: u16,
    ) -> std::result::Result<Vec<u16>, ExceptionCode> {
        let frames = self
            .frames
            .read()
            .map_err(|_| ExceptionCode::ServerDeviceFailure)?;
        (0..count)
            .map(|offset| {
                let address = address
                    .checked_add(offset)
                    .ok_or(ExceptionCode::IllegalDataAddress)?;
                let (frame_index, value_index) = Self::register_location(&frames, address)
                    .ok_or(ExceptionCode::IllegalDataAddress)?;
                Ok(frames[frame_index].values[value_index])
            })
            .collect()
    }

    fn write_registers(
        &self,
        address: u16,
        values: &[u16],
    ) -> std::result::Result<(), ExceptionCode> {
        let mut frames = self
            .frames
            .write()
            .map_err(|_| ExceptionCode::ServerDeviceFailure)?;
        let mut locations = Vec::with_capacity(values.len());
        for offset in 0..values.len() {
            let register = address
                .checked_add(offset as u16)
                .ok_or(ExceptionCode::IllegalDataAddress)?;
            let location = Self::register_location(&frames, register)
                .ok_or(ExceptionCode::IllegalDataAddress)?;
            if frames[location.0].read_only {
                return Err(ExceptionCode::IllegalDataAddress);
            }
            locations.push(location);
        }
        for (location, value) in locations.into_iter().zip(values) {
            frames[location.0].values[location.1] = *value;
        }
        drop(frames);
        self.sync_bindings_to_memory()
    }

    fn sync_bindings_to_memory(&self) -> std::result::Result<(), ExceptionCode> {
        let frames = self
            .frames
            .read()
            .map_err(|_| ExceptionCode::ServerDeviceFailure)?
            .clone();
        let memory = self
            .memory
            .read()
            .map_err(|_| ExceptionCode::ServerDeviceFailure)?;
        let mapped: Vec<_> = frames
            .iter()
            .flat_map(|frame| {
                frame.bindings.iter().filter_map(|binding| {
                    let value = memory.get(&binding.variable)?;
                    let width = value_to_registers(value).len();
                    let words = frame
                        .values
                        .get(binding.offset..binding.offset + width)?
                        .to_vec();
                    Some((binding.variable.clone(), value, words))
                })
            })
            .collect();
        drop(memory);
        let mut memory = self
            .memory
            .write()
            .map_err(|_| ExceptionCode::ServerDeviceFailure)?;
        for (name, original, words) in mapped {
            memory.set(&name, registers_to_value(original, &words));
        }
        Ok(())
    }
}

impl tokio_modbus::server::Service for ModbusService {
    type Request = Request<'static>;
    type Response = Response;
    type Exception = ExceptionCode;
    type Future = future::Ready<std::result::Result<Self::Response, Self::Exception>>;

    fn call(&self, request: Self::Request) -> Self::Future {
        let response = match request {
            Request::ReadHoldingRegisters(address, count) => self
                .read_registers(address, count)
                .map(Response::ReadHoldingRegisters),
            Request::WriteSingleRegister(address, value) => self
                .write_registers(address, &[value])
                .map(|()| Response::WriteSingleRegister(address, value)),
            Request::WriteMultipleRegisters(address, values) => {
                let count = values.len() as u16;
                self.write_registers(address, values.as_ref())
                    .map(|()| Response::WriteMultipleRegisters(address, count))
            }
            _ => Err(ExceptionCode::IllegalFunction),
        };
        future::ready(response)
    }
}

pub async fn serve(listener: TcpListener, state: ModbusState) -> Result<()> {
    let server = Server::new(listener);
    let on_connected = move |stream, socket_addr: SocketAddr| {
        let frames = state.frames.clone();
        let memory = state.memory.clone();
        async move {
            let new_service = move |_socket_addr| {
                Ok(Some(ModbusService {
                    frames: frames.clone(),
                    memory: memory.clone(),
                }))
            };
            accept_tcp_connection(stream, socket_addr, new_service)
        }
    };
    server
        .serve(&on_connected, |error| {
            eprintln!("Erreur serveur Modbus : {error}")
        })
        .await?;
    Ok(())
}

#[cfg(test)]
mod tests {
    use super::*;

    fn test_memory() -> Arc<RwLock<Memory>> {
        let mut memory = Memory::new();
        memory.set("temperature", Value::Int16(25));
        memory.set("alarm", Value::Bool(false));
        memory.set("counter", Value::UInt32(0));
        Arc::new(RwLock::new(memory))
    }

    #[test]
    fn loads_registers_and_port_from_comm_dat() {
        let contents = include_str!("../../COMM.DAT");
        let frames = parse_frames(contents).unwrap();
        assert_eq!(parse_modbus_port(contents).unwrap(), 502);
        assert_eq!(frames[0].address, 2500);
        assert_eq!(frames[0].values.len(), 43);
        assert_eq!(frames[1].values.len(), 120);
        assert!(frames[4].read_only);
    }

    #[test]
    fn rejects_overlapping_frame_updates() {
        let frames = parse_frames(include_str!("../../COMM.DAT")).unwrap();
        let mut updates: Vec<_> = frames
            .iter()
            .map(|frame| FrameUpdate {
                name: frame.name.clone(),
                address: frame.address,
                values: frame.values.clone(),
                bindings: Vec::new(),
            })
            .collect();
        updates[1].address = updates[0].address + 1;
        assert!(apply_updates(&frames, updates, &test_memory()).is_err());
    }

    #[test]
    fn rejects_removing_registers_below_comm_dat_minimum() {
        let frames = parse_frames(include_str!("../../COMM.DAT")).unwrap();
        let mut updates: Vec<_> = frames
            .iter()
            .map(|frame| FrameUpdate {
                name: frame.name.clone(),
                address: frame.address,
                values: frame.values.clone(),
                bindings: Vec::new(),
            })
            .collect();
        updates[0].values.pop();
        assert!(apply_updates(&frames, updates, &test_memory()).is_err());
    }

    #[test]
    fn restores_saved_config_when_comm_dat_has_new_frames_or_registers() {
        let base = vec![
            ModbusFrame {
                name: "existing".to_string(),
                address: 100,
                values: vec![0; 3],
                minimum_registers: 3,
                read_only: false,
                bindings: Vec::new(),
            },
            ModbusFrame {
                name: "new".to_string(),
                address: 200,
                values: vec![0; 2],
                minimum_registers: 2,
                read_only: false,
                bindings: Vec::new(),
            },
        ];
        let saved = vec![
            FrameUpdate {
                name: "existing".to_string(),
                address: 110,
                values: vec![9],
                bindings: Vec::new(),
            },
            FrameUpdate {
                name: "removed".to_string(),
                address: 300,
                values: vec![7],
                bindings: Vec::new(),
            },
        ];
        let restored = restore_saved_updates(&base, saved, &test_memory()).unwrap();
        assert_eq!(restored[0].address, 110);
        assert_eq!(restored[0].values, vec![9, 0, 0]);
        assert_eq!(restored[1].address, 200);
        assert_eq!(restored[1].values, vec![0, 0]);
    }

    #[test]
    fn persists_web_configuration_and_reloads_it() {
        let config_path = std::env::temp_dir().join(format!(
            "automate-sim-modbus-config-{}.json",
            std::process::id()
        ));
        let _ = fs::remove_file(&config_path);
        let memory = test_memory();
        let (state, _) =
            ModbusState::load(Path::new("COMM.DAT"), &config_path, memory.clone()).unwrap();
        let mut updates: Vec<_> = state
            .snapshot()
            .unwrap()
            .into_iter()
            .map(|frame| FrameUpdate {
                name: frame.name,
                address: frame.address,
                values: frame.values,
                bindings: frame.bindings,
            })
            .collect();
        updates[0].address = 2490;
        updates[0].values[0] = 4321;
        updates[0].values.push(7);
        updates[0].bindings.push(VariableBinding {
            variable: "counter".to_string(),
            offset: 1,
        });
        state.update(updates).unwrap();

        let (reloaded, _) = ModbusState::load(Path::new("COMM.DAT"), &config_path, memory).unwrap();
        let first = &reloaded.snapshot().unwrap()[0];
        assert_eq!(first.address, 2490);
        assert_eq!(first.values[0], 4321);
        assert_eq!(first.values.len(), 44);
        assert_eq!(first.values[43], 7);
        assert_eq!(
            first.bindings,
            vec![VariableBinding {
                variable: "counter".to_string(),
                offset: 1,
            }]
        );
        fs::remove_file(config_path).unwrap();
    }

    #[test]
    fn serves_and_writes_holding_registers() {
        let frames = parse_frames(include_str!("../../COMM.DAT")).unwrap();
        let service = ModbusService {
            frames: Arc::new(RwLock::new(frames)),
            memory: test_memory(),
        };
        assert_eq!(service.read_registers(2500, 1).unwrap(), vec![0]);
        service.write_registers(2500, &[1234]).unwrap();
        assert_eq!(service.read_registers(2500, 1).unwrap(), vec![1234]);
        assert!(service.read_registers(2543, 1).is_err());
    }

    #[test]
    fn mapped_dword_registers_are_bidirectional_and_use_type_maximum() {
        let memory = test_memory();
        memory
            .write()
            .unwrap()
            .set("counter", Value::UInt32(u32::MAX));
        let original_frame = ModbusFrame {
            name: "test".to_string(),
            address: 100,
            values: vec![0, 0],
            minimum_registers: 2,
            read_only: false,
            bindings: Vec::new(),
        };
        let frame_update = FrameUpdate {
            name: original_frame.name.clone(),
            address: original_frame.address,
            values: vec![0, 0],
            bindings: vec![VariableBinding {
                variable: "counter".to_string(),
                offset: 0,
            }],
        };
        let mut frame = apply_updates(&[original_frame.clone()], vec![frame_update], &memory)
            .unwrap()
            .remove(0);
        initialize_new_bindings(&[original_frame], std::slice::from_mut(&mut frame), &memory)
            .unwrap();
        assert_eq!(frame.values, vec![u16::MAX, u16::MAX]);
        let service = ModbusService {
            frames: Arc::new(RwLock::new(vec![frame])),
            memory: memory.clone(),
        };

        service.write_registers(100, &[0x1234, 0x5678]).unwrap();
        assert_eq!(
            memory.read().unwrap().get("counter"),
            Some(Value::UInt32(0x1234_5678))
        );
        memory
            .write()
            .unwrap()
            .set("counter", Value::UInt32(u32::MAX));
        let state = ModbusState {
            frames: service.frames.clone(),
            config_path: Arc::new(PathBuf::from("unused-test-config.json")),
            memory,
        };
        state.sync_from_memory().unwrap();
        assert_eq!(
            service.read_registers(100, 2).unwrap(),
            vec![u16::MAX, u16::MAX]
        );
    }

    #[tokio::test]
    async fn serves_modbus_tcp_reads_and_writes() {
        let state = ModbusState {
            frames: Arc::new(RwLock::new(
                parse_frames(include_str!("../../COMM.DAT")).unwrap(),
            )),
            config_path: Arc::new(PathBuf::from("unused-test-config.json")),
            memory: test_memory(),
        };
        let listener = TcpListener::bind("127.0.0.1:0").await.unwrap();
        let address = listener.local_addr().unwrap();
        let server = tokio::spawn(serve(listener, state));
        let mut client = tokio_modbus::client::tcp::connect(address).await.unwrap();
        client.set_slave(tokio_modbus::slave::Slave(1));

        let initial = client
            .read_holding_registers(2500, 2)
            .await
            .unwrap()
            .unwrap();
        assert_eq!(initial, vec![0, 0]);
        client
            .write_single_register(2500, 4321)
            .await
            .unwrap()
            .unwrap();
        let updated = client
            .read_holding_registers(2500, 1)
            .await
            .unwrap()
            .unwrap();
        assert_eq!(updated, vec![4321]);

        server.abort();
    }
}
