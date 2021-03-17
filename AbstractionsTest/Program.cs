using AbstractionsTest.Abstractions;
using AbstractionsTest.Models;
using System;
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

            IEvent forecastEvent = new WeatherForecastEvent(weatherForecasts);
            IEvent reportEvent = new WeatherReportEvent(weatherForecasts);
            var events = new List<IEvent> { forecastEvent, reportEvent };

            foreach (var @event in events)
            {
                Console.WriteLine($"\n{@event.GetType().Name}: Event Id {@event.Id} created at {@event.CreationDate.ToShortTimeString()}");
                if (@event is WeatherForecastEvent _forecastEvent)
                {
                    foreach (var weather in _forecastEvent.WeatherForecasts)
                    {
                        Console.WriteLine($"Forecast: {weather.Summary}: {weather.TemperatureC} C, {weather.TemperatureF} F");
                    }
                }
                if (@event is WeatherReportEvent _reportEvent)
                {
                    foreach (var weather in _reportEvent.WeatherForecasts)
                    {
                        Console.WriteLine($"Report: {weather.Summary}: {weather.TemperatureC} C, {weather.TemperatureF} F");
                    }
                }
            }

            Console.WriteLine("\nHandlers ...");
            var forecastHandler = new WeatherForecastEventHandler();
            var reportHandler = new WeatherReportEventHandler();
            var handlers = new List<IEventHandler> { forecastHandler, reportHandler };

            foreach (var handler in handlers)
            {
                if (handler is IEventHandler<WeatherForecastEvent>)
                {
                    handler.HandleAsync(forecastEvent);
                }
                if (handler is IEventHandler<WeatherReportEvent>)
                {
                    handler.HandleAsync(reportEvent);
                }
            }
        }
    }
}
