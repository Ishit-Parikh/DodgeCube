# DodgeCube

A 2D Unity dodge-game built with Unity 6000.3.18f1. Control a cube and dodge falling obstacles for as long as you can.

## How to Play

- Press **A** to move left
- Press **D** to move right
- Dodge the falling cubes! Each dodge makes the game progressively faster.

## Project Structure

| File | Purpose |
|---|---|
| `Assets/Player.cs` | Player movement (A/D keyboard input, horizontal translation) |
| `Assets/Collide.cs` | Trigger detection — logs "Game Over" on collision |
| `Assets/StuffThatNeedsToBeDodged.cs` | Falling obstacle behaviour — spawns at random X, falls downward, speeds up over time |
| `Assets/Scenes/SampleScene.unity` | The main game scene |
| `Assets/InputSystem_Actions.inputactions` | Input Action Asset (Unity Input System) |
| `ProjectSettings/` | Unity project configuration (URP, physics, quality, etc.) |

## Built With

- **Unity** 6000.3.18f1
- **Universal Render Pipeline** (2D URP)
- **Unity Input System** package
