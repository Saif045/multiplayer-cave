# Game design

This document records the current design decisions for Multiplayer Cave.

## Core concept

Multiplayer Cave is cooperative underwater cave survival for an initial 1–4 players. Players explore and try to escape alive. Most of the cave is underwater, with some air pockets or dry areas. Breathing gas is limited. Players will eventually be able to share gas and can find spare cylinders and equipment throughout the environment. Navigation, cooperation and environmental pressure drive play.

## Level design

Levels are currently 100% handcrafted. The developer manually authors cave layouts, chambers, corridors, connections, geometry, materials, textures, environmental art, lighting placement and final visual composition. The game loads ordinary authored Godot scenes. Keep the levels independent of player logic and game rules.

Procedural room, tunnel and layout generation, World Builder and automated decorative rock placement are outside the current design. Future procedural generation remains an open direction.

## Responsibilities

The developer owns 3D modeling, level design, visual art, materials, cave construction and creative direction. Codex handles networking, diver movement, gameplay programming, item systems, interactions, breathing mechanics, game rules and automated tests. Codex builds bounded technical tools when specifically requested. Changes to environment design or decoration require developer direction.

## Open design questions

- What governs gas consumption and sharing?
- How much can a diver carry, and which item categories exist?
- How do death, unconsciousness and rescue work?
- What equipment does each player start with, and under what conditions can equipment be recovered?
- What counts as escape?
- Which environmental hazards and marine life belong in the game?
- How should progression and replayability work?
- Where, if anywhere, should future automation or procedural generation be used?
