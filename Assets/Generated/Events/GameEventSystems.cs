//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventSystemsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed class GameEventSystems : Feature {

    public GameEventSystems(Contexts contexts) {
        Add(new AttackDistanceEventSystem(contexts)); // priority: 0
        Add(new AttackStateEventSystem(contexts)); // priority: 0
        Add(new AnyCurrencyEventSystem(contexts)); // priority: 0
        Add(new DeathStateEventSystem(contexts)); // priority: 0
        Add(new AnyDefeatStateEventSystem(contexts)); // priority: 0
        Add(new HealthEventSystem(contexts)); // priority: 0
        Add(new IdleStateEventSystem(contexts)); // priority: 0
        Add(new LevelEventSystem(contexts)); // priority: 0
        Add(new LevelMultiplyEventSystem(contexts)); // priority: 0
        Add(new MaxHealthEventSystem(contexts)); // priority: 0
        Add(new MoveStateEventSystem(contexts)); // priority: 0
        Add(new PriceEventSystem(contexts)); // priority: 0
        Add(new SearchAttackTargetStateEventSystem(contexts)); // priority: 0
        Add(new TakeDamageEventSystem(contexts)); // priority: 0
        Add(new AnyTotalDeathEnemyEventSystem(contexts)); // priority: 0
        Add(new AnyWaveEventSystem(contexts)); // priority: 0
    }
}
