# Task 001 — Production initialization report

## Repository and provenance

- Destination `D:\games\GODOT-GAMES\multiplayer-cave`
- Production initialization commit `8f772382b88c412010bb449a5674fb338ea1b057`. This report is in the following documentation-only commit. Run `git rev-parse origin/main` for the published tip including this report.
- GameFactory release `gamefactory-v0.2`, annotated tag object `b49942a7cdf1c96869eb49f54336e157304ed368`, peeled commit `f6c47c4a68d8ec2ceff4460c6b64cb7ed32858fb`. The upstream tag and the local checkout resolved to the same peeled commit.
- `origin` is `https://github.com/Saif045/multiplayer-cave.git`. GitHub advertised zero refs before initialization.
- `gamefactory` is `https://github.com/Saif045/godot-multiplayer-game-factory.git`.
- Verify ancestry with `git merge-base --is-ancestor f6c47c4a68d8ec2ceff4460c6b64cb7ed32858fb main`. Exit code 0 confirms ancestry.

## Project structure

- Root `project.godot` and `GameFactory.sln` provide shared Godot and C# integration.
- `game/shell/` owns the online scene, fallback and identity-only participant composition required by the factory shell.
- `game/levels/maps/cave.tscn` is an empty authored map entry.
- `game/AGENTS.md` and `game/docs/` record ownership, design, architecture and the roadmap.
- `factory/` holds the upstream mechanisms and starter reference. `addons/` and `third_party/` hold inherited dependencies. The initialization diff contains only root integration and game-owned files.

## Versions and dependencies

Windows x64 testing used Godot `4.7.1.stable.mono.official.a13da4feb`, .NET SDK `9.0.308` and installed .NET 8 runtime `8.0.22`. The project pins `Godot.NET.Sdk/4.7.1` and targets `net8.0` for desktop. Godot editor plugins and runtime dependencies are bundled, including Maaack's Game Template, Netfox, GodotGAS and the Windows x64 GodotSteam 4.22 extension built with Steamworks SDK 1.65. Online development uses Steam App ID 480 with a signed-in Steam desktop client. A packaged build was outside this verification. Exporting a Windows build requires matching Godot 4.7.1 .NET export templates.

## Validation

| Check | Result | Local evidence and assertions |
| --- | --- | --- |
| Solution build | Pass | `factory/artifacts/task_001/build-network.log`. Zero warnings and errors. The first sandboxed build succeeded with NuGet audit feed warnings. |
| Factory unit tests | Pass | `factory/artifacts/task_001/unit-network.trx`. 73 passed, zero failed or skipped. The first sandboxed VSTest run timed out connecting to its test host. The unrestricted rerun passed. |
| First headless import | Fail | `factory/artifacts/online_gameplay_routing/cave_task001_cold/`. Netfox autoload type-inference errors on the first scan, as documented by GameFactory. |
| Second headless import and online routing | Pass | `factory/artifacts/online_gameplay_routing/cave_task001_warm/`. Editor plugin initialization completed. GodotGAS dashboard icon UIDs fell back to bundled text paths. The routing fixture checked configured and fallback resolution, one-shot Host, direct Join, invite and command-line intents, and pending-invite rejection. The routing fixture logged one ObjectDB instance at exit. |
| Normal graphical launch | Pass | `factory/artifacts/task_001/cave_task001_normal/`. Forward+ initialized, SteamPlatform and GameShell reached ready, Netfox registered its performance monitors, and the main menu loaded. The process exited successfully with no engine errors. |
| Factory reference round suite | Pass | `factory/artifacts/round_composition/cave_task001_reference/`. Starter player/GAS/carry/inventory regression checks, repeated starter rounds, custom spawn initialization, and custom and empty-content local ENet host/client round reuse and teardown passed. |
| Single-account Steam host and exit | Fail at application shutdown | `factory/artifacts/task_001/cave_task001_launch_timer/`. A real Steam listen lobby opened the game-owned scene. Two rounds spawned fresh participants and cleared them on return while retaining the Steam peer. Leave closed the peer and returned to the main menu. Application shutdown logged an attempted disconnect of a nonexistent `process_frame` connection from the Steam shutdown call and three ObjectDB instances at exit. The same sequence against the starter scene reproduced the shutdown issue in `factory/artifacts/task_001/cave_task001_launch_starter/`. |

The runtime attempts exited and their disposable test profiles were removed. The cold-scan workaround is to let Godot finish its first import and then reopen the project. The Steam shutdown error remains open. This run exercised a single Steam account and local ENet peers. Two-account Steam connectivity, invitations over Steam transport, and cave gameplay acceptance remain unverified.

## Open the project

1. Install Godot **4.7.1 .NET** for Windows x64, a .NET SDK that can build `net8.0` and the .NET 8 desktop runtime.
2. In Godot Project Manager, choose **Import**, select `D:\games\GODOT-GAMES\multiplayer-cave\project.godot`, and open it. Wait for the initial scan to finish. If the first scan reports Netfox parse errors, close and reopen the editor.
3. Run `dotnet build GameFactory.sln` from the repository root. In the editor, press **F5** for the main menu. Sign in to Steam before testing Host or Join.
4. Open `game/levels/maps/cave.tscn` directly to author the cave in the editor.

## Task 002

Replace the shell participant and its spawn data with a game-owned diver. Add first- and third-person cameras, swimming and dry movement, water transitions, and Netfox movement synchronization. Verify with a host and client. See the [development plan](development_plan.md).
