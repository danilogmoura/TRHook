namespace TRHook.Hook
{
    // [HarmonyPatch(typeof(DamageSystem), "Execute")]
    // public class DamageSystem_Execute
    // {
    //     public static void Prefix(List<GameEntity> __0)
    //     {
    //         foreach (var gameEntity in __0)
    //         {
    //             var bigNum = new BigNum(-1);
    //             gameEntity.ReplaceHp(bigNum, gameEntity.hp.max);
    //             if (bigNum <= 0) gameEntity.isKilled = true;
    //             gameEntity.RemoveReceivedDamage();
    //         }
    //     }
    // }
}