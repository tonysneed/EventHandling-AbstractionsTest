using AbstractionsTest.Abstractions;
using System;
using System.Threading.Tasks;
using EventHandler = AbstractionsTest.Abstractions.EventHandler;

namespace AbstractionsTest.Models
{
    public class WeatherForecastEventHandler : EventHandler
    {
        public override Task HandleAsync(IEvent @event)
        {
            Console.WriteLine($"Handling event: {@event.GetType()}");
            return Task.CompletedTask;
        }
    }
}
