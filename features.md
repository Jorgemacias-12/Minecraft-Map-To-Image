# Features

## 🚀 Epic: View Minecraft Maps (Item Maps)

### ✅ User Story: As a user, I want to load my Minecraft worlds so the app can find the available item maps

**Tasks:**

- Detect installation of Minecraft Java and Bedrock
- Read default install paths and allow user to set custom path if none is found
- Display a list of available worlds (per edition)

---

### ✅ User Story: As a user, I want to view the maps that exist in a specific world

**Tasks:**

- Read `map_X.dat` files from the selected world
- Parse the NBT files and extract relevant data
- Display the maps in a list or gallery

---

### ✅ User Story: As a user, I want to preview a map as an image

**Tasks:**

- Render the contents of the `.dat` file as an image
- Implement basic zoom or scaling for preview
- Show extra map info if available (ID, scale, relative position, etc.)

---

### ✅ User Story: As a user, I want to export a map as an image for use outside the game

**Tasks:**

- Add export button
- Allow choosing file format (at least PNG)
- Save image to the file system

---

### ✅ User Story: As a user, I want to know if Minecraft was correctly detected at startup

**Tasks:**

- Show message if no Minecraft installation is detected
- Allow user to set custom path

---

### ✅ User Story: As a user, I want a clean interface with a loading animation at startup

**Tasks:**

- Splash screen with spinner animation
- Visual and text-based loading progress
- Hide splash screen and show main window after loading completes

---

## 🧪 Epic: Testing & Software Quality

### 🧪 Set up test environment

**Description:**  
Set up the environment to write and run unit and integration tests.

- Create separate test project
- Define folder structure and naming conventions

**Tags:** `testing`, `setup`, `devops`

---

### 🧪 Write unit tests for Minecraft detection logic

**Description:**  
Ensure the system correctly detects whether Minecraft Java or Bedrock is installed.

- Validate the return value of `IsMinecraftInstalled()`
- Test cases: Java only, Bedrock only, both, none

**Tags:** `testing`, `unit-test`

---

### 🧪 Write tests for NBT map file reading

**Description:**  
Ensure `map_x.dat` files are correctly read and parsed.

- Verify successful load
- Handle corrupted or invalid files

**Tags:** `testing`, `unit-test`, `edge-cases`

---

### 🧪 Integration test: World and map selection

**Description:**  
Test the full flow: detect world → read maps → display list.

- Validate correct flow
- Test error handling

**Tags:** `testing`, `integration-test`

---

### 🧪 Manual UI testing

**Description:**  
Define a manual test checklist to ensure the UI works as expected.

- Splash screen behavior
- Visual validation of rendered maps
- Test on systems with and without Minecraft installed

**Tags:** `testing`, `manual-test`, `UX`

---

### 🧪 Set up automated tests in CI (when defined)

**Description:**  
Once CI is selected (e.g., GitHub Actions, Azure Pipelines), integrate test runs into the pipeline.

- Run tests on push/pull request
- Generate test reports

**Tags:** `devops`, `CI/CD`, `testing`