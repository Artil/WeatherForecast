using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Weather_Forecast_App.Models;

namespace Weather_Forecast_App.Interfaces
{
    public interface IWeather
    {
        WeatherViewModel GetWeather(string city);
    }
}
