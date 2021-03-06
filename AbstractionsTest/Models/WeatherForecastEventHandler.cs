using System;
using System.Threading.Tasks;

namespace AbstractionsTest.Models
{
    public class WeatherForecastEventHandler : Abstractions.EventHandler<WeatherForecastEvent>
    {
        public override Task HandleAsync(WeatherForecastEvent @event)
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
