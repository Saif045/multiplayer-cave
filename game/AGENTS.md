# Multiplayer Cave ownership

Place game code, scenes, assets, tests and design records under `game/`. Use [game design](docs/game_design.md) for current decisions, [architecture](docs/architecture.md) for integration, and [the roadmap](docs/development_plan.md) for sequencing. Implement the requested milestone only.

The developer owns cave layout, modeling, geometry, materials, textures, lighting placement, environmental art and final composition. Preserve authored levels and visuals during programming work. Use ordinary Godot scenes for maps and rooms. Procedural generation, World Builder, automatic decoration and changes to the developer's visual composition require separate direction.

Compose GameFactory's public interfaces for sessions, identities, spawning, authoritative interactions, carry, replication and Netfox. Keep game rules and schemas here. Shared state is server-authoritative. Keep account, peer, session player, network object and represented-owner identities distinct. Use the factory starter only as reference and verification material.

Follow the [root ownership router](../AGENTS.md) for shared integration and the relevant [factory guides](../factory/AGENTS.md) before working with upstream mechanisms. Keep vendor and factory provenance intact. Record actual verification and its limits.
