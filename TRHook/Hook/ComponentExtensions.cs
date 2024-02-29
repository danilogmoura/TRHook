using HarmonyLib;

namespace TRHook.Hook
{
    [HarmonyPatch(typeof(ComponentExtensions), "GetWeaponUpgradePrice")]
    public class ComponentExtensionsPath_GetWeaponUpgradePrice
    {
        public static bool Prefix(BigNum __result)
        {
            __result = 1;
            return false;
        }
    }
}