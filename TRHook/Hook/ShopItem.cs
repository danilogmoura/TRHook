using HarmonyLib;
using MelonLoader;

namespace TRHook.Hook
{
    // using System;
    // using System.Runtime.CompilerServices;
    // using UnityEngine;
    //
    // // Token: 0x0200032D RID: 813
    // public abstract partial class ShopItem
    // {
    //     // Token: 0x0600105D RID: 4189 RVA: 0x00033FF4 File Offset: 0x000323F4
    //     public virtual void Buy()
    //     {
    //         if (this.Context.steamClientEntity.hasSteamCoins && this.Context.steamClientEntity.steamCoins.value >= this.Price)
    //         {
    //             if (!Application.isEditor)
    //             {
    //                 this.Context.steamClientEntity.AddSteamConsumeCoinsRequest(this.Price);
    //             }
    //             this.OnBuy();
    //         }
    //     }
    // }

    [HarmonyPatch(typeof(ShopItem), "Buy")]
    public class ShopItem_Buy
    {
        public static bool Prefix(ShopItem __instance)
        {
            MelonLogger.Msg("OnBuy() called! newValue: " + __instance.Price);
            __instance.Price = 0;
            Traverse.Create(__instance).Method("OnBuy").GetValue();
            MelonLogger.Msg("OnBuy() called! newValue: " + __instance.Price);

            return false;
        }
    }
}