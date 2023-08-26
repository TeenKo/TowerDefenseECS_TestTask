//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly _Core_.GameManager.Components.DefeatStateComponent defeatStateComponent = new _Core_.GameManager.Components.DefeatStateComponent();

    public bool isDefeatState {
        get { return HasComponent(GameComponentsLookup.DefeatState); }
        set {
            if (value != isDefeatState) {
                var index = GameComponentsLookup.DefeatState;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : defeatStateComponent;

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

    static Entitas.IMatcher<GameEntity> _matcherDefeatState;

    public static Entitas.IMatcher<GameEntity> DefeatState {
        get {
            if (_matcherDefeatState == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.DefeatState);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherDefeatState = matcher;
            }

            return _matcherDefeatState;
        }
    }
}
