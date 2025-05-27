namespace MissingChildrenSA.Events;

public sealed class EventAggregator
{
    private static readonly EventAggregator _instance = new EventAggregator();
    public static EventAggregator Instance => _instance;

    // Stores original and wrapped delegates for comparison
    private readonly Dictionary<Type, List<(Delegate Original, Action<IAppEvent> Wrapped)>> _handlers = [];

    private EventAggregator() { }

    public void Subscribe<TEvent>(Action<TEvent> handler) where TEvent : IAppEvent
    {
        var type = typeof(TEvent);

        if (!_handlers.TryGetValue(type, out var list))
        {
            list = [];
            _handlers[type] = list;
        }

        // Prevent duplicate subscriptions
        if (list.Any(x => x.Original.Equals(handler)))
            return;

        void wrapper(IAppEvent e) => handler((TEvent)e);

        list.Add((handler, wrapper));
    }

    public void Unsubscribe<TEvent>(Action<TEvent> handler) where TEvent : IAppEvent
    {
        var type = typeof(TEvent);

        if (_handlers.TryGetValue(type, out var list))
        {
            list.RemoveAll(x => x.Original.Equals(handler));
        }
    }

    public void Publish<TEvent>(TEvent appEvent) where TEvent : IAppEvent
    {
        var type = typeof(TEvent);

        if (_handlers.TryGetValue(type, out var list))
        {
            foreach (var (_, handler) in list)
            {
                handler.Invoke(appEvent);
            }
        }
    }
}
