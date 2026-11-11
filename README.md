# Multiplayer Cave

Multiplayer Cave is a cooperative underwater cave survival game for 1–4 players. Players explore handcrafted caves and work together to escape alive with limited breathing gas.

Open or import the root `project.godot` in **Godot 4.7.1 .NET** on Windows x64. Install a .NET SDK that can build the `net8.0` desktop target and the .NET 8 runtime. Run `dotnet build GameFactory.sln`, then press **F5** to open the main menu. If Netfox reports parse errors on the first scan of a fresh checkout, let the scan finish and reopen the project. Online sessions use development Steam App ID 480 and require a signed-in Steam client.

The game-owned map is `game/levels/maps/cave.tscn`. The map starts empty for manual level authoring. The online shell is wired to the game scene and represents participants by session identity until Task 002 adds the diver.

- [Game design](game/docs/game_design.md)
- [Architecture](game/docs/architecture.md)
- [Development plan](game/docs/development_plan.md)
- [Task 001 verification](game/docs/task_001_report.md)
- [GameFactory mechanism catalog](factory/README.md) and [consumer workflow](factory/docs/consuming-gamefactory.md)
