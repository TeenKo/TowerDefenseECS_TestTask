//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameContext {

    public GameEntity waveManagerEntity { get { return GetGroup(GameMatcher.WaveManager).GetSingleEntity(); } }

    public bool isWaveManager {
        get { return waveManagerEntity != null; }
        set {
            var entity = waveManagerEntity;
            if (value != (entity != null)) {
                if (value) {
                    CreateEntity().isWaveManager = true;
                } else {
                    entity.Destroy();
                }
            }
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly _Core_.WaveManager.Components.WaveManagerComponent waveManagerComponent = new _Core_.WaveManager.Components.WaveManagerComponent();

    public bool isWaveManager {
        get { return HasComponent(GameComponentsLookup.WaveManager); }
        set {
            if (value != isWaveManager) {
                var index = GameComponentsLookup.WaveManager;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : waveManagerComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
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

    static Entitas.IMatcher<GameEntity> _matcherWaveManager;

    public static Entitas.IMatcher<GameEntity> WaveManager {
        get {
            if (_matcherWaveManager == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.WaveManager);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherWaveManager = matcher;
            }

            return _matcherWaveManager;
        }
    }
}
