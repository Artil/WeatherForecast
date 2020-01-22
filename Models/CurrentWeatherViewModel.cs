using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Weather_Forecast_App.Models
{
    public class CurrentWeather
    {
        public CoordCurrentWeather coord { get; set; }
        public List<WeatherCurrent> weather { get; set; }
        public string _base { get; set; }
        public MainCurrent main { get; set; }
        public int visibility { get; set; }
        public WindCurrent wind { get; set; }
        public CloudsCurrent clouds { get; set; }
        public int dt { get; set; }
        public SysCurrent sys { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public int cod { get; set; }
    }

    public class CoordCurrentWeather
    {
        public double lon { get; set; }
        public double lat { get; set; }
    }

    public class WeatherCurrent
    {
        public int id { get; set; }
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
    }

    public class MainCurrent
    {
        public double temp { get; set; }
        public int pressure { get; set; }
        public int humidity { get; set; }
        public double temp_min { get; set; }
        public double temp_max { get; set; }
    }

    public class WindCurrent
    {
        public double speed { get; set; }
        public double deg { get; set; }
    }

    public class CloudsCurrent
    {
        public int all { get; set; }
    }

    public class SysCurrent
    {
        public int type { get; set; }
        public int id { get; set; }
        public double message { get; set; }
        public string country { get; set; }
        public int sunrise { get; set; }
        public int sunset { get; set; }
    }

}
