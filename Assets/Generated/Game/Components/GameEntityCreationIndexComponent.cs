//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public _Core_.Common.Components.EntityCreationIndexComponent entityCreationIndex { get { return (_Core_.Common.Components.EntityCreationIndexComponent)GetComponent(GameComponentsLookup.EntityCreationIndex); } }
    public bool hasEntityCreationIndex { get { return HasComponent(GameComponentsLookup.EntityCreationIndex); } }

    public void AddEntityCreationIndex(int newValue) {
        var index = GameComponentsLookup.EntityCreationIndex;
        var component = (_Core_.Common.Components.EntityCreationIndexComponent)CreateComponent(index, typeof(_Core_.Common.Components.EntityCreationIndexComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceEntityCreationIndex(int newValue) {
        var index = GameComponentsLookup.EntityCreationIndex;
        var component = (_Core_.Common.Components.EntityCreationIndexComponent)CreateComponent(index, typeof(_Core_.Common.Components.EntityCreationIndexComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveEntityCreationIndex() {
        RemoveComponent(GameComponentsLookup.EntityCreationIndex);
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

    static Entitas.IMatcher<GameEntity> _matcherEntityCreationIndex;

    public static Entitas.IMatcher<GameEntity> EntityCreationIndex {
        get {
            if (_matcherEntityCreationIndex == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EntityCreationIndex);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEntityCreationIndex = matcher;
            }

            return _matcherEntityCreationIndex;
        }
    }
}
