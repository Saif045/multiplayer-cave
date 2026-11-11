# Development plan

## Task 001 — Production initialization

- Initialize the repository from the verified GameFactory release and preserve its ancestry.
- Validate the Godot .NET project, inherited checks and game-owned entry scene.
- Record design, architecture and verification in game-owned documentation.

## Task 002 — Multiplayer diver

- Compose a game-owned diver with first- and third-person cameras.
- Implement swimming, dry movement and transitions between water and air.
- Synchronize movement with Netfox and verify it with a host and client.

## Task 003 — Flashlight and inventory

- Make the flashlight interactable and support pickup, equip, unequip and drop.
- Implement a small game-owned inventory and replicate the flashlight's light state.
- Verify authority, ownership and lifecycle cleanup.

## Task 004 — Breathing system

- Implement limited gas, consumption and depletion, and replaceable cylinders.
- Support cooperative gas sharing with authoritative state and UI.

## Task 005 — Equipment placement

- Use author-defined spawn points in handmade levels and keep item definitions independent of placement.
- Evaluate optional deterministic random selection.
- Spawn equipment authoritatively and enforce essential-item availability.

## Task 006 — Round gameplay

- Define the escape objective and round start and end rules.
- Define incapacitation and failure rules.
- Verify multiplayer outcomes and round cleanup.
