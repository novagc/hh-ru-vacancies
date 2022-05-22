using Newtonsoft.Json;

namespace HH.Net.Models.VacancyModel
{
    public class Counters
    {

        [JsonProperty("responses")]
        public int? Responses { get; set; }
    }
}
