using Newtonsoft.Json;

namespace HH.Net.Models.VacancyModel
{
    public class Address
    {

        [JsonProperty("city")]
        public string? City { get; set; }

        [JsonProperty("street")]
        public string? Street { get; set; }

        [JsonProperty("building")]
        public string? Building { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("lat")]
        public double? Lat { get; set; }

        [JsonProperty("lng")]
        public double? Lng { get; set; }

        [JsonProperty("metro_stations")]
        public IList<MetroStation>? MetroStations { get; set; }
    }
}
