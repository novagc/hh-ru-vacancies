using Newtonsoft.Json;

namespace HH.Net.Models.VacancyModel
{
    public class Phone
    {

        [JsonProperty("country")]
        public string? Country { get; set; }

        [JsonProperty("city")]
        public string? City { get; set; }

        [JsonProperty("number")]
        public string? Number { get; set; }

        [JsonProperty("comment")]
        public string? Comment { get; set; }
    }
}
