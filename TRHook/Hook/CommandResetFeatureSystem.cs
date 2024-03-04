using HarmonyLib;

namespace TRHook.Hook
{
    // using System;
    //
    // // Token: 0x02000286 RID: 646
    // public partial class CommandResetFeatureSystem : CommandReactiveSystem<CommandResetFeatureComponent>
    // {
    //     // Token: 0x06000CD0 RID: 3280 RVA: 0x0001D394 File Offset: 0x0001B794
    //     protected override void ExecuteCommand(CommandResetFeatureComponent commandComponent)
    //     {
    //         GameEntity feature = this._context.GetFeature(commandComponent.featureId);
    //         if (!feature.isUnlocked || feature.level.value == 0L)
    //         {
    //             return;
    //         }
    //         BigNum sellPrice = this._context.GetFeatureSellPrice(feature);
    //         this._dialog.Show(this.GetConfirmMessage(feature, sellPrice), delegate
    //         {
    //             feature.ReplaceLevel(0L);
    //             this._context.AddCargo(sellPrice, false);
    //             CounterType.CargoSpent.IncCounter(-sellPrice * this._context.GetPlayerStat(Stat.CargoSpentIncreasePct) / 100);
    //         }, null);
    //     }
    // }

    // [HarmonyPatch(typeof(CommandResetFeatureSystem), "ExecuteCommand")]
    // public class CommandResetFeatureSystem_ExecuteCommand
    // {
    //     public static bool Prefix(CommandResetFeatureSystem __instance, CommandResetFeatureComponent commandComponent)
    //     {
    //         var traverseInstance = Traverse.Create(__instance);
    //         var _context = traverseInstance.Field("_context").GetValue<GameContext>();
    //
    //
    //         var feature = _context.GetFeature(commandComponent.featureId);
    //         if (!feature.isUnlocked || feature.level.value == 0L) return false;
    //
    //         var sellPrice = _context.GetFeatureSellPrice(feature);
    //         var _dialog = traverseInstance.Field("_dialog").GetValue<IUIConfirmDialog>();
    //
    //         var getConfirmMessageMethod = traverseInstance
    //             .Method("GetConfirmMessage", typeof(GameEntity), typeof(BigNum))
    //             .GetValue<string>();
    //
    //         _dialog.Show(() => getConfirmMessageMethod(feature, sellPrice), delegate
    //         {
    //             feature.ReplaceLevel(0L);
    //             _context.AddCargo(sellPrice, false);
    //             CounterType.CargoSpent.IncCounter(-sellPrice * _context.GetPlayerStat(Stat.CargoSpentIncreasePct) /
    //                                               100);
    //         });
    //         return false;
    //     }
    // }
}