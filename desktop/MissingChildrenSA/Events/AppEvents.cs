namespace MissingChildrenSA.Events;

public static class AppEvents
{
    public class UserAddedOrUpdatedEvent : IAppEvent { }

    public class MissingPersonCreatedOrUpdatedEvent : IAppEvent { }

    public class ModerationStartedOrCompletedEvent : IAppEvent { }
}