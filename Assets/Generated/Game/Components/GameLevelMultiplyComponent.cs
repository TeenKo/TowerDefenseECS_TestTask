//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public _Core_.Common.Components.LevelMultiplyComponent levelMultiply { get { return (_Core_.Common.Components.LevelMultiplyComponent)GetComponent(GameComponentsLookup.LevelMultiply); } }
    public bool hasLevelMultiply { get { return HasComponent(GameComponentsLookup.LevelMultiply); } }

    public void AddLevelMultiply(float newDamage, float newAttackRate, int newPrice) {
        var index = GameComponentsLookup.LevelMultiply;
        var component = (_Core_.Common.Components.LevelMultiplyComponent)CreateComponent(index, typeof(_Core_.Common.Components.LevelMultiplyComponent));
        component.damage = newDamage;
        component.attackRate = newAttackRate;
        component.price = newPrice;
        AddComponent(index, component);
    }

    public void ReplaceLevelMultiply(float newDamage, float newAttackRate, int newPrice) {
        var index = GameComponentsLookup.LevelMultiply;
        var component = (_Core_.Common.Components.LevelMultiplyComponent)CreateComponent(index, typeof(_Core_.Common.Components.LevelMultiplyComponent));
        component.damage = newDamage;
        component.attackRate = newAttackRate;
        component.price = newPrice;
        ReplaceComponent(index, component);
    }

    public void RemoveLevelMultiply() {
        RemoveComponent(GameComponentsLookup.LevelMultiply);
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

    static Entitas.IMatcher<GameEntity> _matcherLevelMultiply;

    public static Entitas.IMatcher<GameEntity> LevelMultiply {
        get {
            if (_matcherLevelMultiply == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.LevelMultiply);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherLevelMultiply = matcher;
            }

            return _matcherLevelMultiply;
        }
    }
}
