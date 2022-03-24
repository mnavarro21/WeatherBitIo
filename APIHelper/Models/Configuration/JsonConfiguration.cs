using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIHelper.Models.Configuration
{
    public class JsonConfiguration
    {
        public GetCurrentWeather GetCurrentWeather { get; set; }
        public GetCurrentWeather GetCurrentAirQuality { get; set; }
    }

    public class GetCurrentWeather
    {
        public string baseUrl { get; set; }
        public string relativeUrl { get; set; }
    }
    public class GetCurrentAirQuality
    {
        public string baseUrl { get; set; }
        public string relativeUrl { get; set; }
    }
}
