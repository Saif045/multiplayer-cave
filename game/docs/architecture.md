# Architecture

The project consumes GameFactory `gamefactory-v0.2` through Git ancestry. [The version marker](../../.gamefactory-version) records the peeled release commit. Keep reusable mechanisms under `factory/`, product code and content under `game/`, dependencies under `addons/` and `third_party/`, and integration settings in the root Godot and .NET project files.

## Scene composition

The root Godot project starts GameFactory's application bootstrap and main menu. The game-owned GameShell autoload configures the same game-owned target as Maaack's `game_scene_path` for Host, Join, Steam invites and `+connect_lobby`. The factory shell consumes each launch intent once and owns the Steam session across rounds. The game scene composes `OnlineGameplayShell`, `OnlineGameplayWorld`, `NetworkWorld` and the factory pause controller.

The world instances the authored map as static scene content. Task 001 supplies the shell-required participant scene and spawn-data provider. The server supplies a session `PlayerId` as the only initialization field. The participant is an identity-bearing network object for shell lifecycle. The empty round-content path leaves dynamic equipment and other game content for later tasks. Task 002 replaces the participant scene and its spawn-data contract with the game-owned diver. The inherited starter scene remains an explicit reference and smoke-test fixture under `factory/starter/`.

## Authority and responsibility

| GameFactory mechanisms | Multiplayer Cave responsibilities |
| --- | --- |
| Steam and network sessions, peer and session player lifecycle | Player-facing game rules and gameplay-specific player attributes |
| Server-owned world spawn and despawn, replication and Netfox-backed physical simulation | Diver input and swimming, water detection and physical state |
| Authoritative interaction and carry | Equipment and flashlight behavior, inventory semantics and breathing gas |
| Session and round lifecycle | Round objectives and outcomes, authored levels and equipment placement |

Clients submit inputs and interaction requests. The server validates shared gameplay actions and owns world spawning, item state, gas state and round outcomes. Replicate the resulting state through GameFactory and use Netfox for diver movement. Keep represented ownership distinct from authority over the network object. Keep level scenes independent of player scripts and game rules, and keep game-specific rules out of GameFactory. Develop game-owned item and breathing models through the public contracts. The starter GAS and inventory provide reference implementations.

See the [GameFactory shell contract](../../factory/shell/README.md), [mechanism catalog](../../factory/README.md) and [ownership guide](../../factory/docs/ownership.md).
