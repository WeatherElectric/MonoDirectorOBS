// ReSharper disable MemberCanBePrivate.Global, these categories may be used outside of this namespace to create bonemenu options.

namespace WeatherElectric.MonoDirectorOBS.Melon;

internal static class Preferences
{
    public static readonly MelonPreferences_Category GlobalCategory = MelonPreferences.CreateCategory("Global");
    public static readonly MelonPreferences_Category OwnCategory = MelonPreferences.CreateCategory("MonoDirectorOBS");

    public static MelonPreferences_Entry<int> LoggingMode { get; set; }
    public static MelonPreferences_Entry<string> WebsocketURL { get; set; }
    public static MelonPreferences_Entry<string> WebsocketPassword { get; set; }

    public static void Setup()
    {
        LoggingMode = GlobalCategory.GetEntry<int>("LoggingMode") ?? GlobalCategory.CreateEntry("LoggingMode", 0,
            "Logging Mode", "The level of logging to use. 0 = Important Only, 1 = All");
        GlobalCategory.SetFilePath(MelonUtils.UserDataDirectory + "/WeatherElectric.cfg");
        GlobalCategory.SaveToFile(false);
        WebsocketURL = OwnCategory.CreateEntry("WebsocketURL", "ws://127.0.0.1:4455", "Websocket URL", "The URL to use for the websocket connection. Usually don't have to change this.");
        WebsocketPassword = OwnCategory.CreateEntry("WebsocketPassword", "REPLACEME", "Websocket Password", "The password to use for the websocket connection. Change this to the password you set in OBS.");
        OwnCategory.SetFilePath(MelonUtils.UserDataDirectory + "/WeatherElectric.cfg");
        OwnCategory.SaveToFile(false);
        ModConsole.Msg("Finished preferences setup for MonoDirectorOBS", 1);
    }
}