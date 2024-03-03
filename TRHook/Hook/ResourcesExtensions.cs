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
}