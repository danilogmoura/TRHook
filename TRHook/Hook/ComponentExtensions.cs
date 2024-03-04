using HarmonyLib;

namespace TRHook.Hook
{
    // // Token: 0x06000375 RID: 885 RVA: 0x0000A954 File Offset: 0x00008D54
    // public static BigNum GetWeaponUpgradePrice(this GameContext context, GameEntity weapon, long levels)
    // {
    //     BigNum priceBase = weapon.weaponData.value.PriceBase;
    //     BigNum bigNum = GameLogic.TotalWeaponUpgradePrice(priceBase, Constants.WeaponPriceExp, weapon.level.value, weapon.level.value + levels);
    //     return context.GetMoneyPriceWithDiscount(bigNum);
    // }

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

    // using System;
    // using UnityEngine;
    //
    // // Token: 0x020000B4 RID: 180
    // public static partial class ComponentExtensions
    // {
    //     // Token: 0x0600037E RID: 894 RVA: 0x0000AAAC File Offset: 0x00008EAC
    //     public static BigNum GetFeatureUpgradePrice(this GameEntity featureEntity, long levels)
    //     {
    //         IPrice price = featureEntity.feature.price;
    //         BigNum bigNum = price.GetTotalPrice(featureEntity.level.value + levels) - price.GetTotalPrice(featureEntity.level.value);
    //         if (featureEntity.hasPrestigeConfig && featureEntity.prestigeLevel.value > 0L)
    //         {
    //             bigNum *= Math.Pow((double)featureEntity.prestigeConfig.priceIncreaseMultPerPrestige, (double)featureEntity.prestigeLevel.value);
    //         }
    //         return bigNum;
    //     }
    // }

    // [HarmonyPatch(typeof(ComponentExtensions), "GetFeatureUpgradePrice", typeof(GameEntity), typeof(long))]
    // public class ComponentExtensionsPath_GetFeatureUpgradePrice
    // {
    //     public static bool Pretfix(GameEntity featureEntity, BigNum __result, ref long levels)
    //     {
    //         levels = 1;
    //         // __result = new BigNum(1);
    //         return true;
    //     }
    // }
}