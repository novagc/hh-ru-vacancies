using Newtonsoft.Json;

namespace HH.Net.Models.VacancyModel
{
    public class Type
    {

        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }
    }
}
