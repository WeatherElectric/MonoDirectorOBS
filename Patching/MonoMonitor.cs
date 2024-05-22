using HarmonyLib;
using NEP.MonoDirector.Core;
using WeatherElectric.OBSControl.OBS;

namespace WeatherElectric.MonoDirectorOBS.Patching;

internal static class MonoMonitor
{
    [HarmonyPatch(typeof(Playback))]
    private static class PlaybackPatch
    {
        [HarmonyPostfix]
        [HarmonyPatch(nameof(Playback.OnPlay))]
        private static void Play()
        {
            OnPlay();
        }
        
        [HarmonyPostfix]
        [HarmonyPatch(nameof(Playback.OnStopPlayback))]
        private static void Stop()
        {
            OnStop();
        }
    }
    
    private static void OnPlay()
    {
        ModConsole.Msg("MD OnPlay Event fired", 1);
        ObsBridge.StartRecording();
        ModConsole.Msg("Started recording in MD", 1);
    }
    
    private static void OnStop()
    {
        ModConsole.Msg("MD OnStopPlayback Event fired", 1);
        ObsBridge.StopRecording();
        ModConsole.Msg("Stopped recording in MD", 1);
    }
}