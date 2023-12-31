//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public _Core_.Towers.TowerPoints.Components.TowerPointComponent towerPoint { get { return (_Core_.Towers.TowerPoints.Components.TowerPointComponent)GetComponent(GameComponentsLookup.TowerPoint); } }
    public bool hasTowerPoint { get { return HasComponent(GameComponentsLookup.TowerPoint); } }

    public void AddTowerPoint(UnityEngine.Vector3 newValue) {
        var index = GameComponentsLookup.TowerPoint;
        var component = (_Core_.Towers.TowerPoints.Components.TowerPointComponent)CreateComponent(index, typeof(_Core_.Towers.TowerPoints.Components.TowerPointComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceTowerPoint(UnityEngine.Vector3 newValue) {
        var index = GameComponentsLookup.TowerPoint;
        var component = (_Core_.Towers.TowerPoints.Components.TowerPointComponent)CreateComponent(index, typeof(_Core_.Towers.TowerPoints.Components.TowerPointComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveTowerPoint() {
        RemoveComponent(GameComponentsLookup.TowerPoint);
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

    static Entitas.IMatcher<GameEntity> _matcherTowerPoint;

    public static Entitas.IMatcher<GameEntity> TowerPoint {
        get {
            if (_matcherTowerPoint == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.TowerPoint);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherTowerPoint = matcher;
            }

            return _matcherTowerPoint;
        }
    }
}
