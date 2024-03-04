using HarmonyLib;

namespace TRHook.Hook
{
    // [HarmonyPatch(typeof(GameLogic), "GetEnemyHp")]
    // public class GameLogic_GetEnemyHp
    // {
    //     public static bool GetEnemyHp(BigNum __result, long sector)
    //     {
    //         // var bigNum = new BigNum(1.00000072);
    //         // var bigNum2 = (bigNum.Power(sector - 1L) - 1) * 5;
    //         // if (/sector > 1000000L)
    //         // bigNum2 += (0.0015 + 5E-05 * (sector - 1000000L) / 100000.0) * (sector - 1000000L) / 1000.0;
    //         // __return = MathHelpers.ExpValueEx(5.0, 1.2235 + bigNum2, sector - 1L, 5.0);
    //         __result = 1;
    //         return false;
    //     }
    // }

    // using System;
    // using System.Collections.Generic;
    // using System.Runtime.CompilerServices;
    //
    // // Token: 0x0200060C RID: 1548
    // public static partial class GameLogic
    // {
    //     // Token: 0x06003CE7 RID: 15591 RVA: 0x000AE474 File Offset: 0x000AC874
    //     public static BigNum LockedCargoPerGeneratorInterval(GameContext _context)
    //     {
    //         float lockedCargoGenerationPercent = _context.GetLockedCargoGenerationPercent();
    //         return (_context.GetCargo() + _context.GetFrozenCargo()) * (double)lockedCargoGenerationPercent;
    //     }
    // }    

    // [HarmonyPatch(typeof(GameLogic), "LockedCargoPerGeneratorInterval")]
    // public class GameLogic_LockedCargoPerGeneratorInterval
    // {
    //     public static bool Prefix(BigNum __result, GameContext _context)
    //     {
    //         var lockedCargoGenerationPercent = _context.GetLockedCargoGenerationPercent();
    //         __result = 1;
    //         return false;
    //     }
    // }
}