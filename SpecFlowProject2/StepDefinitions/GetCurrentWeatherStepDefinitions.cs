using APIHelper;
using APIHelper.Models.GetCurrentWeatherResponse;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject2.StepDefinitions
{
    [Binding]
    public class GetCurrentWeatherSteps : BasicSteps
    {
        private GetCurrentWeatherByCityResponseDTO getCurrentWeatherByCityResponseDTO = new GetCurrentWeatherByCityResponseDTO();
        private GetCurrentWeatherByLatLongResponseDTO getCurrentWeatherByLatLongResponseDTO = new GetCurrentWeatherByLatLongResponseDTO();
        private string api_Key = "0ff84a5bc437409f8191825706ec7226";
        public GetCurrentWeatherSteps()
        {
            baseUrl = jsonConfiguration.GetCurrentWeather.baseUrl;
            relativeUrl = jsonConfiguration.GetCurrentWeather.relativeUrl;
        }

        [Given(@"I want to get current weather by ""(.*)""")]
        public void GivenIWantToGetCurrentWeatherBy(string type)
        {
            switch (type.ToUpper())
            {
                case "CITY":
                    relativeUrl = relativeUrl + "city_id=";
                    break;
                case "CITIES":
                    relativeUrl = relativeUrl + "cities=";
                    break;
                case "LAT LONG":
                    
                    break;
            }
        }

        [When(@"I set my city to ""(.*)""")]
        public void WhenISetMyCityTo(string cityCode)
        {
            relativeUrl = relativeUrl + cityCode;
        }

        [When(@"I set my latitude to ""([^""]*)""")]
        public void WhenISetMyLatitudeTo(string latitude)
        {
            relativeUrl = relativeUrl + "lat=" + latitude;
        }

        [When(@"I set my longitude to ""([^""]*)""")]
        public void WhenISetMyLongitudeTo(string longitude)
        {
            relativeUrl = relativeUrl + "&lon=" + longitude;
        }

        [When(@"I set my api key")]
        public void WhenISetMyApiKey()
        {
            relativeUrl = relativeUrl + "&key=" + api_Key;
        }

        [When(@"I proceed to get my current weather by city")]
        public void WhenIProceedToGetMyCurrentWeatherByCity()
        {
            UserActions<GetCurrentWeatherByCityResponseDTO> api = new UserActions<GetCurrentWeatherByCityResponseDTO>();
            restResponse = api.GetCurrentWeatherByCity(baseUrl, relativeUrl, headers);
            Assert.IsNotNull(restResponse, "Response is null");
            getCurrentWeatherByCityResponseDTO = api.GetCurrentWeatherByCityModel(restResponse);
        }

        [When(@"I proceed to get my current weather by latitude longitude")]
        public void WhenIProceedToGetMyCurrentWeatherByLatitudeLongitude()
        {
            UserActions<GetCurrentWeatherByLatLongResponseDTO> api = new UserActions<GetCurrentWeatherByLatLongResponseDTO>();
            restResponse = api.GetCurrentWeatherByLatitudeLongitude(baseUrl, relativeUrl, headers);
            Assert.IsNotNull(restResponse, "Response is null");
            getCurrentWeatherByLatLongResponseDTO = api.GetCurrentWeatherByLatitudeLongitudeModel(restResponse);
        }

        [Then(@"I should get correct weather details by city")]
        public void ThenIShouldGetCorrectWeatherDetailsByCity()
        {
            Assert.AreEqual(200, (int)restResponse.StatusCode, "Current Response: " + restResponse.Content);
            System.Diagnostics.Debug.WriteLine("Current weather by city CITY_NAME: " + getCurrentWeatherByCityResponseDTO.Data[0].CityName);
            System.Diagnostics.Debug.WriteLine("Current weather by city STATE_CODE: " + getCurrentWeatherByCityResponseDTO.Data[0].StateCode);
            System.Diagnostics.Debug.WriteLine("Current weather by city COUNTRY_CODE: " + getCurrentWeatherByCityResponseDTO.Data[0].CountryCode);
            System.Diagnostics.Debug.WriteLine("Current weather by city TIMEZONE: " + getCurrentWeatherByCityResponseDTO.Data[0].Timezone);
            System.Diagnostics.Debug.WriteLine("Current weather by city LAT: " + getCurrentWeatherByCityResponseDTO.Data[0].Lat);
            System.Diagnostics.Debug.WriteLine("Current weather by city LON: " + getCurrentWeatherByCityResponseDTO.Data[0].Lon);
            System.Diagnostics.Debug.WriteLine("Current weather by city Station: " + getCurrentWeatherByCityResponseDTO.Data[0].Station);
            System.Diagnostics.Debug.WriteLine("Current weather by city VIS: " + getCurrentWeatherByCityResponseDTO.Data[0].Vis);
            System.Diagnostics.Debug.WriteLine("Current weather by city RH: " + getCurrentWeatherByCityResponseDTO.Data[0].Rh);
            System.Diagnostics.Debug.WriteLine("Current weather by city WIND_DIR: " + getCurrentWeatherByCityResponseDTO.Data[0].WindDir);
            System.Diagnostics.Debug.WriteLine("Current weather by city DEWPT: " + getCurrentWeatherByCityResponseDTO.Data[0].Dewpt);
            System.Diagnostics.Debug.WriteLine("Current weather by city WIND_CDR: " + getCurrentWeatherByCityResponseDTO.Data[0].WindCdir);
            System.Diagnostics.Debug.WriteLine("Current weather by city WIND_CDR_FULL: " + getCurrentWeatherByCityResponseDTO.Data[0].WindCdirFull);
            System.Diagnostics.Debug.WriteLine("Current weather by city WIND_SPD: " + getCurrentWeatherByCityResponseDTO.Data[0].WindSpd);
            System.Diagnostics.Debug.WriteLine("Current weather by city TEMP: " + getCurrentWeatherByCityResponseDTO.Data[0].Temp);
            System.Diagnostics.Debug.WriteLine("Current weather by city APPTEMP: " + getCurrentWeatherByCityResponseDTO.Data[0].AppTemp);
            System.Diagnostics.Debug.WriteLine("Current weather by city CLOUDS: " + getCurrentWeatherByCityResponseDTO.Data[0].Clouds);
            System.Diagnostics.Debug.WriteLine("Current weather by city POD: " + getCurrentWeatherByCityResponseDTO.Data[0].Pod);
            System.Diagnostics.Debug.WriteLine("Current weather by city PRES: " + getCurrentWeatherByCityResponseDTO.Data[0].Pres);
            System.Diagnostics.Debug.WriteLine("Current weather by city OB_TIME: " + getCurrentWeatherByCityResponseDTO.Data[0].ObTime);
            System.Diagnostics.Debug.WriteLine("Current weather by city CLOUDS: " + getCurrentWeatherByCityResponseDTO.Data[0].Clouds);
            System.Diagnostics.Debug.WriteLine("Current weather by city TS: " + getCurrentWeatherByCityResponseDTO.Data[0].Ts);
            System.Diagnostics.Debug.WriteLine("Current weather by city SOLAR_RAD: " + getCurrentWeatherByCityResponseDTO.Data[0].SolarRad);
            System.Diagnostics.Debug.WriteLine("Current weather by city SLP: " + getCurrentWeatherByCityResponseDTO.Data[0].Slp);
            System.Diagnostics.Debug.WriteLine("Current weather by city H_ANGLE: " + getCurrentWeatherByCityResponseDTO.Data[0].HAngle);
            System.Diagnostics.Debug.WriteLine("Current weather by city SUNSET: " + getCurrentWeatherByCityResponseDTO.Data[0].Sunset);
            System.Diagnostics.Debug.WriteLine("Current weather by city DNI: " + getCurrentWeatherByCityResponseDTO.Data[0].Dni);
            System.Diagnostics.Debug.WriteLine("Current weather by city SNOW: " + getCurrentWeatherByCityResponseDTO.Data[0].Snow);
            System.Diagnostics.Debug.WriteLine("Current weather by city UV: " + getCurrentWeatherByCityResponseDTO.Data[0].Uv);
            System.Diagnostics.Debug.WriteLine("Current weather by city PRECIP: " + getCurrentWeatherByCityResponseDTO.Data[0].Precip);
            System.Diagnostics.Debug.WriteLine("Current weather by city SUNRISE: " + getCurrentWeatherByCityResponseDTO.Data[0].Sunrise);
            System.Diagnostics.Debug.WriteLine("Current weather by city GHI: " + getCurrentWeatherByCityResponseDTO.Data[0].Ghi);
            System.Diagnostics.Debug.WriteLine("Current weather by city DHI: " + getCurrentWeatherByCityResponseDTO.Data[0].Dhi);
            System.Diagnostics.Debug.WriteLine("Current weather by city AQI: " + getCurrentWeatherByCityResponseDTO.Data[0].Aqi);
            System.Diagnostics.Debug.WriteLine("Current weather by city LAT: " + getCurrentWeatherByCityResponseDTO.Data[0].Lat);
            string currentWeather = "Current weather is " + getCurrentWeatherByCityResponseDTO.Data[0].Weather.Description;
            System.Diagnostics.Debug.WriteLine(currentWeather);
        }

        [Then(@"I should get correct weather details by cities")]
        public void ThenIShouldGetCorrectWeatherDetailsByCities()
        {
            Assert.AreEqual(200, (int)restResponse.StatusCode, "Current Response: " + restResponse.Content);
            string currentWeather = "Current weather is " + getCurrentWeatherByCityResponseDTO.Data[0].Weather.Description;
            System.Diagnostics.Debug.WriteLine(currentWeather);
        }

        [Then(@"I should get correct weather details by latitude longitude")]
        public void ThenIShouldGetCorrectWeatherDetailsByLatitudeLongitude()
        {
            Assert.AreEqual(200, (int)restResponse.StatusCode, "Current Response: " + restResponse.Content);
            System.Diagnostics.Debug.WriteLine("Current weather by latitude longitude RH: " + getCurrentWeatherByLatLongResponseDTO.Data[0].Rh);
            System.Diagnostics.Debug.WriteLine("Current weather by latitude longitude POD: " + getCurrentWeatherByLatLongResponseDTO.Data[0].Pod);
            System.Diagnostics.Debug.WriteLine("Current weather by latitude longitude LON: " + getCurrentWeatherByLatLongResponseDTO.Data[0].Lon);
            System.Diagnostics.Debug.WriteLine("Current weather by latitude longitude PRES: " + getCurrentWeatherByLatLongResponseDTO.Data[0].Pres);
            System.Diagnostics.Debug.WriteLine("Current weather by latitude longitude TIMEZONE: " + getCurrentWeatherByLatLongResponseDTO.Data[0].Timezone);
            System.Diagnostics.Debug.WriteLine("Current weather by latitude longitude OB_TIME: " + getCurrentWeatherByLatLongResponseDTO.Data[0].ObTime);
            System.Diagnostics.Debug.WriteLine("Current weather by latitude longitude COUNTRY_CODE: " + getCurrentWeatherByLatLongResponseDTO.Data[0].CountryCode);
            System.Diagnostics.Debug.WriteLine("Current weather by latitude longitude CLOUDS: " + getCurrentWeatherByLatLongResponseDTO.Data[0].Clouds);
            System.Diagnostics.Debug.WriteLine("Current weather by latitude longitude TS: " + getCurrentWeatherByLatLongResponseDTO.Data[0].Ts);
            System.Diagnostics.Debug.WriteLine("Current weather by latitude longitude SOLAR_RAD: " + getCurrentWeatherByLatLongResponseDTO.Data[0].SolarRad);
            System.Diagnostics.Debug.WriteLine("Current weather by latitude longitude STATE_CODE: " + getCurrentWeatherByLatLongResponseDTO.Data[0].StateCode);
            System.Diagnostics.Debug.WriteLine("Current weather by latitude longitude CITY_NAME: " + getCurrentWeatherByLatLongResponseDTO.Data[0].CityName);
            System.Diagnostics.Debug.WriteLine("Current weather by latitude longitude WIND_SPD: " + getCurrentWeatherByLatLongResponseDTO.Data[0].WindSpd);
            System.Diagnostics.Debug.WriteLine("Current weather by latitude longitude WIND_CDR_FULL: " + getCurrentWeatherByLatLongResponseDTO.Data[0].WindCdirFull);
            System.Diagnostics.Debug.WriteLine("Current weather by latitude longitude WIND_CDR: " + getCurrentWeatherByLatLongResponseDTO.Data[0].WindCdir);
            System.Diagnostics.Debug.WriteLine("Current weather by latitude longitude SLP: " + getCurrentWeatherByLatLongResponseDTO.Data[0].Slp);
            System.Diagnostics.Debug.WriteLine("Current weather by latitude longitude VIS: " + getCurrentWeatherByLatLongResponseDTO.Data[0].Vis);
            System.Diagnostics.Debug.WriteLine("Current weather by latitude longitude H_ANGLE: " + getCurrentWeatherByLatLongResponseDTO.Data[0].HAngle);
            System.Diagnostics.Debug.WriteLine("Current weather by latitude longitude SUNSET: " + getCurrentWeatherByLatLongResponseDTO.Data[0].Sunset);
            System.Diagnostics.Debug.WriteLine("Current weather by latitude longitude DNI: " + getCurrentWeatherByLatLongResponseDTO.Data[0].Dni);
            System.Diagnostics.Debug.WriteLine("Current weather by latitude longitude DEWPT: " + getCurrentWeatherByLatLongResponseDTO.Data[0].Dewpt);
            System.Diagnostics.Debug.WriteLine("Current weather by latitude longitude SNOW: " + getCurrentWeatherByLatLongResponseDTO.Data[0].Snow);
            System.Diagnostics.Debug.WriteLine("Current weather by latitude longitude UV: " + getCurrentWeatherByLatLongResponseDTO.Data[0].Uv);
            System.Diagnostics.Debug.WriteLine("Current weather by latitude longitude PRECIP: " + getCurrentWeatherByLatLongResponseDTO.Data[0].Precip);
            System.Diagnostics.Debug.WriteLine("Current weather by latitude longitude WIND_DIR: " + getCurrentWeatherByLatLongResponseDTO.Data[0].WindDir);
            System.Diagnostics.Debug.WriteLine("Current weather by latitude longitude SUNRISE: " + getCurrentWeatherByLatLongResponseDTO.Data[0].Sunrise);
            System.Diagnostics.Debug.WriteLine("Current weather by latitude longitude GHI: " + getCurrentWeatherByLatLongResponseDTO.Data[0].Ghi);
            System.Diagnostics.Debug.WriteLine("Current weather by latitude longitude DHI: " + getCurrentWeatherByLatLongResponseDTO.Data[0].Dhi);
            System.Diagnostics.Debug.WriteLine("Current weather by latitude longitude AQI: " + getCurrentWeatherByLatLongResponseDTO.Data[0].Aqi);
            System.Diagnostics.Debug.WriteLine("Current weather by latitude longitude LAT: " + getCurrentWeatherByLatLongResponseDTO.Data[0].Lat);
            string currentWeather = "Current weather is " + getCurrentWeatherByLatLongResponseDTO.Data[0].Weather.Description;
            System.Diagnostics.Debug.WriteLine(currentWeather);
        }

    }
}
