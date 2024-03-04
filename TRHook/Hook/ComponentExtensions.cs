using HarmonyLib;

namespace TRHook.Hook
{
    // using System;
    // using UnityEngine;
    //
    // // Token: 0x020000B4 RID: 180
    // public static partial class ComponentExtensions
    // {
    //     // Token: 0x06000375 RID: 885 RVA: 0x0000A954 File Offset: 0x00008D54
    //     public static BigNum GetWeaponUpgradePrice(this GameContext context, GameEntity weapon, long levels)
    //     {
    //         BigNum priceBase = weapon.weaponData.value.PriceBase;
    //         BigNum bigNum = GameLogic.TotalWeaponUpgradePrice(priceBase, Constants.WeaponPriceExp, weapon.level.value, weapon.level.value + levels);
    //         return context.GetMoneyPriceWithDiscount(bigNum);
    //     }
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
}