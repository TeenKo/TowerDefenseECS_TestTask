//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventSystemGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed class AnyChangePlayerHpEventSystem : Entitas.ReactiveSystem<UIEntity> {

    readonly Entitas.IGroup<UIEntity> _listeners;
    readonly System.Collections.Generic.List<UIEntity> _entityBuffer;
    readonly System.Collections.Generic.List<IAnyChangePlayerHpListener> _listenerBuffer;

    public AnyChangePlayerHpEventSystem(Contexts contexts) : base(contexts.uI) {
        _listeners = contexts.uI.GetGroup(UIMatcher.AnyChangePlayerHpListener);
        _entityBuffer = new System.Collections.Generic.List<UIEntity>();
        _listenerBuffer = new System.Collections.Generic.List<IAnyChangePlayerHpListener>();
    }

    protected override Entitas.ICollector<UIEntity> GetTrigger(Entitas.IContext<UIEntity> context) {
        return Entitas.CollectorContextExtension.CreateCollector(
            context, Entitas.TriggerOnEventMatcherExtension.Added(UIMatcher.ChangePlayerHp)
        );
    }

    protected override bool Filter(UIEntity entity) {
        return entity.hasChangePlayerHp;
    }

    protected override void Execute(System.Collections.Generic.List<UIEntity> entities) {
        foreach (var e in entities) {
            var component = e.changePlayerHp;
            foreach (var listenerEntity in _listeners.GetEntities(_entityBuffer)) {
                _listenerBuffer.Clear();
                _listenerBuffer.AddRange(listenerEntity.anyChangePlayerHpListener.value);
                foreach (var listener in _listenerBuffer) {
                    listener.OnAnyChangePlayerHp(e, component.health, component.maxHealth);
                }
            }
        }
    }
}
