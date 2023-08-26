//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public _Core_.Common.Components.RewardComponent reward { get { return (_Core_.Common.Components.RewardComponent)GetComponent(GameComponentsLookup.Reward); } }
    public bool hasReward { get { return HasComponent(GameComponentsLookup.Reward); } }

    public void AddReward(int newValue) {
        var index = GameComponentsLookup.Reward;
        var component = (_Core_.Common.Components.RewardComponent)CreateComponent(index, typeof(_Core_.Common.Components.RewardComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceReward(int newValue) {
        var index = GameComponentsLookup.Reward;
        var component = (_Core_.Common.Components.RewardComponent)CreateComponent(index, typeof(_Core_.Common.Components.RewardComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveReward() {
        RemoveComponent(GameComponentsLookup.Reward);
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

    static Entitas.IMatcher<GameEntity> _matcherReward;

    public static Entitas.IMatcher<GameEntity> Reward {
        get {
            if (_matcherReward == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Reward);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherReward = matcher;
            }

            return _matcherReward;
        }
    }
}
