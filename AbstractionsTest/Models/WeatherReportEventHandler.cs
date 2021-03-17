using System;
using System.Threading.Tasks;

namespace AbstractionsTest.Models
{
    public class WeatherReportEventHandler : Abstractions.EventHandler<WeatherReportEvent>
    {
        public override Task HandleAsync(WeatherReportEvent @event)
        {
            Console.WriteLine($"Handling event: {@event.GetType()}");
            foreach (var weather in @event.WeatherForecasts)
            {
                Console.WriteLine($"{weather.Summary}: {weather.TemperatureC} C, {weather.TemperatureF} F");
            }
            return Task.CompletedTask;
        }
    }
}
