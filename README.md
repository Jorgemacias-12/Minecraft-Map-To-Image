# NBTMap Explorer

**NBTMap Explorer** is a tool designed to explore, preview, and export in-game map items from Minecraft world saves. It allows users to view metadata stored in the NBT format and extract map images in various formats.

## Product Vision

NBTMap Explorer is a desktop application designed to help users explore and export Minecraft item maps (`map_X.dat` files) from their game worlds in a simple, visual, and user-friendly way. It empowers players, modders, and content creators to view and manage their in-game maps outside of Minecraft.

## Target Audicence

- **Minecraft Java and Bedrock players**
- **Map creators/modders**
- **Content creators and streamers**
- **Developers interested in Minecraft data structure**
- **Users with little or no technical background who still want to visualize maps outside the game**

## Known Limitations

- Initial support is limited to detecting Minecraft installed via default directories
- Only item maps are supported (no full world rendering or world overview)
- Editing or craeting new maps is out of scope (read-only)
- Only Windows platform supported at launch
- Limited UI scaling or accessibilty support
- Bedrock support may vary depending on installed version/store path

## MVP

- Detect Minecraft installation (Java/Bedrock)
- Allow user to load a world and view available item maps (without user interaction)
- Rendeer item map visually
- Export map as image files (e.g., PNG)
- Let users provide custom game path if auto detection fails
- Clean UI with loading animation and simple navigation (would be rely on tech stack)

## Key Differentiators

- Focus on item maps ony: lightweight and direct
- Automatic detection of Minecraft editions
- Custom path support when auto-detection fails
- Direct map rendering without requiring user mods or Minecraft to be running
- Export-ready format for use in videos, guides, or creative content
- Simple and modern splash screen & UI to enhance user experience

## Sucess Criteria

- Users are able to visualize maps from their worlds within the app
- Exported images are correctly rendered and useful
- App handles common Minecraft install scenarios without crashing
- Usability feedback from initial testers is positive
- Project is stable and understandable for future iteration/expansion

## Risk and Constraints

- Changes in Minecraft folder structure (especially Bedrock) may break auto-detection
- Complex NBT formats or custom world data might be unsupported
- File access permissions may vary depending on OS or installation
- Lack of cross-platform support may limit reach
- Rendering bugs or incorrect map scaling could confuse users
- Dependencies on system fonts or external image libraries may need fallback handling.

## Technical Overview

### Architecture

The application will follow the **MVVM (Model-View-ViewModel)** pattern, ensuring a clean separation of UI, logic, and data layers. The startup flow will be handled by a splash screen window, which will orchestrate the detection of Minecraft installations and guide the user to the correct entry point (e.g., selection dialogs or main window).

### Design Patterns

| Name          | Description                                                                                                                                |
|---------------|--------------------------------------------------------------------------------------------------------------------------------------------|
| **Singleton** | For services or managers that should maintain a single instance across the application lifecycle (e.g., configuration or state managers).  |
| **Strategy**  | To define interchangeable algorithms or behaviors, such as loading and parsing logic depending on the Minecraft edition (Java or Bedrock). |
| **(Planned)**             | *(Future patterns like Adapter or Factory could be considered if the complexity grows.)*                                                   |

### Tech Stack

- **Language**: C# (.NET)
- **UI Framework**: WPF (XAML-based)
- **Architecture Pattern**: MVVM
- **Tools**:
  - Visual Studio
  - XAML Designer
  - NuGet packages as needed (e.g., Newtonsoft.Json)
- **Additional Assets**:
  - Custom font: *Monocraft*
  - Custom themes via `ResourceDictionary`

### Testing

Initial testing will be manual with planned unit test coverage for:

- Minecraft installation detection logic
- Edition selection behavior
- Configuration path validation
- Strategy behavior based on edition

Future iterations may include UI testing or automated integration tests depending on stability and complexity.

## Acknowledgments

This project was inspired by [Shokuno](https://github.com/Shokuno), who originally created a similar tool in Java. This version builds upon that idea using C# and WPF, aiming to provide an improved user experience and additional features.

- Special thanks to [Shokuno](https://github.com/Shokuno) for the original concept and implementation in Java.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.