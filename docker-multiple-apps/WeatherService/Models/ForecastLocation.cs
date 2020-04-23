using System;
using System.Collections.Generic;

namespace WeatherService.Models
{
    public class ForecastLocation
    {
        public int LocationCode { get; set; }
        public string LocationName { get; set; }
        public List<WeatherForecast> Forecast { get; set; } 
    }
}
