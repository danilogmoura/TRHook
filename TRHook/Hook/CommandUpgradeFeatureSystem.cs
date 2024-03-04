using System;
using HarmonyLib;
using MelonLoader;

namespace TRHook.Hook
{
    // using System;
    //
    // // Token: 0x02000292 RID: 658
    // public partial class CommandUpgradeFeatureSystem : CommandReactiveSystem<CommandUpgradeFeatureComponent>
    // {
    // 	// Token: 0x06000CF1 RID: 3313 RVA: 0x0001F05C File Offset: 0x0001D45C
    // 	protected override void ExecuteCommand(CommandUpgradeFeatureComponent commandComponent)
    // 	{
    // 		GameEntity featureEntity = this._context.GetFeature(commandComponent.featureId);
    // 		if (!featureEntity.isUnlocked)
    // 		{
    // 			return;
    // 		}
    // 		if (featureEntity.level.value == featureEntity.maxLevel.value)
    // 		{
    // 			return;
    // 		}
    // 		float featurePriceDecrease = this._context.GetPlayerStat(Stat.SentinelFeaturePricePct).ToFloat() / 100f;
    // 		long num = commandComponent.levels;
    // 		if (commandComponent.isPercent)
    // 		{
    // 			long maxAvailable = MathHelpers.GetMaxAvailable(Math.Max(0L, featureEntity.maxLevel.value - featureEntity.level.value), (long l) => this._context.HasEnoughCargo(featureEntity.GetFeatureUpgradePrice(l) * (double)featurePriceDecrease), 250);
    // 			num = (long)((float)(maxAvailable * num) / 100f);
    // 		}
    // 		long newLevel = Math.Min(featureEntity.maxLevel.value, featureEntity.level.value + num);
    // 		HashLong hashLong = newLevel - featureEntity.level.value;
    // 		BigNum price = featureEntity.GetFeatureUpgradePrice(hashLong) * (double)featurePriceDecrease;
    // 		if (this._context.GetFeatureUpgradeDiscountChance().IsRolled())
    // 		{
    // 			price *= (double)(1f - this._context.GetFeatureUpgradeDiscountPercent());
    // 		}
    // 		Action action = delegate
    // 		{
    // 			if (!this._context.BuyForCargo(price))
    // 			{
    // 				return;
    // 			}
    // 			featureEntity.ReplaceLevel(newLevel);
    // 			this._context.IncCargoSpent(price);
    // 		};
    // 		if (featureEntity.feature.statMod.Stat == Stat.StartingSector && this._context.GetPlayerStat(Stat.FunnyJHGConfirmation).ToBool())
    // 		{
    // 			this._confirmDialog.Show("funny_jhg_confirmation".ToLocalized(), action, null);
    // 		}
    // 		else if (featureEntity.feature.statMod.Stat == Stat.OnlyHTShooting)
    // 		{
    // 			this._confirmDialog.Show("only_ht_shooting_confirmation".ToLocalized(), action, null);
    // 		}
    // 		else
    // 		{
    // 			action();
    // 		}
    // 	}
    // }

    // [HarmonyPatch(typeof(CommandUpgradeFeatureSystem), "ExecuteCommand", typeof(CommandUpgradeFeatureComponent))]
    // public class CommandUpgradeFeatureSystem_CommandUpgradeFeatureComponent
    // {
    //     
    //     private static int count = 0;
    //     
    //     public static bool Prefix(CommandUpgradeFeatureSystem __instance,
    //         CommandUpgradeFeatureComponent commandComponent)
    //     {
    //         var traverse_context = Traverse.Create(__instance).Field("_context");
    //         var _context = traverse_context.GetValue<GameContext>();
    //
    //         var confirmDialog_context = Traverse.Create(__instance).Field("_confirmDialog");
    //         var _confirmDialog = confirmDialog_context.GetValue<IUIConfirmDialog>();
    //
    //         var featureEntity = _context.GetFeature(commandComponent.featureId);
    //         if (!featureEntity.isUnlocked) return true;
    //         if (featureEntity.level.value == featureEntity.maxLevel.value) return true;
    //         var num = commandComponent.levels;
    //
    //         var newLevel = Math.Min(featureEntity.maxLevel.value, featureEntity.level.value + num);
    //         var price = featureEntity.level.value + 1;
    //
    //
    //         var teste = "Fora";
    //         count++;
    //
    //         Action action = delegate
    //         {
    //             if (!_context.BuyForCargo(price)) return;
    //             featureEntity.ReplaceLevel(newLevel);
    //             _context.IncCargoSpent(price);
    //
    //             MelonLogger.Msg(price.GetValue() + " " + newLevel + " " + teste+ "  count" + count);
    //         };
    //
    //         if (featureEntity.feature.statMod.Stat == Stat.StartingSector &&
    //             _context.GetPlayerStat(Stat.FunnyJHGConfirmation).ToBool())
    //         {
    //             _confirmDialog.Show("funny_jhg_confirmation".ToLocalized(), action);
    //         }
    //         else if (featureEntity.feature.statMod.Stat == Stat.OnlyHTShooting)
    //         {
    //             _confirmDialog.Show("only_ht_shooting_confirmation".ToLocalized(), action);
    //         }
    //         else
    //         {
    //             teste = "else";
    //             action();
    //         }
    //
    //         return false;
    //     }
    // }
}