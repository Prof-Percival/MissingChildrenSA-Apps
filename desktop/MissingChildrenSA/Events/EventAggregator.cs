namespace MissingChildrenSA.Events;

public sealed class EventAggregator
{
    private static readonly EventAggregator _instance = new EventAggregator();
    public static EventAggregator Instance => _instance;

    private readonly Dictionary<Type, List<Action<IAppEvent>>> _handlers = [];

    private EventAggregator() { }

    public void Subscribe<TEvent>(Action<TEvent> handler) where TEvent : IAppEvent
    {
        var type = typeof(TEvent);

        if (!_handlers.TryGetValue(type, out var list))
        {
            list = [];
            _handlers[type] = list;
        }

        // Wrap the strongly-typed handler
        void wrapper(IAppEvent e) => handler((TEvent)e);

        list.Add(wrapper);
    }

    public void Unsubscribe<TEvent>(Action<TEvent> handler) where TEvent : IAppEvent
    {
        var type = typeof(TEvent);

        if (_handlers.TryGetValue(type, out var list))
        {
            list.RemoveAll(h => h.Equals((Action<IAppEvent>)(e => handler((TEvent)e))));
        }
    }

    public void Publish<TEvent>(TEvent appEvent) where TEvent : IAppEvent
    {
        var type = typeof(TEvent);

        if (_handlers.TryGetValue(type, out var list))
        {
            foreach (var handler in list)
            {
                handler.Invoke(appEvent);
            }
        }
    }
}
