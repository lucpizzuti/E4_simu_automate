# Automate Simulator

Un petit simulateur d'automate (PLC) en Rust : une mémoire de variables typées,
une logique métier exécutée en boucle, une interface web qui affiche l'état en
direct, et un client Modbus TCP pour parler à un vrai équipement.

## Démarrage rapide

```bash
cargo run
```

Puis ouvre **http://127.0.0.1:3000** dans un navigateur. Tu verras la
température monter/descendre en triangle (20°→60°→20°) et l'alarme passer
en rouge au-dessus de 50°, mis à jour 5 fois par seconde.

Pour tester la partie Modbus (dans un second terminal, le premier doit
rester ouvert) :

```bash
cargo run --example mock_device
```

Ça lance un faux équipement Modbus TCP sur `127.0.0.1:5502`, pour pouvoir
tester le client sans matériel réel.

## Comment le projet est organisé

```
Cargo.toml
examples/
  mock_device.rs        <- faux équipement Modbus TCP, pour les tests
src/
  main.rs                <- POINT D'ENTRÉE : variables, logique, boucle
  web.rs                 <- serveur HTTP + WebSocket
  web/index.html          <- page affichée dans le navigateur
  core/
    memory.rs             <- la mémoire (table nom -> valeur)
    value.rs               <- les valeurs typées (Bool, Int16, ...)
    datatype.rs             <- le catalogue des types possibles
  communication/
    modbus.rs             <- client Modbus TCP (adressage décimal)
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
- mappable vers une adresse Modbus (voir section 3)

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

## 3. Envoyer/recevoir des données via Modbus TCP

Le client est prêt dans `src/communication/modbus.rs`. Il utilise
l'**adressage décimal** (style Modicon), le même que ton équipement
MODBUS_DEC :

| Plage d'adresses  | Famille          | Accès           | Taille |
|--------------------|-------------------|------------------|--------|
| 00001 – 09999       | Coil               | lecture/écriture | 1 bit  |
| 10001 – 19999       | DiscreteInput      | lecture seule     | 1 bit  |
| 30001 – 39999       | InputRegister      | lecture seule     | 16 bits|
| 40001 – 49999       | HoldingRegister    | lecture/écriture  | 16 bits|

### Étape 1 — se connecter (une fois, au démarrage)

Dans `main.rs`, section `VARIABLES`, décommenter et adapter :

```rust
use communication::modbus::ModbusClient;
let modbus_addr = "192.168.1.50:502".parse().unwrap();
let mut modbus = ModbusClient::connect(modbus_addr).await.unwrap();
```

Remplace `192.168.1.50:502` par l'IP réelle de ton équipement (502 est le
port standard Modbus TCP). Pour tester sans matériel, mets plutôt
`127.0.0.1:5502` et lance `cargo run --example mock_device` dans un autre
terminal.

### Étape 2 — lire une valeur reçue de l'équipement

Dans la boucle de cycle, section `ENVOI / RÉCEPTION DE DONNÉES MODBUS`,
**avant** `run_logic()` (on lit les entrées avant de calculer) :

```rust
if let Ok(raw) = modbus.read_decimal(30001).await {
    mem.set("temperature", Value::Int16(raw as i16));
}
```

### Étape 3 — écrire une valeur calculée vers l'équipement

Toujours dans la boucle, mais **après** `run_logic()` (on écrit les
sorties une fois qu'elles sont calculées) :

```rust
let alarm = mem.get("alarm").unwrap().as_bool();
let _ = modbus.write_decimal(1, alarm as u16).await;
```

`main.rs` contient déjà ces deux modèles en commentaire, au bon endroit
dans la boucle — il suffit de les décommenter et les adapter.

**Limite actuelle** : `read_decimal`/`write_decimal` ne traitent qu'une
seule adresse à la fois. Pour lire plusieurs registres consécutifs d'un
coup (par exemple une valeur stockée sur 32 bits = 2 registres), il faudra
étendre `modbus.rs` avec une méthode qui accepte un nombre de registres —
voir le commentaire `➜` au-dessus de `read_decimal` dans ce fichier.

## Pistes pour la suite

Dans l'ordre le plus logique pour continuer à développer ce projet :

1. **Mapping variable ↔ adresse Modbus** — au lieu d'écrire `modbus.read_decimal(30001)`
   à la main pour chaque variable, créer une liste de correspondances
   (`temperature -> 30001`, `alarm -> 00001`, ...) lue automatiquement à
   chaque cycle.
2. **Reconnexion automatique** — si l'équipement Modbus décroche (câble
   débranché, redémarrage...), le programme doit retenter la connexion au
   lieu de planter.
3. **Vrai petit langage de script** — remplacer `run_logic()` codée en dur
   par un interpréteur qui lit une logique écrite par l'utilisateur
   (`if temperature > 50 { alarm = true }`), modifiable sans recompiler.
4. **Tableaux de variables** — `temperature[0]`, `temperature[1]`... pour
   pouvoir écrire des boucles `for` dans la logique.
5. **Édition depuis l'interface web** — pouvoir changer une valeur ou la
   logique directement depuis le navigateur, pas seulement la regarder.

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
- **`Connection refused` en te connectant à un équipement Modbus** :
  vérifie l'IP/port, que l'équipement écoute bien en Modbus TCP (pas RTU
  série), et qu'aucun pare-feu ne bloque le port 502.
