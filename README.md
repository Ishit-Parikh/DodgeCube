# DodgeCube

A 2D Unity dodge-game built with Unity 6000.3.18f1. Control a cube and dodge falling obstacles for as long as you can.

## How to Play

- Press **A** to move left
- Press **D** to move right
- Dodge the falling cubes! Each successful dodge increments your score.

## Project Structure

| File | Purpose |
|---|---|
| `Assets/Scripts/BoppyMovement.cs` | Player movement (A/D input, horizontal translation with clamping) + collision detection — logs "GAME-OVER!" on obstacle hit |
| `Assets/Scripts/GameControll.cs` | Spawns obstacles at random X positions, tracks score, updates UI TextMeshPro score display |
| `Assets/Scripts/Obstacle.cs` | Falling obstacle behaviour — falls downward at constant speed, resets spawn flag and increments score on ground collision |
| `Assets/Prefab/Droppy.prefab` | The falling obstacle prefab |
| `Assets/Scenes/SampleScene.unity` | The main game scene |
| `ProjectSettings/` | Unity project configuration (URP, physics, quality, etc.) |

## Built With

- **Unity** 6000.3.18f1
- **Universal Render Pipeline** (2D URP)
- **TextMesh Pro** (score UI)
