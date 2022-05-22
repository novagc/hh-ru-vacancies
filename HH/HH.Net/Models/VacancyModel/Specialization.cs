using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HH.Net.Models.VacancyModel
{
    public class Specialization
    {
        [JsonProperty("profarea_id")]
        public string? ProfAreaId { get; set; }

        [JsonProperty("profarea_name")]
        public string? ProfAreaName { get; set; }

        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }
    }
}
