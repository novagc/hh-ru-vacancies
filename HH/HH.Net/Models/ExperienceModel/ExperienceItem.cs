using Newtonsoft.Json;

namespace HH.Net.Models.ExperienceModel
{
    /*
     * "experience": [
     *      {
     *          "id": "noExperience",
     *          "name": "Нет опыта"
     *      },
     *      {
     *          "id": "between1And3",
     *          "name": "От 1 года до 3 лет"
     *      },
     *      {
     *          "id": "between3And6",
     *          "name": "От 3 до 6 лет"
     *      },
     *      {
     *          "id": "moreThan6",
     *          "name": "Более 6 лет"
     *      }
     * ]
     */

    public class ExperienceItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
