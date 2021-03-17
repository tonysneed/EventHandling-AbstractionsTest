using AbstractionsTest.Abstractions;
using System.Collections.Generic;

namespace AbstractionsTest.Models
{
    public record WeatherReportEvent(IEnumerable<WeatherForecast> WeatherForecasts) : Event
    {
    }
}
