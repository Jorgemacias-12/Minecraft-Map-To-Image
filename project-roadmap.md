# Minecraft Map To Image

## Specific requirements

- Preview maps of a given Minecraft World
- Export the map to different formats like
  (PNG, JPEG, BMP, GIF, etc).
- Retro compatilibility between Java and Bedrock
- Has to be compatible with different Minecraft versions (only appliable to Java)
- Have a ui that allows to change between Minecraft Versions

## Research before implementation

To achieve the requirements, I have to find a way to:

### Minecraft Installation Detection

To achieve the requirements, I have to find a way to:

- Java Edition:
  - How to detect if Minecraft is installed or not in the os.
  - Check for common Minecraft installation paths.
  - Allow to user to indicate his own Minecraft installation path.

- Bedrock Installation:
  - How to check if is installed or not (only windows)

### Save managment

- Detection:
  - Read how many worlds are avaialble
  - Check if they're valid or not.

- Compatibility
  - Indentify and handle different versions of the saves (only Minecraft Java)

# Map Data Reading and Processing

- Minecraft format files:
  - Do research about which filetypes are being used to store minecraft map data. (.dat)
  - Search for a NBT lib that already makes the job to read and retrieve NBT file data. In this case I'll use [fNBT](https://github.com/mstefarov/fNbt)
  - 