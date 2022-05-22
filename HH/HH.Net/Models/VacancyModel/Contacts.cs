using Newtonsoft.Json;

namespace HH.Net.Models.VacancyModel
{
    public class Contacts
    {

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("email")]
        public string? Email { get; set; }

        [JsonProperty("phones")]
        public IList<Phone>? Phones { get; set; }
    }
}
