using Newtonsoft.Json;

namespace HH.Net.Models.VacancyModel
{
    public class LogoUrls
    {

        [JsonProperty("90")]
        public string? Logo90 { get; set; }

        [JsonProperty("240")]
        public string? Logo240 { get; set; }

        [JsonProperty("original")]
        public string? Original { get; set; }
    }
}
