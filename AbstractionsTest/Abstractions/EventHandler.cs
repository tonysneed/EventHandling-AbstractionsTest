using System.Threading.Tasks;

namespace AbstractionsTest.Abstractions
{
    public abstract class EventHandler<TEvent> : IEventHandler<TEvent>
        where TEvent : IEvent
    {
        public virtual Task HandleAsync(IEvent @event)
        {
            return HandleAsync((TEvent)@event);
        }

        public abstract Task HandleAsync(TEvent @event);
    }
}
