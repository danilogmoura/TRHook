using HarmonyLib;

namespace TRHook.Hook
{
    [HarmonyPatch(typeof(ComponentExtensions), "GetWeaponUpgradePrice")]
    public class ComponentExtensionsPath_GetWeaponUpgradePrice
    {
        public static bool Prefix(GameContext context, ref GameEntity weapon, long levels)
        {
            weapon.weaponData.value.PriceBase = new BigNum(1);
            return true;
        }
    }

    // [HarmonyPatch(typeof(ComponentExtensions), "GetReassemblyPrice")]
    // public class ComponentExtensionsPath_GetReassemblyPrice
    // {
    //     public static bool Prefix(BigNum __result, GameContext context, ref WeaponType weaponType,
    //         ref int reassemblyLevel)
    //     {
    //         weaponType = WeaponType.HeavyTurret;
    //         reassemblyLevel = 1;
    //         return true;
    //     }
    // }

    [HarmonyPatch(typeof(ComponentExtensions), "GetFeatureUpgradePrice")]
    public class ComponentExtensionsPath_GetFeatureUpgradePrice
    {
        public static bool Pretfix(GameEntity featureEntity, ref long levels)
        {
            levels = 1;
            return true;
        }
    }
}