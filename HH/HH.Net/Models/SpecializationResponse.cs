using HH.Net.Models.SpecializationModel;
using Newtonsoft.Json;

namespace HH.Net.Models
{
    public class SpecializationResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("specializations")]
        public IList<SpecializationItem> Specializations { get; set; }
    }
}
