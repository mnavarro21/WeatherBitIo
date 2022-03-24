using APIHelper;
using APIHelper.Models.GetCurrentAirQualityResponse;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject2.StepDefinitions
{
    [Binding]
    public class GetAirQualityStepDefinitions : BasicSteps
    {
        private GetCurrentAirQualityByPostalCodeResponseDTO getCurrentAirQualityByPostalCodeResponseDTO = new GetCurrentAirQualityByPostalCodeResponseDTO();
        private string api_Key = "0ff84a5bc437409f8191825706ec7226";

        public GetAirQualityStepDefinitions()
        {
            baseUrl = jsonConfiguration.GetCurrentAirQuality.baseUrl;
            relativeUrl = jsonConfiguration.GetCurrentAirQuality.relativeUrl;
        }

        [Given(@"I want to get current air quality by ""([^""]*)""")]
        public void GivenIWantToGetCurrentAirQualityBy(string type)
        {
            switch (type.ToUpper())
            {
                case "POSTAL CODE": relativeUrl = relativeUrl + "?postal_code=";
                    break;
                case "LAT LONG": relativeUrl = relativeUrl + "?lat";
                    break;
                case "CITY": relativeUrl = relativeUrl + "?city_id=";
                    break;
                case "CITY AND COUNTRY": relativeUrl = relativeUrl + "?city=";
                    break;
            }
        }

        [When(@"I set my postal code to ""([^""]*)""")]
        public void WhenISetMyPostalCodeTo(string postalCode)
        {
            relativeUrl = relativeUrl + postalCode;
        }

        [When(@"I set my api key for get current air quality")]
        public void WhenISetMyApiKeyForGetCurrentAirQuality()
        {
            relativeUrl = relativeUrl + "&key=" + api_Key;
        }

        [When(@"I proceed to get my current air quality by postal code")]
        public void WhenIProceedToGetMyCurrentAirQualityByPostalCode()
        {
            UserActions<GetCurrentAirQualityByPostalCodeResponseDTO> api = new UserActions<GetCurrentAirQualityByPostalCodeResponseDTO>();
            restResponse = api.GetCurrentAirQualityByPostalCode(baseUrl, relativeUrl, headers);
            getCurrentAirQualityByPostalCodeResponseDTO = api.GetCurrentAirQualityByPostalCodeModel(restResponse);
        }

        [Then(@"I should get correct air quality details by ""([^""]*)""")]
        public void ThenIShouldGetCorrectAirQualityDetailsBy(string type)
        {
            Assert.AreEqual(200, (int)restResponse.StatusCode, "Response Status Code is " + restResponse.StatusCode);

            System.Diagnostics.Debug.WriteLine("Current weather by " + type + "  AQI: " + getCurrentAirQualityByPostalCodeResponseDTO.Data[0].Aqi);
            System.Diagnostics.Debug.WriteLine("Current weather by " + type + "  SO2: " + getCurrentAirQualityByPostalCodeResponseDTO.Data[0].So2);
            System.Diagnostics.Debug.WriteLine("Current weather by " + type + "  NO2: " + getCurrentAirQualityByPostalCodeResponseDTO.Data[0].No2);
            System.Diagnostics.Debug.WriteLine("Current weather by " + type + "  O3: " + getCurrentAirQualityByPostalCodeResponseDTO.Data[0].O3);
            System.Diagnostics.Debug.WriteLine("Current weather by " + type + "  PM25: " + getCurrentAirQualityByPostalCodeResponseDTO.Data[0].Pm25);
            System.Diagnostics.Debug.WriteLine("Current weather by " + type + "  PM10: " + getCurrentAirQualityByPostalCodeResponseDTO.Data[0].Pm10);
        }
    }
}
