namespace WeatherElectric.MonoDirectorOBS;

public class Main : MelonMod
{
    internal const string Name = "MonoDirectorOBS";
    internal const string Description = "OBS integration for MonoDirector.";
    internal const string Author = "SoulWithMae";
    internal const string Company = "Weather Electric";
    internal const string Version = "1.1.0";
    internal const string DownloadLink = "https://thunderstore.io/c/bonelab/p/SoulWithMae/MonoDirectorOBS/";

    public override void OnInitializeMelon()
    {
        ModConsole.Setup(LoggerInstance);
        Preferences.Setup();
    }
}