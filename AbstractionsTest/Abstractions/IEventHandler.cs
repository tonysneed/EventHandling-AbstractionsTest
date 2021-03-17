using System.Threading.Tasks;

namespace AbstractionsTest.Abstractions
{
    public interface IEventHandler
    {
        Task HandleAsync(IEvent @event);
    }
}
