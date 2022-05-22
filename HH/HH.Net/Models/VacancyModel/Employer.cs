﻿using Newtonsoft.Json;

namespace HH.Net.Models.VacancyModel
{
    public class Employer
    {

        [JsonProperty("logo_urls")]
        public LogoUrls? LogoUrls { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("url")]
        public string? Url { get; set; }

        [JsonProperty("alternate_url")]
        public string? AlternateUrl { get; set; }

        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("trusted")]
        public bool? Trusted { get; set; }
    }
}
