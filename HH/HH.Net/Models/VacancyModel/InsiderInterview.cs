using Newtonsoft.Json;

namespace HH.Net.Models.VacancyModel
{
    public class InsiderInterview
    {

        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("url")]
        public string? Url { get; set; }
    }
}
