using Newtonsoft.Json;

namespace APIHelper.Models.GetCurrentAirQualityResponse
{
    public partial class GetCurrentAirQualityByPostalCodeResponseDTO
    {
        [JsonProperty("city_name")]
        public string CityName { get; set; }

        [JsonProperty("state_code")]
        public string StateCode { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("lat")]
        public string Lat { get; set; }

        [JsonProperty("lon")]
        public string Lon { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("data")]
        public Datum[] Data { get; set; }
    }

    public partial class Datum
    {
        [JsonProperty("ts")]
        public long Ts { get; set; }

        [JsonProperty("timestamp_local")]
        public DateTimeOffset TimestampLocal { get; set; }

        [JsonProperty("timestamp_utc")]
        public DateTimeOffset TimestampUtc { get; set; }

        [JsonProperty("aqi")]
        public long Aqi { get; set; }

        [JsonProperty("so2")]
        public long So2 { get; set; }

        [JsonProperty("no2")]
        public long No2 { get; set; }

        [JsonProperty("o3")]
        public long O3 { get; set; }

        [JsonProperty("pm25")]
        public long Pm25 { get; set; }

        [JsonProperty("pm10")]
        public long Pm10 { get; set; }
    }
}
