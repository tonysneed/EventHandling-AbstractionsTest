using AbstractionsTest.Abstractions;
using System.Collections.Generic;

namespace AbstractionsTest.Models
{
    public record WeatherForecastEvent(IEnumerable<WeatherForecast> WeatherForecasts) : Event
    {
    }
}
