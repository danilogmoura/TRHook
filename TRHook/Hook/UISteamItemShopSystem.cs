namespace TRHook.Hook
{
    // [HarmonyPatch(typeof(UISteamItemShopSystem), "Initialize")]
    // public class UISteamItemShopSystem_Initialize
    // {
    //     // private const string StoreUrlFormat = "http://store.steampowered.com/itemstore/{0}";
    //     // private const int GameStoreId = 685310;
    //
    //     public static void Posfix(UISteamItemShopSystem __instance)
    //     {
    //         var traverseInstance = Traverse.Create(__instance);
    //         var _items = traverseInstance.Field("_items").GetValue<List<ShopItem>>();
    // var _view = traverseInstance.Field("_view").GetValue<IUISteamShop>();
    // var _context = traverseInstance.Field("_context").GetValue<GameContext>();

    // _items = new List<ShopItem>
    // {
    //     new SkipTimeShopItem
    //     {
    //         HoursToSkip = 1,
    //         TitleTag = "skip_hour",
    //         Price = 1
    //     },
    //     new SkipTimeShopItem
    //     {
    //         HoursToSkip = 24,
    //         TitleTag = "skip_day",
    //         Price = 1
    //     },
    //     new SkipTimeShopItem
    //     {
    //         HoursToSkip = 168,
    //         TitleTag = "skip_week",
    //         Price = 1
    //     },
    //     new SkipTimeShopItem
    //     {
    //         HoursToSkip = 744,
    //         TitleTag = "skip_month",
    //         Price = 1
    //     },
    //     new StatBonusShopItem
    //     {
    //         Price = 1,
    //         Stat = Stat.LockedCargoReward,
    //         ValuePerItem = 0.2,
    //         SteamItemId = 100,
    //         TitleTag = "more_cargo"
    //     },
    //     new StatExponentialBonusShopItem
    //     {
    //         Price = 1,
    //         Stat = Stat.Damage,
    //         ValuePerItem = 19,
    //         SteamItemId = 102,
    //         TitleTag = "more_damage"
    //     },
    //     new StatExponentialBonusShopItem
    //     {
    //         Price = 1,
    //         Stat = Stat.MoneyReward,
    //         ValuePerItem = 9,
    //         SteamItemId = 101,
    //         TitleTag = "more_money"
    //     },
    //     new StatBonusShopItem
    //     {
    //         Price = 1,
    //         Stat = Stat.MissionWPReward,
    //         ValuePerItem = 0.2,
    //         SteamItemId = 103,
    //         TitleTag = "more_wp"
    //     },
    //     new FreePortalShopItem
    //     {
    //         TitleTag = "free_portal",
    //         Price = 1
    //     },
    //     new ResetSentinelShopItem
    //     {
    //         TitleTag = "reset_sentinel",
    //         Price = 1
    //     }
    // };

    // _view.Coins = 0;

    // MelonLogger.Msg("teste");
    // var buyWithConfirmationMethod = traverseInstance.Method("BuyWithConfirmation");
    // foreach (var shopItem in _items)
    // {
    //     MelonLogger.Msg(shopItem.TitleTag + " " + shopItem.Price);

    // var buyWithConfirmationDelegate = buyWithConfirmationMethod.GetValue<Action<ShopItem>>();
    // _view.CreateItem(shopItem.TitleTag, shopItem.Price, () => buyWithConfirmationDelegate(shopItem));
    // }

    // _view.SetItemStoreHandler(() =>
    // {
    // var url = string.Format(StoreUrlFormat, GameStoreId);
    // _context.steamClient.value.Overlay.OpenUrl(url);
    // });

    //     }
    // }
}