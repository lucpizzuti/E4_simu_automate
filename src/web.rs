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

use axum::{
    extract::{
        ws::{Message, WebSocket, WebSocketUpgrade},
        State,
    },
    response::{Html, IntoResponse},
    routing::get,
    Router,
};
use std::sync::Arc;
use tokio::sync::broadcast;

/// État partagé entre la boucle de simulation (main.rs) et les clients
/// WebSocket. `tx` est le "haut-parleur" : main.rs y dépose une string
/// JSON à chaque cycle, et chaque client connecté (via handle_socket
/// ci-dessous) la reçoit et la retransmet dans son navigateur.
#[derive(Clone)]
pub struct AppState {
    pub tx: broadcast::Sender<String>,
}

/// Construit les routes de l'application. Appelé une seule fois dans main().
pub fn build_router(state: Arc<AppState>) -> Router {
    Router::new()
        .route("/", get(index))
        .route("/ws", get(ws_handler))
        .with_state(state)
    // ➜ Si tu ajoutes plus tard une route pour MODIFIER une variable
    //   depuis le navigateur (ex: POST /variables/{name}), c'est ici
    //   qu'il faudra l'ajouter avec .route("/variables/:name", post(...)).
}

/// Sert la page HTML telle quelle. `include_str!` l'intègre directement
/// dans le binaire compilé — pas besoin de fichier séparé à déployer.
async fn index() -> Html<&'static str> {
    Html(include_str!("web/index.html"))
}

/// Point d'entrée WebSocket : upgrade la connexion HTTP en WebSocket puis
/// délègue à handle_socket.
async fn ws_handler(
    ws: WebSocketUpgrade,
    State(state): State<Arc<AppState>>,
) -> impl IntoResponse {
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
