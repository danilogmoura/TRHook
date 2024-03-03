using System;
using System.Collections.Generic;
using HarmonyLib;

namespace TRHook.Hook
{
    // using System;
    // using System.Collections.Generic;
    // using Entitas;
    //
    // // Token: 0x020002CD RID: 717
    // public sealed partial class FeatureUpgradeDataSystem : GameReactiveSystemWithInterval
    // {
    //     // Token: 0x06000E52 RID: 3666 RVA: 0x000257A4 File Offset: 0x00023BA4
    //     protected override void Execute(List<GameEntity> entities)
    //     {
    //         foreach (GameEntity gameEntity in entities)
    //         {
    //             long num = this._context.RightBuyMult();
    //             long num2 = num - (gameEntity.level.value + num) % num;
    //             num2 = Math.Min(num2, gameEntity.maxLevel.value - gameEntity.level.value);
    //             gameEntity.ReplaceUpgradeData(num2, gameEntity.GetFeatureUpgradePrice(num2) * (double)this._context.GetPlayerStat(Stat.SentinelFeaturePricePct).ToFloat() / 100);
    //         }
    //     }
    // }

    [HarmonyPatch(typeof(FeatureUpgradeDataSystem), "Execute", typeof(List<GameEntity>))]
    public class FeatureUpgradeDataSystem_Execute
    {
        public static bool Prefix(FeatureUpgradeDataSystem __instance, List<GameEntity> entities)
        {
            foreach (var gameEntity in entities)
            {
                var traverse = Traverse.Create(__instance).Field("_context");
                var _context = traverse.GetValue<GameContext>();

                // TODO: log com o valor de _context
                var num = _context.RightBuyMult();
                var num2 = num - (gameEntity.level.value + num) % num;
                num2 = Math.Min(num2, gameEntity.maxLevel.value - gameEntity.level.value);

                gameEntity.ReplaceUpgradeData(num2, gameEntity.level.value + 1);
            }

            return false;
        }
    }
}