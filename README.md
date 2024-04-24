# MonoDirectorOBS
An OBS integration for MonoDirector.

Starts recordings and stops recordings automatically when MonoDirector plays/stops.

## Installation
1. Download [MonoDirector](https://github.com/Not-Enough-Photons/MonoDirector/releases/tag/v1.1.0-release) and install it
2. Download the latest release from the [releases page]() or [Thunderstore](https://thunderstore.io/c/bonelab/p/SoulWithMae/MonoDirectorOBS/)
3. Extract the zip file
4. Place the "Mods" folder in your BONELAB directory
5. Place the "UserLibs" folder in your BONELAB directory

## Usage
### OBS Setup
1. Open OBS
2. Go to `Tools` -> `WebSockets Server Settings`
3. Check `Enable WebSockets Server`
4. Check that the port is `4455`, if it is not, remember the number it is for later
5. Click "Show Connect Info"
6. Copy the password
7. Hit apply and close the window
### MelonLoader Setup
1. Run the game once so the preferences can generate
2. Open the preferences file
3. Replace `REPLACEME` in the password field with the password you copied from OBS
4. Make sure that the URL ends with the port number that OBS shows
5. Save the file