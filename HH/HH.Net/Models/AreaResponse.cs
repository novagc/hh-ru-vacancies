using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HH.Net.Models
{
    public class AreaResponse
    {

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("parent_id")]
        public string? ParentId { get; set; }

        [JsonProperty("areas")]
        public IList<AreaResponse>? Areas { get; set; }
    }
}
