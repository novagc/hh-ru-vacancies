﻿using Newtonsoft.Json;

namespace HH.Net.Models.VacancyModel
{
    public class Schedule
    {

        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }
    }
}
