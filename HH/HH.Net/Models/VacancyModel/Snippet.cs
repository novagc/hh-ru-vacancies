using Newtonsoft.Json;

namespace HH.Net.Models.VacancyModel
{
    public class Snippet
    {

        [JsonProperty("requirement")]
        public string? Requirement { get; set; }

        [JsonProperty("responsibility")]
        public string? Responsibility { get; set; }
    }
}
