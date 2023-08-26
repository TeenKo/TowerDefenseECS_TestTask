//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public _Core_.Common.Components.IndexComponent index { get { return (_Core_.Common.Components.IndexComponent)GetComponent(GameComponentsLookup.Index); } }
    public bool hasIndex { get { return HasComponent(GameComponentsLookup.Index); } }

    public void AddIndex(int newValue) {
        var index = GameComponentsLookup.Index;
        var component = (_Core_.Common.Components.IndexComponent)CreateComponent(index, typeof(_Core_.Common.Components.IndexComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceIndex(int newValue) {
        var index = GameComponentsLookup.Index;
        var component = (_Core_.Common.Components.IndexComponent)CreateComponent(index, typeof(_Core_.Common.Components.IndexComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveIndex() {
        RemoveComponent(GameComponentsLookup.Index);
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

    static Entitas.IMatcher<GameEntity> _matcherIndex;

    public static Entitas.IMatcher<GameEntity> Index {
        get {
            if (_matcherIndex == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Index);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherIndex = matcher;
            }

            return _matcherIndex;
        }
    }
}