//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public DeathStateListenerComponent deathStateListener { get { return (DeathStateListenerComponent)GetComponent(GameComponentsLookup.DeathStateListener); } }
    public bool hasDeathStateListener { get { return HasComponent(GameComponentsLookup.DeathStateListener); } }

    public void AddDeathStateListener(System.Collections.Generic.List<IDeathStateListener> newValue) {
        var index = GameComponentsLookup.DeathStateListener;
        var component = (DeathStateListenerComponent)CreateComponent(index, typeof(DeathStateListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceDeathStateListener(System.Collections.Generic.List<IDeathStateListener> newValue) {
        var index = GameComponentsLookup.DeathStateListener;
        var component = (DeathStateListenerComponent)CreateComponent(index, typeof(DeathStateListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveDeathStateListener() {
        RemoveComponent(GameComponentsLookup.DeathStateListener);
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

    static Entitas.IMatcher<GameEntity> _matcherDeathStateListener;

    public static Entitas.IMatcher<GameEntity> DeathStateListener {
        get {
            if (_matcherDeathStateListener == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.DeathStateListener);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherDeathStateListener = matcher;
            }

            return _matcherDeathStateListener;
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

    public void AddDeathStateListener(IDeathStateListener value) {
        var listeners = hasDeathStateListener
            ? deathStateListener.value
            : new System.Collections.Generic.List<IDeathStateListener>();
        listeners.Add(value);
        ReplaceDeathStateListener(listeners);
    }

    public void RemoveDeathStateListener(IDeathStateListener value, bool removeComponentWhenEmpty = true) {
        var listeners = deathStateListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveDeathStateListener();
        } else {
            ReplaceDeathStateListener(listeners);
        }
    }
}
