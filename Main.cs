using WeatherElectric.MonoDirectorOBS.OBS;

namespace WeatherElectric.MonoDirectorOBS;

public class Main : MelonMod
{
    internal const string Name = "MonoDirectorOBS";
    internal const string Description = "OBS integration for MonoDirector.";
    internal const string Author = "SoulWithMae";
    internal const string Company = "Weather Electric";
    internal const string Version = "1.0.0";
    internal const string DownloadLink = null;

    public override void OnInitializeMelon()
    {
        ModConsole.Setup(LoggerInstance);
        Preferences.Setup();
        
        OBSBridge.Init();
        OBSBridge.Connect();
    }
    
    public override void OnApplicationQuit()
    {
        OBSBridge.Disconnect();
    }
}