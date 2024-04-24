

using OBSWebsocketDotNet;

namespace WeatherElectric.MonoDirectorOBS.OBS;

// ReSharper disable once InconsistentNaming
public static class OBSBridge
{
    private static OBSWebsocket _obs;
    internal static void Init()
    {
        ModConsole.Msg("Initializing OBSBridge", 1);
        _obs = new OBSWebsocket();
    }

    internal static void Connect()
    {
        ModConsole.Msg("Connecting to OBS", 1);
        try
        {
            _obs.ConnectAsync(Preferences.WebsocketURL.Value, Preferences.WebsocketPassword.Value);
            ModConsole.Msg("Connected to OBS", 1);
        }
        catch (Exception e)
        {
            ModConsole.Error($"Failed to connect to OBS. Exception {e.Message} thrown.");
        }
    }

    internal static void Disconnect()
    {
        _obs.Disconnect();
    }
    
    public static void StartRecording()
    {
        try
        {
            _obs.StartRecord();
            ModConsole.Msg("Started recording in OBS", 1);
        }
        catch (Exception e)
        {
            ModConsole.Error($"Failed to start recording. Exception {e.Message} thrown.");
        }
    }

    public static void StopRecording()
    {
        try
        {
            _obs.StopRecord();
            ModConsole.Msg("Stopped recording in OBS", 1);
        }
        catch (Exception e)
        {
            ModConsole.Error($"Failed to stop recording. Exception {e.Message} throwwn.");
        }
    }
}