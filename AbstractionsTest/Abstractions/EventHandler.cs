using System.Threading.Tasks;

namespace AbstractionsTest.Abstractions
{
    public abstract class EventHandler : IEventHandler
    {
        public abstract Task HandleAsync(IEvent @event);
    }
}
