using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HH.Net.Models.VacancyModel
{
    public class Test
    {
        [JsonProperty("required")]
        public bool Required { get; set; }
    }
}
