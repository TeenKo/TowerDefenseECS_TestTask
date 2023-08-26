//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public _Core_.Level.Components.EnemyStartPointComponent enemyStartPoint { get { return (_Core_.Level.Components.EnemyStartPointComponent)GetComponent(GameComponentsLookup.EnemyStartPoint); } }
    public bool hasEnemyStartPoint { get { return HasComponent(GameComponentsLookup.EnemyStartPoint); } }

    public void AddEnemyStartPoint(UnityEngine.Vector3 newValue) {
        var index = GameComponentsLookup.EnemyStartPoint;
        var component = (_Core_.Level.Components.EnemyStartPointComponent)CreateComponent(index, typeof(_Core_.Level.Components.EnemyStartPointComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceEnemyStartPoint(UnityEngine.Vector3 newValue) {
        var index = GameComponentsLookup.EnemyStartPoint;
        var component = (_Core_.Level.Components.EnemyStartPointComponent)CreateComponent(index, typeof(_Core_.Level.Components.EnemyStartPointComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveEnemyStartPoint() {
        RemoveComponent(GameComponentsLookup.EnemyStartPoint);
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

    static Entitas.IMatcher<GameEntity> _matcherEnemyStartPoint;

    public static Entitas.IMatcher<GameEntity> EnemyStartPoint {
        get {
            if (_matcherEnemyStartPoint == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EnemyStartPoint);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEnemyStartPoint = matcher;
            }

            return _matcherEnemyStartPoint;
        }
    }
}
