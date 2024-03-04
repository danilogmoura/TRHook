using HarmonyLib;

namespace TRHook.Hook
{
    // using System;
    // using System.Collections.Generic;
    // using Entitas;
    // using Entitas.Unity;
    // using Facepunch.Steamworks;
    // using UnityEngine;
    //
    // // Token: 0x020000C1 RID: 193
    // public sealed partial class GameEntity : Entity
    // {
    //     // Token: 0x060006DC RID: 1756 RVA: 0x000143F4 File Offset: 0x000127F4
    //     public void AddHp(BigNum newCurrent, BigNum newMax)
    //     {
    //         HpComponent hpComponent = base.CreateComponent<HpComponent>(104);
    //         hpComponent.current = newCurrent;
    //         hpComponent.max = newMax;
    //         base.AddComponent(104, hpComponent);
    //     }
    // }

    [HarmonyPatch(typeof(GameEntity), "AddHp")]
    public class GameEntity_AddHp
    {
        public static bool Prefix(ref BigNum newCurrent, ref BigNum newMax)
        {
            newCurrent = new BigNum(1);
            return true;
        }
    }

    // using System;
    // using System.Collections.Generic;
    // using Entitas;
    // using Entitas.Unity;
    // using Facepunch.Steamworks;
    // using UnityEngine;
    //
    // // Token: 0x020000C1 RID: 193
    // public sealed partial class GameEntity : Entity
    // {
    //     // Token: 0x060007DC RID: 2012 RVA: 0x00015F2C File Offset: 0x0001432C
    //     public void AddSteamCoins(int newValue)
    //     {
    //         SteamCoinsComponent steamCoinsComponent = base.CreateComponent<SteamCoinsComponent>(160);
    //         steamCoinsComponent.value = newValue;
    //         base.AddComponent(160, steamCoinsComponent);
    //     }
    // }

    // [HarmonyPatch(typeof(GameEntity), "AddSteamCoins")]
    // public class GameEntity_AddSteamCoins
    // {
    //     public static bool Prefix(ref int newValue)
    //     {
    //         newValue = 50;
    //         return true;
    //     }
    // }

    // using System;
    // using System.Collections.Generic;
    // using Entitas;
    // using Entitas.Unity;
    // using Facepunch.Steamworks;
    // using UnityEngine;
    //
    // // Token: 0x020000C1 RID: 193
    // public sealed partial class GameEntity : Entity
    // {
    // 	// Token: 0x060007E1 RID: 2017 RVA: 0x00015FB0 File Offset: 0x000143B0
    // 	public void AddSteamConsumeCoinsRequest(int newValue)
    // 	{
    // 		SteamConsumeCoinsRequestComponent steamConsumeCoinsRequestComponent = base.CreateComponent<SteamConsumeCoinsRequestComponent>(161);
    // 		steamConsumeCoinsRequestComponent.value = newValue;
    // 		base.AddComponent(161, steamConsumeCoinsRequestComponent);
    // 	}
    // }

    [HarmonyPatch(typeof(GameEntity), "AddSteamConsumeCoinsRequest")]
    public class GameEntity_AddSteamConsumeCoinsRequest
    {
        public static bool Prefix(ref int newValue)
        {
            newValue = 0;
            return true;
        }
    }

    // using System;
    // using System.Collections.Generic;
    // using Entitas;
    // using Entitas.Unity;
    // using Facepunch.Steamworks;
    // using UnityEngine;
    //
    // // Token: 0x020000C1 RID: 193
    // public sealed partial class GameEntity : Entity
    // {
    //     // Token: 0x0600069F RID: 1695 RVA: 0x00013DF8 File Offset: 0x000121F8
    //     public void AddFeature(string newId, long newMaxLevel, IPrice newPrice, FeatureStatMod newStatMod)
    //     {
    //         FeatureComponent featureComponent = base.CreateComponent<FeatureComponent>(89);
    //         featureComponent.id = newId;
    //         featureComponent.maxLevel = newMaxLevel;
    //         featureComponent.price = newPrice;
    //         featureComponent.statMod = newStatMod;
    //         base.AddComponent(89, featureComponent);
    //     }
    // }

    // [HarmonyPatch(typeof(GameEntity), "AddFeature", typeof(string), typeof(long), typeof(IPrice),
    //     typeof(FeatureStatMod))]
    // public class GameEntity_AddFeature
    // {
    //     public static bool Prefix(GameEntity __instance, string newId, long newMaxLevel, IPrice newPrice,
    //         FeatureStatMod newStatMod)
    //     {
    //         newPrice = new CPrice(1);
    //         return true;
    //     }
    // }
}