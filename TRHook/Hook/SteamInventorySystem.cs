using System;
using System.Collections.Generic;
using Entitas;
using Facepunch.Steamworks;
using HarmonyLib;

namespace TRHook.Hook
{
    // [HarmonyPatch(typeof(SteamInventorySystem), "HandleConsumeCoinsRequest")]
    // public class SteamInventorySystem_HandleConsumeCoinsRequest
    // {
    //     public static bool Prefix(SteamInventorySystem __instance, ref GameContext ___context,
    //         ref IEnumerable<Inventory.Item> ___CoinItems, ref Client ___SteamClient, List<GameEntity> entities)
    //     {
    //         // MelonLogger.Msg(
    //         //     "SteamInventorySystem.HandleConsumeCoinsRequest was called: Disabling SteamInventorySystem.HandleConsumeCoinsRequest.");
    //
    //         var steamConsumeCoinsRequest = entities.SingleEntity().steamConsumeCoinsRequest;
    //         var num = steamConsumeCoinsRequest.value;
    //         foreach (var item in ___CoinItems)
    //         {
    //             var quantity = item.Quantity;
    //             var num2 = Math.Min(quantity, num);
    //             ___SteamClient.Inventory.ConsumeItem(new Inventory.Item.Amount
    //             {
    //                 Item = item,
    //                 Quantity = num2
    //             });
    //             num -= num2;
    //             if (num == 0) break;
    //         }
    //
    //         ___context.steamClientEntity.ReplaceSteamCoins(___context.steamClientEntity.steamCoins.value + num);
    //         entities.SingleEntity().RemoveSteamConsumeCoinsRequest();
    //
    //         return false;
    //     }
    // }
}