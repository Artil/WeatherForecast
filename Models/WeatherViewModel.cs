using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Weather_Forecast_App.Models
{
    public class WeatherViewModel
    {
        public CurrentWeather currentWeather { get; set; }
        public ForecastWeather forecastWeather { get; set; }
    }
}
