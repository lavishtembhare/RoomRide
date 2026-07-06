# RoomRide

A Unity project (Unity 6000.4.1f1 / URP) for **RoomRide**.

## Current State

This repository is currently initialized from Unity's **"Unity Essentials"** learning-pathway template rather than containing custom RoomRide gameplay yet. Everything under `Assets/_Unity Essentials/` is the stock tutorial content that ships with that pathway — sample scenes (kids' room, kitchen, living room, playground, top-down 2D), starter scripts (`PlayerController`, `Collectible`, `DoorOpener`, `DayNightCycle`, etc.), and a third-person controller. `Assets/Scenes/SampleScene.unity` is the default empty URP scene, and no scene is currently registered in Build Settings.

In short: this is an early-stage scaffold — a good sign the project was bootstrapped following the Unity Essentials course, but the RoomRide-specific game (mechanics, art, levels) hasn't been layered on top yet. Treat this README as a starting point to fill in as real gameplay is added.

## Tech Stack

| Component            | Detail                                  |
|-----------------------|------------------------------------------|
| Engine               | Unity 6000.4.1f1                         |
| Render Pipeline      | Universal Render Pipeline (URP) 17.4.0   |
| Input                | Unity Input System 1.19.0                |
| Camera               | Cinemachine 2.10.6                       |
| UI                   | UGUI + TextMesh Pro                      |
| Scripting            | C#                                        |
| Extras               | Timeline, Visual Scripting, 2D feature set |

## Project Structure

```
Assets/
├── _Unity Essentials/         # Stock tutorial content (scenes, scripts, art, audio)
│   ├── Scenes/                 # Tutorial scenes (KidsRoom, Kitchen, LivingRoom, Playground, TopDown2D, etc.)
│   ├── Scripts/                # PlayerController, Collectible, DoorOpener, DayNightCycle, ...
│   └── Source Files/           # Additional starter scripts, third-person controller, input actions
├── Scenes/
│   └── SampleScene.unity       # Default empty URP scene
├── Settings/                   # URP render pipeline & post-processing assets
├── TextMesh Pro/                # TMP resources/fonts
├── InputSystem_Actions.inputactions
└── Readme.asset                 # Unity's default in-editor Readme
Packages/
└── manifest.json                # Package dependencies
ProjectSettings/                  # Unity project configuration
```

## Getting Started

1. **Install Unity Hub** and Unity Editor version **6000.4.1f1** (or newer, matching version recommended to avoid asset-reimport issues).
2. **Clone the repo**

   ```bash
   git clone https://github.com/lavishtembhare/RoomRide.git
   ```

3. Open **Unity Hub** → **Add project from disk** → select the cloned `RoomRide` folder.
4. Let Unity import all assets and resolve packages from `Packages/manifest.json` (first import can take a few minutes).
5. Open a scene to explore — e.g. `Assets/Scenes/SampleScene.unity` for the blank URP starter scene, or any scene under `Assets/_Unity Essentials/Scenes/` to see the tutorial content in action.

## Roadmap / Next Steps

Since this is currently a scaffold, likely next steps for turning it into the actual RoomRide game include:

- [ ] Define core gameplay mechanics and add a dedicated `Assets/RoomRide/` (or similar) folder for game-specific scripts, separate from the tutorial content
- [ ] Build out real scenes for the game and register them in Build Settings
- [ ] Replace/extend the starter `PlayerController` with RoomRide-specific movement and interaction logic
- [ ] Add project-specific art, audio, and UI
- [ ] Decide whether to keep or remove the `_Unity Essentials` tutorial assets once no longer needed as reference

## License

This project is licensed under **CC0 1.0 Universal** (public domain dedication) — see [LICENSE](LICENSE). Note that Unity's own package/tutorial assets under `Assets/_Unity Essentials/` and `Assets/TextMesh Pro/` may carry their own licensing terms from Unity Technologies; check those folders' documentation before redistributing.
