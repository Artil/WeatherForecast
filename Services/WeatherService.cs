using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Weather_Forecast_App.Interfaces;
using Weather_Forecast_App.Models;

namespace Weather_Forecast_App.Services
{
    public class WeatherService : IWeather
    {
        private readonly IConfiguration _config;
        public WeatherService(IConfiguration config)
        {
            _config = config;
        }

        public WeatherViewModel GetWeather(string city)
        {
            //get key from appsettings.json
            string apiKey = _config.GetSection("OpenWeatherMap").GetSection("apiKey").Value;
            string currentUrl = "http://api.openweathermap.org/data/2.5/weather?q=" + city + "&units=metric&APPID=" + apiKey;
            string forecastUrl = "http://api.openweathermap.org/data/2.5/forecast?q=" + city + "&units=metric&APPID=" + apiKey;
            using (var client = new WebClient())
            {
                try
                {
                    //get url content
                    string currentContent = client.DownloadString(currentUrl);
                    //convert json to CurrentWeatherViewModel
                    var currentWeather = JsonConvert.DeserializeObject<CurrentWeather>(currentContent);

                    string forecastContent = client.DownloadString(forecastUrl);
                    var forecastWeather = JsonConvert.DeserializeObject<ForecastWeather>(forecastContent);

                    //return 2 models
                    return new WeatherViewModel() { currentWeather = currentWeather, forecastWeather = forecastWeather };
                }
                catch
                {
                    return null;
                }
            }
        }
    }
}
