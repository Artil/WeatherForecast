using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Weather_Forecast_App.Interfaces;
using Weather_Forecast_App.Models;

namespace Weather_Forecast_App.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWeather _weather;

        public HomeController(IWeather weather)
        {
            _weather = weather;
        }

        //first page
        [HttpGet]
        public IActionResult Index()
        {
            string city = "Kiev";
            Index(city);
            return View();
        }


        [HttpPost]
        public IActionResult Index(string city)
        {
            //check city !=null
            if (String.IsNullOrEmpty(city))
            {
                return View();
            }

            var weather = _weather.GetWeather(city);

            if(ReferenceEquals(weather, null))
                return View();
            else
                return View(weather);  //return 2 models
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
