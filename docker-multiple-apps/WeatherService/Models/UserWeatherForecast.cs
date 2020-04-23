using System;
using System.Collections.Generic;

namespace WeatherService.Models
{
    public class UserWeatherForecast
    {
        public int? UserId { get; set; }
        public List<ForecastLocation> UserLocationForecasts { get; set; }
    }
}
