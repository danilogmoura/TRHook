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
    //     // Token: 0x060007A0 RID: 1952 RVA: 0x0001587C File Offset: 0x00013C7C
    //     public void AddSentinelPassiveModule(string newId, long newRequiredSentinelLevel, SentinelStatMod newStatMod, ISentinelPrice newPrice, long newMaxLevel)
    //     {
    //         SentinelPassiveModuleComponent sentinelPassiveModuleComponent = base.CreateComponent<SentinelPassiveModuleComponent>(148);
    //         sentinelPassiveModuleComponent.id = newId;
    //         sentinelPassiveModuleComponent.requiredSentinelLevel = newRequiredSentinelLevel;
    //         sentinelPassiveModuleComponent.statMod = newStatMod;
    //         sentinelPassiveModuleComponent.price = newPrice;
    //         sentinelPassiveModuleComponent.maxLevel = newMaxLevel;
    //         base.AddComponent(148, sentinelPassiveModuleComponent);
    //     }
    // }

    [HarmonyPatch(typeof(GameEntity), "AddSentinelPassiveModule", typeof(string), typeof(long), typeof(SentinelStatMod),
        typeof(ISentinelPrice), typeof(long))]
    public class GameEntity_AddSentinelPassiveModule
    {
        public static bool Prefix(string newId, long newRequiredSentinelLevel, SentinelStatMod newStatMod,
            ref ISentinelPrice newPrice, long newMaxLevel)
        {
            if (newPrice is CSentinelPrice) newPrice = new CSentinelPrice(1L);

            return true;
        }
    }
}