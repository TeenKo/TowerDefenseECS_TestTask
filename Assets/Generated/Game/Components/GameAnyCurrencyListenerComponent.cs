//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public AnyCurrencyListenerComponent anyCurrencyListener { get { return (AnyCurrencyListenerComponent)GetComponent(GameComponentsLookup.AnyCurrencyListener); } }
    public bool hasAnyCurrencyListener { get { return HasComponent(GameComponentsLookup.AnyCurrencyListener); } }

    public void AddAnyCurrencyListener(System.Collections.Generic.List<IAnyCurrencyListener> newValue) {
        var index = GameComponentsLookup.AnyCurrencyListener;
        var component = (AnyCurrencyListenerComponent)CreateComponent(index, typeof(AnyCurrencyListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceAnyCurrencyListener(System.Collections.Generic.List<IAnyCurrencyListener> newValue) {
        var index = GameComponentsLookup.AnyCurrencyListener;
        var component = (AnyCurrencyListenerComponent)CreateComponent(index, typeof(AnyCurrencyListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveAnyCurrencyListener() {
        RemoveComponent(GameComponentsLookup.AnyCurrencyListener);
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

    static Entitas.IMatcher<GameEntity> _matcherAnyCurrencyListener;

    public static Entitas.IMatcher<GameEntity> AnyCurrencyListener {
        get {
            if (_matcherAnyCurrencyListener == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.AnyCurrencyListener);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherAnyCurrencyListener = matcher;
            }

            return _matcherAnyCurrencyListener;
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

    public void AddAnyCurrencyListener(IAnyCurrencyListener value) {
        var listeners = hasAnyCurrencyListener
            ? anyCurrencyListener.value
            : new System.Collections.Generic.List<IAnyCurrencyListener>();
        listeners.Add(value);
        ReplaceAnyCurrencyListener(listeners);
    }

    public void RemoveAnyCurrencyListener(IAnyCurrencyListener value, bool removeComponentWhenEmpty = true) {
        var listeners = anyCurrencyListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveAnyCurrencyListener();
        } else {
            ReplaceAnyCurrencyListener(listeners);
        }
    }
}