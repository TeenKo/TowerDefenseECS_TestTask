//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public _Core_.EnemySpawner.Components.SpawnTickTimerComponent spawnTickTimer { get { return (_Core_.EnemySpawner.Components.SpawnTickTimerComponent)GetComponent(GameComponentsLookup.SpawnTickTimer); } }
    public bool hasSpawnTickTimer { get { return HasComponent(GameComponentsLookup.SpawnTickTimer); } }

    public void AddSpawnTickTimer(float newValue) {
        var index = GameComponentsLookup.SpawnTickTimer;
        var component = (_Core_.EnemySpawner.Components.SpawnTickTimerComponent)CreateComponent(index, typeof(_Core_.EnemySpawner.Components.SpawnTickTimerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceSpawnTickTimer(float newValue) {
        var index = GameComponentsLookup.SpawnTickTimer;
        var component = (_Core_.EnemySpawner.Components.SpawnTickTimerComponent)CreateComponent(index, typeof(_Core_.EnemySpawner.Components.SpawnTickTimerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveSpawnTickTimer() {
        RemoveComponent(GameComponentsLookup.SpawnTickTimer);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherSpawnTickTimer;

    public static Entitas.IMatcher<GameEntity> SpawnTickTimer {
        get {
            if (_matcherSpawnTickTimer == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.SpawnTickTimer);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherSpawnTickTimer = matcher;
            }

            return _matcherSpawnTickTimer;
        }
    }
}
