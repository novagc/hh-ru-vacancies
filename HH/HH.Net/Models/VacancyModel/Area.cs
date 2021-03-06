using Newtonsoft.Json;

namespace HH.Net.Models.VacancyModel
{
    public class Area
    {

        [JsonProperty("url")]
        public string? Url { get; set; }

        [JsonProperty("id")] public string Id { get; set; } = null!;

        [JsonProperty("name")] public string Name { get; set; } = null!;
    }
}
