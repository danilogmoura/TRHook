using HarmonyLib;
using MelonLoader;

namespace TRHook.Hook
{
    [HarmonyPatch(typeof(SpeedHackChecker), "Start", typeof(float), typeof(byte), typeof(int))]
    public static class SpeedHackChecker_Start
    {
        private static bool Prefix()
        {
            MelonLogger.Msg("SpeedHackChecker.Start was called: Disabling SpeedHackChecker.");
            return false;
        }
    }
}