using Newtonsoft.Json;

namespace HH.Net.Models.VacancyModel
{
    public class Salary
    {

        [JsonProperty("to")]
        public int? To { get; set; }

        [JsonProperty("from")]
        public int? From { get; set; }

        [JsonProperty("currency")]
        public string? Currency { get; set; }

        [JsonProperty("gross")]
        public bool? Gross { get; set; }
    }
}
