using HarmonyLib;
using MelonLoader;

namespace TRHook.Hook
{
    // using System;
    // using UnityEngine;
    //
    // // Token: 0x0200062E RID: 1582
    // public partial class SpeedHackChecker : MonoBehaviour
    // {
    //      // Token: 0x06003E23 RID: 15907 RVA: 0x000B3CFC File Offset: 0x000B20FC
    //      public void Start(float checkInterval, byte falsePositives, int shotsTillCooldown)
    //      {
    //          if (this.isRunning)
    //          {
    //              Debug.LogWarning("Speehack check already running!", this);
    //              return;
    //          }
    //          this.interval = checkInterval;
    //          this.maxFalsePositives = falsePositives;
    //          this.cooldown = shotsTillCooldown;
    //          this.ResetStartTicks();
    //          this.currentFalsePositives = 0;
    //          this.currentCooldownShots = 0;
    //          this.started = true;
    //          this.isRunning = true;
    //     }
    // }

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