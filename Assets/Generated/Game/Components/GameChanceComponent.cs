//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public _Core_.ChangeCurrency.Components.ChanceComponent chance { get { return (_Core_.ChangeCurrency.Components.ChanceComponent)GetComponent(GameComponentsLookup.Chance); } }
    public bool hasChance { get { return HasComponent(GameComponentsLookup.Chance); } }

    public void AddChance(int newValue) {
        var index = GameComponentsLookup.Chance;
        var component = (_Core_.ChangeCurrency.Components.ChanceComponent)CreateComponent(index, typeof(_Core_.ChangeCurrency.Components.ChanceComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceChance(int newValue) {
        var index = GameComponentsLookup.Chance;
        var component = (_Core_.ChangeCurrency.Components.ChanceComponent)CreateComponent(index, typeof(_Core_.ChangeCurrency.Components.ChanceComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveChance() {
        RemoveComponent(GameComponentsLookup.Chance);
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

    static Entitas.IMatcher<GameEntity> _matcherChance;

    public static Entitas.IMatcher<GameEntity> Chance {
        get {
            if (_matcherChance == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Chance);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherChance = matcher;
            }

            return _matcherChance;
        }
    }
}
