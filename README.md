# Automate Simulator

Un petit simulateur d'automate (PLC) en Rust : une mémoire de variables typées,
une logique métier exécutée en boucle, une interface web de supervision et de
configuration, et un serveur Modbus TCP alimenté par les frames de `COMM.DAT`.

## Démarrage rapide

```bash
cargo run
```

Puis ouvre **http://127.0.0.1:3000** dans un navigateur. La page permet de
modifier les adresses de départ et les valeurs des registres définis dans
`COMM.DAT`, et d'ajouter ou retirer des registres avec les boutons de chaque
frame. La taille d'une frame ne peut pas être réduite sous le minimum déclaré
dans `COMM.DAT`. Les modifications sont appliquées immédiatement et
sauvegardées dans `modbus_config.json`. Tu peux aussi associer une variable
de simulation à un registre (les types 32 bits occupent deux registres) :
les écritures Modbus mettent à jour la variable et la simulation republie
sa valeur vers les registres. Le bouton de maximum utilise le maximum du
type de la variable liée (par exemple BOOL = 1, INT16 = 32767, UINT16 = 65535).

Le serveur Modbus TCP écoute sur le port défini dans `COMM.DAT` (502 dans le
fichier fourni), sur toutes les interfaces réseau. Un client Modbus peut lire
les Holding Registers correspondant aux plages des frames. Les valeurs
initiales sont à zéro. Les frames marquées `RW` acceptent aussi les écritures
Modbus; les frames `R` restent en lecture seule côté Modbus. Le port TCP 502
peut nécessiter des droits élevés ou être déjà utilisé.

## Comment le projet est organisé

```
Cargo.toml
src/
  main.rs                <- POINT D'ENTRÉE : variables, logique, boucle
  web.rs                 <- serveur HTTP, API de configuration + WebSocket
  web/index.html          <- page affichée dans le navigateur
  core/
    memory.rs             <- la mémoire (table nom -> valeur)
    value.rs               <- les valeurs typées (Bool, Int16, ...)
    datatype.rs             <- le catalogue des types possibles
  communication/
    modbus.rs             <- client Modbus TCP (adressage décimal)
    modbus_server.rs      <- serveur Modbus TCP alimenté par COMM.DAT
```

Chaque fichier `.rs` commence par un bloc de commentaire qui explique son
rôle et s'il faut y toucher ou non. Cherche les commentaires `➜ AJOUTE ICI`
: ce sont les seuls endroits où on intervient pour étendre le simulateur.

## Comment ça marche

Le programme fait tourner deux choses en parallèle (dans `main.rs`) :

1. **La boucle de simulation** (le "moteur automate") : toutes les 200 ms,
   elle répète 3 étapes — lire les entrées, exécuter la logique, écrire les
   sorties — puis diffuse l'état complet de la mémoire.
2. **Le serveur web** : sert la page HTML et retransmet cet état à tous les
   navigateurs connectés, via WebSocket, en temps réel.

```
   lecture entrées  →  logique métier  →  écriture sorties  →  diffusion web
        ↑                                                            │
        └────────────────────── prochain cycle (200 ms) ─────────────┘
```

## 1. Ajouter une variable

Tout se passe dans `src/main.rs`, fonction `main()`, section marquée
`VARIABLES`. Une ligne suffit :

```rust
mem.set("pressure", Value::UInt16(1013));
```

Types disponibles (définis dans `src/core/value.rs`) :

| Type Rust        | Plage / usage                          |
|-------------------|-----------------------------------------|
| `Value::Bool`      | vrai/faux (alarme, marche/arrêt...)     |
| `Value::Int16`     | entier signé, -32768 à 32767            |
| `Value::UInt16`    | entier non signé, 0 à 65535             |
| `Value::Word`      | comme UInt16, sémantique "mot" PLC       |
| `Value::UInt32`    | entier non signé, 0 à ~4 milliards       |
| `Value::DWord`     | comme UInt32, sémantique "double mot"    |

Dès que la variable est créée avec `mem.set(...)`, elle est **automatiquement** :
- utilisable dans la logique (`mem.get("pressure")`)
- affichée dans l'interface web (aucune modification du HTML nécessaire)
- conservée dans la mémoire de la simulation

Les registres Modbus exposés sont configurés indépendamment, à partir des
frames de `COMM.DAT` (voir section 3).

Si aucun des types ci-dessus ne convient (ex: besoin d'un nombre décimal),
il faut d'abord l'ajouter dans `src/core/datatype.rs` et `src/core/value.rs`
— ces deux fichiers expliquent comment faire dans leurs commentaires.

## 2. Ajouter un bloc de logique

Toujours dans `src/main.rs`, fonction `run_logic()`. C'est la fonction
appelée une fois par cycle, où vit "le programme" de l'automate.

Modèle à suivre :

```rust
fn run_logic(mem: &mut Memory) {
    let temperature = mem.get("temperature").unwrap().as_f64();
    mem.set("alarm", Value::Bool(temperature > 50.0));

    // ta propre règle :
    let alarm = mem.get("alarm").unwrap().as_bool();
    mem.set("motor", Value::Bool(!alarm));
}
```

Principe : `mem.get("nom")` pour lire, `.as_f64()` ou `.as_bool()` pour
interpréter la valeur, puis `mem.set("nom", Value::...)` pour écrire le
résultat. On peut lire/écrire n'importe quelle variable créée à l'étape 1.

**Limite actuelle** : cette logique est écrite directement en Rust — donc
il faut recompiler (`cargo run`) à chaque changement de règle. Une prochaine
étape possible serait un vrai petit langage de script interprété, pour
changer la logique sans recompiler (voir la section "Pistes pour la suite").

## 3. Fournir des registres via Modbus TCP

Le serveur lit les frames `FRAME` de `COMM.DAT` et expose les registres
Holding à leurs adresses de départ. La taille en octets de chaque frame est
convertie en nombre de registres 16 bits. Les adresses sont celles déclarées
dans le champ d'adresse de la frame (index de registre Modbus 0-based).
La page Web permet de changer l'adresse et les valeurs; les réglages sont
conservés dans `modbus_config.json`, sans modifier le fichier original
`COMM.DAT`.

Les clients Modbus utilisent généralement une adresse de protocole 0-based
(par exemple le registre déclaré à `2500` est lu à l'offset 2500). Les interfaces
qui affichent des références `4xxxx` doivent être configurées selon leur
convention de numérotation.

Les valeurs web sont des entiers non signés 16 bits (0 à 65535). Les frames
marquées `R` dans `COMM.DAT` restent modifiables depuis la page, mais refusent
les écritures envoyées par un client Modbus.

## Pistes pour la suite

Dans l'ordre le plus logique pour continuer à développer ce projet :

1. **Vrai petit langage de script** — remplacer `run_logic()` codée en dur
   par un interpréteur qui lit une logique écrite par l'utilisateur
   (`if temperature > 50 { alarm = true }`), modifiable sans recompiler.
2. **Tableaux de variables** — `temperature[0]`, `temperature[1]`... pour
   pouvoir écrire des boucles `for` dans la logique.

## Dépannage

- **`error[E0583]: file not found for module`** : un dossier de module est
  manquant ou mal placé. Vérifie l'arborescence `src/` donnée plus haut —
  chaque `mod xxx;` dans un fichier `.rs` doit correspondre soit à
  `xxx.rs`, soit à `xxx/mod.rs`, au même niveau.
- **Warnings `never used` / `never constructed`** : normal tant que
  certains types ou méthodes ne sont pas encore branchés partout (ex: avant
  d'avoir mappé une variable Modbus qui utilise `Word` ou `DWord`). Ce sont
  des avertissements, pas des erreurs — le programme compile et tourne quand
  même.
- **Un client ne peut pas se connecter en Modbus TCP** : vérifie que le
  simulateur est démarré, que le port défini dans `COMM.DAT` est disponible,
  et qu'aucun pare-feu ne bloque ce port.
