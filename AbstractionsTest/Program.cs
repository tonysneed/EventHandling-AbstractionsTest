using AbstractionsTest.Abstractions;
using AbstractionsTest.Models;
using System;
using System.Linq;
using System.Collections.Generic;

namespace AbstractionsTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Events ...");
            var weatherForecasts = new List<WeatherForecast>
            {
                new WeatherForecast(DateTime.Now, 0, "freezing"),
                new WeatherForecast(DateTime.Now, 100, "boiling"),
            };

            IEvent @event = new WeatherForecastEvent(weatherForecasts);
            var events = new List<IEvent> { @event };

            foreach (var item in events.OfType<WeatherForecastEvent>())
            {
                Console.WriteLine($"Event Id {item.Id} created at {item.CreationDate.ToShortTimeString()}");
                foreach (var weather in item.WeatherForecasts)
                {
                    Console.WriteLine($"{weather.Summary}: {weather.TemperatureC} C, {weather.TemperatureF} F");
                }
            }

            Console.WriteLine("\nHandlers ...");
            IEventHandler handler = new WeatherForecastEventHandler();
            var handlers = new List<IEventHandler> { handler };

            foreach (var item in handlers)
            {
                item.HandleAsync(@event);
            }
        }
    }
}
