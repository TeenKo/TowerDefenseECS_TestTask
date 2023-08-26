//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public TakeDamageListenerComponent takeDamageListener { get { return (TakeDamageListenerComponent)GetComponent(GameComponentsLookup.TakeDamageListener); } }
    public bool hasTakeDamageListener { get { return HasComponent(GameComponentsLookup.TakeDamageListener); } }

    public void AddTakeDamageListener(System.Collections.Generic.List<ITakeDamageListener> newValue) {
        var index = GameComponentsLookup.TakeDamageListener;
        var component = (TakeDamageListenerComponent)CreateComponent(index, typeof(TakeDamageListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceTakeDamageListener(System.Collections.Generic.List<ITakeDamageListener> newValue) {
        var index = GameComponentsLookup.TakeDamageListener;
        var component = (TakeDamageListenerComponent)CreateComponent(index, typeof(TakeDamageListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveTakeDamageListener() {
        RemoveComponent(GameComponentsLookup.TakeDamageListener);
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

    static Entitas.IMatcher<GameEntity> _matcherTakeDamageListener;

    public static Entitas.IMatcher<GameEntity> TakeDamageListener {
        get {
            if (_matcherTakeDamageListener == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.TakeDamageListener);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherTakeDamageListener = matcher;
            }

            return _matcherTakeDamageListener;
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

    public void AddTakeDamageListener(ITakeDamageListener value) {
        var listeners = hasTakeDamageListener
            ? takeDamageListener.value
            : new System.Collections.Generic.List<ITakeDamageListener>();
        listeners.Add(value);
        ReplaceTakeDamageListener(listeners);
    }

    public void RemoveTakeDamageListener(ITakeDamageListener value, bool removeComponentWhenEmpty = true) {
        var listeners = takeDamageListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveTakeDamageListener();
        } else {
            ReplaceTakeDamageListener(listeners);
        }
    }
}
