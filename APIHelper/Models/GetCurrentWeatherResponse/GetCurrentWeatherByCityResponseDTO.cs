using Newtonsoft.Json;

namespace APIHelper.Models.GetCurrentWeatherResponse
{
    public partial class GetCurrentWeatherByCityResponseDTO
    {
        [JsonProperty("data")]
        public Datum[] Data { get; set; }

        [JsonProperty("count")]
        public long Count { get; set; }
    }
}
