using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HH.Net.Models.VacancyModel
{
    public class Experience
    {
        [JsonProperty("id")] public string Id { get; set; } = null!;

        [JsonProperty("name")] public string Name { get; set; } = null!;
    }
}
