using Newtonsoft.Json;

namespace HH.Net.Models.SpecializationModel
{
    public class SpecializationItem
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("laboring")]
        public bool Laboring { get; set; }
    }
}
