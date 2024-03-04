using HarmonyLib;

namespace TRHook.Hook
{
    // using System;
    //
    // // Token: 0x02000075 RID: 117
    // public partial class FeatureBuilder
    // {
    //     // Token: 0x0600024C RID: 588 RVA: 0x00007880 File Offset: 0x00005C80
    //     public static FeatureBuilder Create(string id, long maxLevel, IPrice featurePrice)
    //     {
    //         return new FeatureBuilder
    //         {
    //             _id = id,
    //             _maxLevel = maxLevel,
    //             _price = featurePrice
    //         };
    //     }
    // }

    [HarmonyPatch(typeof(FeatureBuilder), "Create")]
    public class FeatureBuilder_Create
    {
        public static bool Prefix(string id, long maxLevel, ref IPrice featurePrice)
        {
            if (featurePrice is LPrice || featurePrice is CPrice || featurePrice is SLPrice || featurePrice is EPrice)
                featurePrice = new LPrice(1);
            return true;
        }
    }
}