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
}