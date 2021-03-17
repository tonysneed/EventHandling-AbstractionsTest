using System.Threading.Tasks;

namespace AbstractionsTest.Abstractions
{
    public interface IEventHandler
    {
        Task HandleAsync(IEvent @event);
    }

    public interface IEventHandler<in TEvent> : IEventHandler
        where TEvent: IEvent
    {
        Task HandleAsync(TEvent @event);
    }
}
