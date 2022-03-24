using APIHelper.Models.GetCurrentAirQualityResponse;
using APIHelper.Models.GetCurrentWeatherResponse;
using RestSharp;

namespace APIHelper
{
    public class UserActions<T>
    {
        readonly string jsonFormatType = "application/json";
        public IRestResponse GetCurrentWeatherByCity(string baseUrl, string relativeUrl, IDictionary<string, string> headers)
        {
            RestSharpActions<GetCurrentWeatherByCityResponseDTO> getCurrentWeatherByCity = new RestSharpActions<GetCurrentWeatherByCityResponseDTO>();
            RestClient restClient = getCurrentWeatherByCity.setUrl(baseUrl, relativeUrl);
            dynamic request = getCurrentWeatherByCity.CreateGetRequest(headers, jsonFormatType);
            dynamic response = getCurrentWeatherByCity.GetResponse(restClient, request);
            return response;
        }

        public GetCurrentWeatherByCityResponseDTO GetCurrentWeatherByCityModel(IRestResponse response)
        {
            RestSharpActions<GetCurrentWeatherByCityResponseDTO> helper = new RestSharpActions<GetCurrentWeatherByCityResponseDTO>();
            GetCurrentWeatherByCityResponseDTO getCurrentWeatherByCityResponseDTO = helper.GetContent<GetCurrentWeatherByCityResponseDTO>(response);
            return getCurrentWeatherByCityResponseDTO;
        }

        public IRestResponse GetCurrentWeatherByLatitudeLongitude(string baseUrl, string relativeUrl, IDictionary<string, string> headers)
        {
            RestSharpActions<GetCurrentWeatherByLatLongResponseDTO> getCurrentWeatherByLatLong = new RestSharpActions<GetCurrentWeatherByLatLongResponseDTO>();
            RestClient restClient = getCurrentWeatherByLatLong.setUrl(baseUrl, relativeUrl);
            dynamic request = getCurrentWeatherByLatLong.CreateGetRequest(headers, jsonFormatType);
            dynamic response = getCurrentWeatherByLatLong.GetResponse(restClient, request);
            return response;
        }

        public GetCurrentWeatherByLatLongResponseDTO GetCurrentWeatherByLatitudeLongitudeModel(IRestResponse response)
        {
            RestSharpActions<GetCurrentWeatherByLatLongResponseDTO> helper = new RestSharpActions<GetCurrentWeatherByLatLongResponseDTO>();
            GetCurrentWeatherByLatLongResponseDTO getCurrentWeatherByLatLongResponseDTO = helper.GetContent<GetCurrentWeatherByLatLongResponseDTO>(response);
            return getCurrentWeatherByLatLongResponseDTO;
        }

        public IRestResponse GetCurrentAirQualityByPostalCode(string baseUrl, string relativeUrl, IDictionary<string, string> headers)
        {
            RestSharpActions<GetCurrentAirQualityByPostalCodeResponseDTO> getCurrentAirQualityByPostalCode = new RestSharpActions<GetCurrentAirQualityByPostalCodeResponseDTO>();
            RestClient restClient = getCurrentAirQualityByPostalCode.setUrl(baseUrl, relativeUrl);
            dynamic request = getCurrentAirQualityByPostalCode.CreateGetRequest(headers, jsonFormatType);
            dynamic response = getCurrentAirQualityByPostalCode.GetResponse(restClient, request);
            return response;
        }

        public GetCurrentAirQualityByPostalCodeResponseDTO GetCurrentAirQualityByPostalCodeModel(IRestResponse response)
        {
            RestSharpActions<GetCurrentAirQualityByPostalCodeResponseDTO> helper = new RestSharpActions<GetCurrentAirQualityByPostalCodeResponseDTO>();
            GetCurrentAirQualityByPostalCodeResponseDTO getCurrentAirQualityByPostalCodeResponseDTO = helper.GetContent<GetCurrentAirQualityByPostalCodeResponseDTO>(response);
            return getCurrentAirQualityByPostalCodeResponseDTO;
        }
    }
}
