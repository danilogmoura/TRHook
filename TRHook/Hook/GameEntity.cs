using HarmonyLib;

namespace TRHook.Hook
{
    [HarmonyPatch(typeof(GameEntity), "AddHp")]
    public class GameEntity_AddHp
    {
        public static bool Prefix(ref BigNum newCurrent, ref BigNum newMax)
        {
            newCurrent = new BigNum(1);
            return true;
        }
    }
}