using Newtonsoft.Json;

namespace HH.Net.Models.VacancyModel
{
    public class VacancyItem
    {

        [JsonProperty("salary")]
        public Salary? Salary { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("insider_interview")]
        public InsiderInterview? InsiderInterview { get; set; }

        [JsonProperty("area")]
        public Area? Area { get; set; }

        [JsonProperty("url")]
        public string? Url { get; set; }

        [JsonProperty("published_at")]
        public DateTime? PublishedAt { get; set; }

        [JsonProperty("relations")]
        public IList<object>? Relations { get; set; }

        [JsonProperty("employer")]
        public Employer? Employer { get; set; }

        [JsonProperty("contacts")]
        public Contacts? Contacts { get; set; }

        [JsonProperty("response_letter_required")]
        public bool? ResponseLetterRequired { get; set; }

        [JsonProperty("address")]
        public Address? Address { get; set; }

        [JsonProperty("sort_point_distance")]
        public double? SortPointDistance { get; set; }

        [JsonProperty("alternate_url")]
        public string? AlternateUrl { get; set; }

        [JsonProperty("apply_alternate_url")]
        public string? ApplyAlternateUrl { get; set; }

        [JsonProperty("department")]
        public Department? Department { get; set; }

        [JsonProperty("type")]
        public Type? Type { get; set; }

        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("has_test")]
        public bool? HasTest { get; set; }

        [JsonProperty("response_url")]
        public object? ResponseUrl { get; set; }

        [JsonProperty("snippet")]
        public Snippet? Snippet { get; set; }

        [JsonProperty("schedule")]
        public Schedule? Schedule { get; set; }

        [JsonProperty("counters")]
        public Counters? Counters { get; set; }
    }
}
