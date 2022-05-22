using HH.Net.Models.VacancyModel;
using Newtonsoft.Json;

namespace HH.Net.Models
{
    public class VacancyResponse
    {

        [JsonProperty("per_page")]
        public int PerPage { get; set; }

        [JsonProperty("items")]
        public IList<VacancyItem> Items { get; set; } = null!;

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("found")]
        public int Found { get; set; }

        [JsonProperty("clusters")]
        public object? Clusters { get; set; }

        [JsonProperty("arguments")]
        public object? Arguments { get; set; }
    }
}
