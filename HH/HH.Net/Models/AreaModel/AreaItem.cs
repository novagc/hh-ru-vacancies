using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HH.Net.Models.AreaModel
{
    public class AreaItem
    {
        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("id")]
        public string? Id { get; set; }

        public AreaItem()
        {

        }

        public AreaItem(AreaResponse response)
        {
            Id = response.Id;
            Name = response.Name;
        }
    }
}
