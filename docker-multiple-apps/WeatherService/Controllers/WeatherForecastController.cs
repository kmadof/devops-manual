using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WeatherService.Models;

namespace WeatherService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public UserWeatherForecast Get()
        {
            _logger.LogInformation("Getting Five Day Forecast");

            _logger.LogDebug("Checking for user token");

            int? userId = null;
            var uwf = new UserWeatherForecast() { UserId = userId };

            if (userId.HasValue)
            {
                _logger.LogDebug("Token found: Reading database for user details");
            }
            else
            {
                _logger.LogDebug("Anonymous access: Returning default weather");
                uwf.UserLocationForecasts = new List<ForecastLocation>();

                var defaultLocation = new ForecastLocation()
                {
                    LocationCode = 0,
                    LocationName = "Default Location",
                    Forecast = new List<WeatherForecast>()
                };

                uwf.UserLocationForecasts.Add(defaultLocation);

            }

            foreach (var loc in uwf.UserLocationForecasts)
            {
                loc.Forecast.AddRange(GetRandomFiveDays());
            }

            return uwf;
        }

        private IEnumerable<WeatherForecast> GetRandomFiveDays()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sticky", "Sweltering", "Scorching", "Deeply Unpleasant"
        };

        private readonly ILogger<WeatherForecastController> _logger;


    }
}
