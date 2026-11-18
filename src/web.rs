//! ============================================================================
//! SERVEUR WEB — sert la page HTML et diffuse l'état en direct (WebSocket)
//! ============================================================================
//! Deux routes :
//!   GET /     -> sert la page web/index.html (le tableau qui s'affiche)
//!   GET /ws   -> connexion WebSocket : chaque client reçoit en continu
//!                l'état JSON envoyé par main.rs via `state.tx.send(...)`
//!
//! ➜ Tu n'as normalement pas besoin de modifier ce fichier. Pour changer
//! CE QUI est affiché, modifie web/index.html. Pour changer QUAND/QUOI est
//! envoyé, modifie state_json() et la boucle dans main.rs.

use crate::{
    communication::modbus_server::{FrameUpdate, ModbusState, UpdateError},
    core::value::Value,
};
use axum::{
    extract::{
        ws::{Message, WebSocket, WebSocketUpgrade},
        State,
    },
    http::StatusCode,
    response::{Html, IntoResponse},
    routing::{get, post, put},
    Json, Router,
};
use std::{
    collections::BTreeMap,
    sync::{
        atomic::{AtomicBool, Ordering},
        Arc, RwLock,
    },
};
use tokio::sync::broadcast;

#[derive(Clone, Default)]
pub struct SimulationControl {
    paused: Arc<AtomicBool>,
    forced_variables: Arc<RwLock<BTreeMap<String, Value>>>,
}

impl SimulationControl {
    pub fn is_paused(&self) -> bool {
        self.paused.load(Ordering::Relaxed)
    }

    pub fn set_paused(&self, paused: bool) {
        self.paused.store(paused, Ordering::Relaxed);
    }

    pub fn force_variable(&self, name: String, value: Value) -> anyhow::Result<()> {
        self.forced_variables
            .write()
            .map_err(|_| anyhow::anyhow!("verrou des variables forcées indisponible"))?
            .insert(name, value);
        Ok(())
    }

    pub fn release_variable(&self, name: &str) -> anyhow::Result<()> {
        self.forced_variables
            .write()
            .map_err(|_| anyhow::anyhow!("verrou des variables forcées indisponible"))?
            .remove(name);
        Ok(())
    }

    pub fn forced_values(&self) -> anyhow::Result<BTreeMap<String, Value>> {
        self.forced_variables
            .read()
            .map(|variables| variables.clone())
            .map_err(|_| anyhow::anyhow!("verrou des variables forcées indisponible"))
    }
}

/// État partagé entre la boucle de simulation (main.rs) et les clients
/// WebSocket. `tx` est le "haut-parleur" : main.rs y dépose une string
/// JSON à chaque cycle, et chaque client connecté (via handle_socket
/// ci-dessous) la reçoit et la retransmet dans son navigateur.
#[derive(Clone)]
pub struct AppState {
    pub tx: broadcast::Sender<String>,
    pub modbus: ModbusState,
    pub simulation: SimulationControl,
}

/// Construit les routes de l'application. Appelé une seule fois dans main().
pub fn build_router(state: Arc<AppState>) -> Router {
    Router::new()
        .route("/", get(index))
        .route("/ws", get(ws_handler))
        .route("/api/modbus", get(get_modbus).put(update_modbus))
        .route(
            "/api/modbus/presets",
            get(get_presets).post(save_preset).delete(delete_preset),
        )
        .route("/api/modbus/presets/preview", post(preview_preset))
        .route("/api/modbus/presets/apply", post(apply_preset))
        .route("/api/modbus/presets/import", post(import_preset))
        .route(
            "/api/simulation",
            get(get_simulation).put(update_simulation),
        )
        .route(
            "/api/variables/force",
            put(force_variable).delete(release_variable),
        )
        .with_state(state)
}

async fn get_modbus(State(state): State<Arc<AppState>>) -> impl IntoResponse {
    match state.modbus.snapshot() {
        Ok(frames) => match state.modbus.variable_snapshot() {
            Ok(variables) => (
                StatusCode::OK,
                Json(serde_json::json!({
                    "frames": frames,
                    "variables": variables.into_iter().map(|(name, variable_type, value)| {
                        serde_json::json!({ "name": name, "type": variable_type, "value": value })
                    }).collect::<Vec<_>>(),
                })),
            )
                .into_response(),
            Err(error) => (StatusCode::INTERNAL_SERVER_ERROR, error.to_string()).into_response(),
        },
        Err(error) => (StatusCode::INTERNAL_SERVER_ERROR, error.to_string()).into_response(),
    }
}

async fn update_modbus(
    State(state): State<Arc<AppState>>,
    Json(payload): Json<ModbusConfigUpdate>,
) -> impl IntoResponse {
    match state.modbus.update(payload.frames) {
        Ok(()) => StatusCode::NO_CONTENT.into_response(),
        Err(UpdateError::Invalid(error)) => (StatusCode::BAD_REQUEST, error).into_response(),
        Err(UpdateError::Persistence(error)) => {
            (StatusCode::INTERNAL_SERVER_ERROR, error.to_string()).into_response()
        }
        Err(UpdateError::LockPoisoned) => (
            StatusCode::INTERNAL_SERVER_ERROR,
            "verrou de configuration Modbus indisponible",
        )
            .into_response(),
    }
}

async fn get_presets(State(state): State<Arc<AppState>>) -> impl IntoResponse {
    match state.modbus.preset_names() {
        Ok(presets) => (
            StatusCode::OK,
            Json(serde_json::json!({ "presets": presets })),
        )
            .into_response(),
        Err(error) => (StatusCode::INTERNAL_SERVER_ERROR, error.to_string()).into_response(),
    }
}

async fn save_preset(
    State(state): State<Arc<AppState>>,
    Json(payload): Json<PresetName>,
) -> impl IntoResponse {
    let name = payload.name.trim();
    if name.is_empty() || name.chars().count() > 60 {
        return (
            StatusCode::BAD_REQUEST,
            "le nom de l’état doit contenir entre 1 et 60 caractères",
        )
            .into_response();
    }
    match state.modbus.save_preset(name) {
        Ok(()) => StatusCode::CREATED.into_response(),
        Err(error) => update_error_response(error),
    }
}

async fn preview_preset(
    State(state): State<Arc<AppState>>,
    Json(payload): Json<PresetName>,
) -> impl IntoResponse {
    match state.modbus.preset_frames(&payload.name) {
        Ok(Some(frames)) => (
            StatusCode::OK,
            Json(serde_json::json!({ "name": payload.name, "frames": frames })),
        )
            .into_response(),
        Ok(None) => StatusCode::NOT_FOUND.into_response(),
        Err(error) => (StatusCode::INTERNAL_SERVER_ERROR, error.to_string()).into_response(),
    }
}

async fn apply_preset(
    State(state): State<Arc<AppState>>,
    Json(payload): Json<PresetName>,
) -> impl IntoResponse {
    match state.modbus.apply_preset(&payload.name) {
        Ok(()) => StatusCode::NO_CONTENT.into_response(),
        Err(error) => update_error_response(error),
    }
}

async fn import_preset(
    State(state): State<Arc<AppState>>,
    Json(payload): Json<PresetImport>,
) -> impl IntoResponse {
    if payload.format != "automate-frame-state" || payload.version != 1 {
        return (
            StatusCode::BAD_REQUEST,
            "format d’état inconnu ou version non prise en charge",
        )
            .into_response();
    }
    match state.modbus.import_preset(&payload.name, payload.frames) {
        Ok(()) => StatusCode::CREATED.into_response(),
        Err(error) => update_error_response(error),
    }
}

async fn delete_preset(
    State(state): State<Arc<AppState>>,
    Json(payload): Json<PresetName>,
) -> impl IntoResponse {
    match state.modbus.delete_preset(&payload.name) {
        Ok(true) => StatusCode::NO_CONTENT.into_response(),
        Ok(false) => StatusCode::NOT_FOUND.into_response(),
        Err(error) => (StatusCode::INTERNAL_SERVER_ERROR, error.to_string()).into_response(),
    }
}

async fn get_simulation(State(state): State<Arc<AppState>>) -> impl IntoResponse {
    match state.simulation.forced_values() {
        Ok(forced) => (
            StatusCode::OK,
            Json(serde_json::json!({
                "paused": state.simulation.is_paused(),
                "forced_variables": forced.keys().collect::<Vec<_>>(),
            })),
        )
            .into_response(),
        Err(error) => (StatusCode::INTERNAL_SERVER_ERROR, error.to_string()).into_response(),
    }
}

async fn update_simulation(
    State(state): State<Arc<AppState>>,
    Json(payload): Json<SimulationUpdate>,
) -> impl IntoResponse {
    state.simulation.set_paused(payload.paused);
    StatusCode::NO_CONTENT
}

async fn force_variable(
    State(state): State<Arc<AppState>>,
    Json(payload): Json<ForceVariable>,
) -> impl IntoResponse {
    let value = match state
        .modbus
        .set_variable_value(&payload.name, payload.value)
    {
        Ok(value) => value,
        Err(error) => return (StatusCode::BAD_REQUEST, error.to_string()).into_response(),
    };
    match state.simulation.force_variable(payload.name, value) {
        Ok(()) => StatusCode::NO_CONTENT.into_response(),
        Err(error) => (StatusCode::INTERNAL_SERVER_ERROR, error.to_string()).into_response(),
    }
}

async fn release_variable(
    State(state): State<Arc<AppState>>,
    Json(payload): Json<VariableName>,
) -> impl IntoResponse {
    match state.simulation.release_variable(&payload.name) {
        Ok(()) => StatusCode::NO_CONTENT.into_response(),
        Err(error) => (StatusCode::INTERNAL_SERVER_ERROR, error.to_string()).into_response(),
    }
}

#[derive(serde::Deserialize)]
struct ModbusConfigUpdate {
    frames: Vec<FrameUpdate>,
}

#[derive(serde::Deserialize)]
struct PresetName {
    name: String,
}

#[derive(serde::Deserialize)]
struct PresetImport {
    format: String,
    version: u32,
    name: String,
    frames: Vec<FrameUpdate>,
}

#[derive(serde::Deserialize)]
struct SimulationUpdate {
    paused: bool,
}

#[derive(serde::Deserialize)]
struct ForceVariable {
    name: String,
    value: serde_json::Value,
}

#[derive(serde::Deserialize)]
struct VariableName {
    name: String,
}

fn update_error_response(error: UpdateError) -> axum::response::Response {
    match error {
        UpdateError::Invalid(error) => (StatusCode::BAD_REQUEST, error).into_response(),
        UpdateError::Persistence(error) => {
            (StatusCode::INTERNAL_SERVER_ERROR, error.to_string()).into_response()
        }
        UpdateError::LockPoisoned => (
            StatusCode::INTERNAL_SERVER_ERROR,
            "verrou de configuration Modbus indisponible",
        )
            .into_response(),
    }
}

/// Sert la page HTML telle quelle. `include_str!` l'intègre directement
/// dans le binaire compilé — pas besoin de fichier séparé à déployer.
async fn index() -> Html<&'static str> {
    Html(include_str!("web/index.html"))
}

/// Point d'entrée WebSocket : upgrade la connexion HTTP en WebSocket puis
/// délègue à handle_socket.
async fn ws_handler(ws: WebSocketUpgrade, State(state): State<Arc<AppState>>) -> impl IntoResponse {
    ws.on_upgrade(|socket| handle_socket(socket, state))
}

/// Boucle de vie d'UN client connecté : s'abonne au "haut-parleur" (tx) et
/// relaie chaque message reçu vers le navigateur, jusqu'à déconnexion.
async fn handle_socket(mut socket: WebSocket, state: Arc<AppState>) {
    let mut rx = state.tx.subscribe();
    while let Ok(msg) = rx.recv().await {
        if socket.send(Message::Text(msg)).await.is_err() {
            // client déconnecté (onglet fermé, perte réseau...)
            break;
        }
    }
}

#[cfg(test)]
mod tests {
    use super::*;

    #[test]
    fn simulation_control_tracks_pause_and_forced_variables() {
        let control = SimulationControl::default();
        assert!(!control.is_paused());
        control.set_paused(true);
        assert!(control.is_paused());

        control
            .force_variable("counter".to_string(), Value::UInt32(123))
            .unwrap();
        assert_eq!(
            control.forced_values().unwrap().get("counter"),
            Some(&Value::UInt32(123))
        );
        control.release_variable("counter").unwrap();
        assert!(control.forced_values().unwrap().is_empty());
    }
}
