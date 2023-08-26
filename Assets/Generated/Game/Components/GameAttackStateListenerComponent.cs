//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public AttackStateListenerComponent attackStateListener { get { return (AttackStateListenerComponent)GetComponent(GameComponentsLookup.AttackStateListener); } }
    public bool hasAttackStateListener { get { return HasComponent(GameComponentsLookup.AttackStateListener); } }

    public void AddAttackStateListener(System.Collections.Generic.List<IAttackStateListener> newValue) {
        var index = GameComponentsLookup.AttackStateListener;
        var component = (AttackStateListenerComponent)CreateComponent(index, typeof(AttackStateListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceAttackStateListener(System.Collections.Generic.List<IAttackStateListener> newValue) {
        var index = GameComponentsLookup.AttackStateListener;
        var component = (AttackStateListenerComponent)CreateComponent(index, typeof(AttackStateListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveAttackStateListener() {
        RemoveComponent(GameComponentsLookup.AttackStateListener);
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

    static Entitas.IMatcher<GameEntity> _matcherAttackStateListener;

    public static Entitas.IMatcher<GameEntity> AttackStateListener {
        get {
            if (_matcherAttackStateListener == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.AttackStateListener);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherAttackStateListener = matcher;
            }

            return _matcherAttackStateListener;
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public void AddAttackStateListener(IAttackStateListener value) {
        var listeners = hasAttackStateListener
            ? attackStateListener.value
            : new System.Collections.Generic.List<IAttackStateListener>();
        listeners.Add(value);
        ReplaceAttackStateListener(listeners);
    }

    public void RemoveAttackStateListener(IAttackStateListener value, bool removeComponentWhenEmpty = true) {
        var listeners = attackStateListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveAttackStateListener();
        } else {
            ReplaceAttackStateListener(listeners);
        }
    }
}
