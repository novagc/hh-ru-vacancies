using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HH.Net.Models.VacancyModel
{
    public class DriverLicenseType
    {
        [JsonProperty("id")]
        public string? Id { get; set; }
    }
}
