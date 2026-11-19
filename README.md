# Simulateur d’automate

Simulateur PLC en Rust : supervision web, registres Holding Modbus TCP et
variables de simulation.

## Démarrer

```bash
cargo run
```

Ouvre ensuite **http://127.0.0.1:3000**. Le serveur Modbus utilise le port
déclaré dans `COMM.DAT` (502 dans le fichier fourni).

## Utiliser l’interface

### Modifier les frames

Dans l’onglet **Frames**, ouvre un registre pour basculer ses bits ou saisir sa
valeur (0 à 65535). Survole un bit pour afficher son nom issu de
`src/core/ThisProject.vb`. Dans `FrameEmplPlateaux`, chaque registre indique
aussi l’emplacement correspondant. Le champ de recherche filtre les frames par
nom ou registre. Le mot haut réservé à l’offset 21 reste toujours à `0` et
ne peut être ni modifié ni lié à une variable;
le menu **Format des valeurs** passe du décimal à l’hexadécimal. L’adresse
affichée est l’adresse de départ plus l’offset. Les modifications sont
appliquées et sauvegardées automatiquement.

Tu peux changer l’adresse de départ, ajouter des registres, ou retirer les
registres ajoutés. Une frame ne peut pas être raccourcie sous la taille définie
dans `COMM.DAT`. Un registre lié à une variable ne peut pas être retiré tant
que cette liaison existe.

### Lier une variable

Dans la frame, choisis une variable, indique l’offset du premier registre
(l’offset commence à 0), puis clique **Lier la variable**. Un badge affiche la
liaison sur le ou les registres concernés; **Délier** la retire. Une variable ne
peut être liée qu’une seule fois. `BOOL` et les types 16 bits utilisent un
registre; `UINT32` et `DWORD` en utilisent deux, poids fort en premier.

La liaison synchronise le registre et la variable : les écritures Modbus
mettent à jour la variable et la simulation republie sa valeur vers le registre.
Si la logique de simulation recalcule cette variable, sa valeur peut changer au
cycle suivant.

Le bouton au-dessus du tableau met la simulation en pause ou la reprend. Tu peux
aussi saisir une valeur dans la colonne **Forçage** : **Forcer** maintient cette
valeur même si la logique tourne; **Libérer** rend la variable à la simulation.
Les variables forcées sont indiquées comme telles. Les forçages ne sont pas
conservés après l’arrêt du programme.

### Enregistrer et appliquer des états

Dans l’onglet **États sauvegardés** :

1. Donne un nom à l’état actuel et clique **Enregistrer l’état actuel**.
2. Sélectionne un état : les différences d’adresses, registres et liaisons
   apparaissent. Coche la confirmation puis applique l’état à toutes les frames.
3. Utilise **Exporter l’état** pour créer un fichier JSON ou **Importer** pour
   charger un fichier. Le champ du nom peut renommer l’état importé.
4. Utilise **Supprimer l’état** pour effacer un état sauvegardé.

Enregistrer sous un nom existant remplace cet état. La configuration active est
conservée dans `modbus_config.json`; les états nommés le sont dans
`modbus_config.presets.json`.

## Règles Modbus

- Les adresses de registre sont des offsets Modbus 0-based.
- Les frames `R` restent modifiables depuis l’interface, mais les clients
  Modbus ne peuvent pas leur écrire.
- Le port 502 peut nécessiter des droits élevés ou être déjà utilisé.

## Cycle des plateaux

La frame `FrameEmplPlateaux` suit les emplacements définis dans `ThisProject.vb`.
À chaque cycle actif de simulation, les 110 premiers registres avancent d’un
emplacement et le dernier revient au premier. Les emplacements `Reserve1`,
`Reserve2` et `Reserve3` sont exclus de la rotation; `Reserve1` (emplacement 22)
est maintenu à `0`. Les registres supplémentaires ne sont pas déplacés. Mettre
la simulation en pause arrête aussi cette rotation.

## Développement

- `src/main.rs` : variables initiales, logique et cycle de simulation.
- `src/web.rs` et `src/web/index.html` : API et interface web.
- `src/communication/modbus_server.rs` : frames, validations et serveur Modbus.

Lancer les tests avec `cargo test`.
