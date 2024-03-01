namespace TRHook.Hook
{
    // [HarmonyPatch(typeof(GameEntity), "AddAbility")]
    // public class InitAbilitySystem_CreateAdrenalineRush
    // {
    //     public static bool Prefix(GameEntity __instance, AbilityType __0, float __1, long __2)
    //     {
    //         var abilityComponent = __instance.CreateComponent<AbilityComponent>(1);
    //         abilityComponent.type = __0;
    //         abilityComponent.cooldown = 1f;
    //         abilityComponent.unlockSector = __2;
    //         __instance.ReplaceComponent(1, abilityComponent);
    //
    //         return false;
    //     }
    // }
}