# MonoDirectorOBS
An OBS integration for MonoDirector.

Starts recordings and stops recordings automatically when MonoDirector plays/stops.

# THIS WILL NEVER WORK ON QUEST!
# HAVE OBS OPEN BEFORE OPENING BONELAB!

## Installation
1. Download [MonoDirector](https://github.com/Not-Enough-Photons/MonoDirector/releases/tag/v1.1.0-release) and install it
2. Download [OBSControl](https://github.com/WeatherElectric/OBSControl/releases/tag/v1.0.0) and install it
3. Download the latest release from the [releases page](https://github.com/WeatherElectric/MonoDirectorOBS/releases) or [Thunderstore](https://thunderstore.io/c/bonelab/p/SoulWithMae/MonoDirectorOBS/)
4. Extract the zip file
5. Place the "Mods" folder in your BONELAB directory

## Usage
### You can skip this if you already set up OBSControl!
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