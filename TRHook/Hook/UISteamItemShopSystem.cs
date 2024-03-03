namespace TRHook.Hook
{
    // [HarmonyPatch(typeof(UISteamItemShopSystem), "Initialize")]
    // public class UISteamItemShopSystem
    // {
    //     public static bool Prefix(UISteamItemShopSystem __instance, ref List<ShopItem> __items, ref IUISteamShop __view,
    //         GameContext context)
    //     {
    //         var newPrice = 1;
    //         __items = new List<ShopItem>
    //         {
    //             new SkipTimeShopItem
    //             {
    //                 HoursToSkip = 1,
    //                 TitleTag = "skip_hour",
    //                 Price = newPrice
    //             },
    //             new SkipTimeShopItem
    //             {
    //                 HoursToSkip = 24,
    //                 TitleTag = "skip_day",
    //                 Price = newPrice
    //             },
    //             new SkipTimeShopItem
    //             {
    //                 HoursToSkip = 168,
    //                 TitleTag = "skip_week",
    //                 Price = newPrice
    //             },
    //             new SkipTimeShopItem
    //             {
    //                 HoursToSkip = 744,
    //                 TitleTag = "skip_month",
    //                 Price = newPrice
    //             },
    //             new StatBonusShopItem
    //             {
    //                 Price = newPrice,
    //                 Stat = Stat.LockedCargoReward,
    //                 ValuePerItem = 0.2,
    //                 SteamItemId = 100,
    //                 TitleTag = "more_cargo"
    //             },
    //             new StatExponentialBonusShopItem
    //             {
    //                 Price = newPrice,
    //                 Stat = Stat.Damage,
    //                 ValuePerItem = 19,
    //                 SteamItemId = 102,
    //                 TitleTag = "more_damage"
    //             },
    //             new StatExponentialBonusShopItem
    //             {
    //                 Price = newPrice,
    //                 Stat = Stat.MoneyReward,
    //                 ValuePerItem = 9,
    //                 SteamItemId = 101,
    //                 TitleTag = "more_money"
    //             },
    //             new StatBonusShopItem
    //             {
    //                 Price = newPrice,
    //                 Stat = Stat.MissionWPReward,
    //                 ValuePerItem = 0.2,
    //                 SteamItemId = 103,
    //                 TitleTag = "more_wp"
    //             },
    //             new FreePortalShopItem
    //             {
    //                 TitleTag = "free_portal",
    //                 Price = newPrice
    //             },
    //             new ResetSentinelShopItem
    //             {
    //                 TitleTag = "reset_sentinel",
    //                 Price = 10
    //             }
    //         };
    //         __view.Coins = 0;
    //         foreach (var shopItem in __items)
    //         {
    //             var methodInfo = AccessTools.Method(typeof(UISteamItemShopSystem), "BuyWithConfirmation");
    //             __view.CreateItem(shopItem.TitleTag, shopItem.Price,
    //                 (Action)methodInfo.Invoke(__instance, new object[] { shopItem }));
    //         }
    //
    //         __view.SetItemStoreHandler(delegate
    //         {
    //             context.steamClient.value.Overlay.OpenUrl(
    //                 string.Format("http://store.steampowered.com/itemstore/{0}", 685310));
    //         });
    //         return false;
    //     }
    // }
}