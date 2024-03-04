using HarmonyLib;

namespace TRHook.Hook
{
    // using System;
    //
    // // Token: 0x020000BA RID: 186
    // public static partial class ResourcesExtensions
    // {
    //     // Token: 0x06000500 RID: 1280 RVA: 0x0000FD61 File Offset: 0x0000E161
    //     public static bool BuyForCargo(this GameContext context, BigNum price)
    //     {
    //         if (context.HasEnoughCargo(price))
    //         {
    //             context.AddCargo(-price, false);
    //             return true;
    //         }
    //         return false;
    //     }
    // }

    // [HarmonyPatch(typeof(ComponentExtensions), "BuyForCargo", typeof(GameContext), typeof(BigNum))]
    // public class ResourcesExtensions_BuyForCargo
    // {
    //     public static bool Pretfix(ref BigNum price)
    //     {
    //         price = new BigNum(1);
    //         return true;
    //     }
    // }
    // // Token: 0x020000BA RID: 186
    // public static partial class ResourcesExtensions
    // {
    //     // Token: 0x060004E9 RID: 1257 RVA: 0x0000F9ED File Offset: 0x0000DDED
    //     public static BigNum GetCargo(this GameContext context)
    //     {
    //         return context.GetResourceValue(ResourceType.Cargo);
    //     }
    // }    

    // [HarmonyPatch(typeof(ResourcesExtensions), "GetCargo", typeof(GameContext), typeof(BigNum))]
    // public class ResourcesExtensions_GetCargo
    // {
    //     public static bool Pretfix(BigNum __result, GameContext context)
    //     {
    //         var getResourceValueMethod = Traverse.Create(__instance)
    //             .Method("GetResourceValue", typeof(GameContext), typeof(ResourceType))
    //             .GetValue<BigNum>();
    //         
    //         __result = () =>context.GetResourceValueMethod(ResourceType.Cargo);
    //         return true;
    //     }
    // }

    // using System;
    // using UnityEngine;
    //
    // // Token: 0x020000BA RID: 186
    // public static partial class ResourcesExtensions
    // {
    //     // Token: 0x060004F7 RID: 1271 RVA: 0x0000FBE0 File Offset: 0x0000DFE0
    //     public static BigNum AddLockedCargoFromGenerator(this GameContext context, BigNum lockedCargo)
    //     {
    //         BigNum maxGeneratedCargoPerTransfer = context.GetMaxGeneratedCargoPerTransfer();
    //         BigNum lockedCargoFromGenerator = context.GetLockedCargoFromGenerator();
    //         BigNum bigNum = BigNum.Min(maxGeneratedCargoPerTransfer, lockedCargoFromGenerator + lockedCargo);
    //         if (bigNum != lockedCargoFromGenerator)
    //         {
    //             context.GetResource(ResourceType.LockedCargoFromGenerator).ReplaceResourceValue(bigNum);
    //             BigNum bigNum2 = BigNum.Max(0, bigNum - lockedCargoFromGenerator);
    //             context.GetCounter(CounterType.CargoGained).IncCounter(bigNum2);
    //             CounterType.PerSentinelLockedCargoGenerated.IncCounter(bigNum2);
    //             Contexts.sharedInstance.ui.CreateEntity().AddLogEntry("log_entry_cargo_generator".ToLocalized(new object[] { bigNum2 }));
    //             context.CreateEntity().AddFloatingReward(bigNum2, Vector3.zero + Rand.Vector3(20f, 20f), ResourceType.LockedCargoFromGenerator);
    //             return bigNum2;
    //         }
    //         return 0;
    //     }
    // }

    // [HarmonyPatch(typeof(ResourcesExtensions), "AddLockedCargoFromGenerator", typeof(GameContext), typeof(BigNum))]
    // public class ResourcesExtensions_AddLockedCargoFromGenerator
    // {
    //     public static bool Prefix(BigNum __result, GameContext context, BigNum lockedCargo)
    //     {
    //         var maxGeneratedCargoPerTransfer = context.GetMaxGeneratedCargoPerTransfer();
    //         var lockedCargoFromGenerator = context.GetLockedCargoFromGenerator();
    //         var bigNum = BigNum.Min(maxGeneratedCargoPerTransfer, lockedCargoFromGenerator + lockedCargo);
    //         if (bigNum != lockedCargoFromGenerator)
    //         {
    //             context.GetResource(ResourceType.LockedCargoFromGenerator).ReplaceResourceValue(bigNum);
    //             var bigNum2 = BigNum.Max(0, bigNum - lockedCargoFromGenerator);
    //             context.GetCounter(CounterType.CargoGained).IncCounter(bigNum2);
    //             CounterType.PerSentinelLockedCargoGenerated.IncCounter(bigNum2);
    //             Contexts.sharedInstance.ui.CreateEntity().AddLogEntry("log_entry_cargo_generator".ToLocalized(bigNum2));
    //             context.CreateEntity().AddFloatingReward(bigNum2, Vector3.zero + Rand.Vector3(20f, 20f),
    //                 ResourceType.LockedCargoFromGenerator);
    //             __result = bigNum2;
    //
    //             MelonLogger.Msg(bigNum2);
    //             return false;
    //         }
    //
    //         __result = 0;
    //         return false;
    //     }
    // }

    // using System;
    //
    // // Token: 0x020000BA RID: 186
    // public static partial class ResourcesExtensions
    // {
    //     // Token: 0x060004F5 RID: 1269 RVA: 0x0000FB96 File Offset: 0x0000DF96
    //     public static BigNum AddCargo(this GameContext context, BigNum cargo, bool withLCargoToCargoBonus)
    //     {
    //         if (cargo > 0 && withLCargoToCargoBonus)
    //         {
    //             cargo *= context.LCargoToCargoMult();
    //         }
    //         context.IncResourceValue(ResourceType.Cargo, cargo);
    //         return cargo;
    //     }
    // }    

    // [HarmonyPatch(typeof(ResourcesExtensions), "AddCargo")]
    // public class ResourcesExtensions_AddCargo
    // {
    //     public static bool Prefix(GameContext context, ref BigNum cargo, bool withLCargoToCargoBonus)
    //     {
    //         cargo *= 10;
    //         return true;
    //     }
    // }
}