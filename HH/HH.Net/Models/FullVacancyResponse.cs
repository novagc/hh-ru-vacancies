using Newtonsoft.Json;
using HH.Net.Models.VacancyModel;

namespace HH.Net.Models
{
    public class FullVacancyResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; } = null!;

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("branded_description")]
        public string? BrandedDescription { get; set; }

        [JsonProperty("key_skills")]
        public IList<KeySkill>? KeySkills { get; set; }

        [JsonProperty("schedule")]
        public Schedule? Schedule { get; set; }

        [JsonProperty("accept_handicapped")]
        public bool? AcceptHandicapped { get; set; }

        [JsonProperty("accept_kids")]
        public bool? AcceptKids { get; set; }

        [JsonProperty("experience")]
        public Experience? Experience { get; set; }

        [JsonProperty("address")]
        public Address? Address { get; set; }

        [JsonProperty("alternate_url")]
        public string? AlternateUrl { get; set; }

        [JsonProperty("apply_alternate_url")]
        public string? ApplyAlternateUrl { get; set; }

        [JsonProperty("code")]
        public string? Code { get; set; }

        [JsonProperty("department")]
        public Department? Department { get; set; }

        [JsonProperty("employment")]
        public Employment? Employment { get; set; }

        [JsonProperty("salary")]
        public Salary? Salary { get; set; }

        [JsonProperty("archived")]
        public bool? Archived { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("insider_interview")]
        public InsiderInterview? InsiderInterview { get; set; }

        [JsonProperty("area")]
        public Area? Area { get; set; }

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("published_at")]
        public DateTime? PublishedAt { get; set; }

        [JsonProperty("employer")]
        public Employer? Employer { get; set; }

        [JsonProperty("response_letter_required")]
        public bool? ResponseLetterRequired { get; set; }

        [JsonProperty("type")]
        public VacancyModel.Type? Type { get; set; }

        [JsonProperty("has_test")]
        public bool? HasTest { get; set; }

        [JsonProperty("response_url")]
        public object? ResponseUrl { get; set; }

        [JsonProperty("test")]
        public Test? Test { get; set; }

        [JsonProperty("specializations")]
        public IList<Specialization>? Specializations { get; set; }

        [JsonProperty("contacts")]
        public Contacts? Contacts { get; set; }

        [JsonProperty("billing_type")]
        public BillingType? BillingType { get; set; }

        [JsonProperty("allow_messages")]
        public bool? AllowMessages { get; set; }

        [JsonProperty("premium")]
        public bool? Premium { get; set; }

        [JsonProperty("driver_license_types")]
        public IList<DriverLicenseType>? DriverLicenseTypes { get; set; }

        [JsonProperty("accept_incomplete_resumes")]
        public bool? AcceptIncompleteResumes { get; set; }

        [JsonProperty("working_days")]
        public IList<WorkingDay>? WorkingDays { get; set; }

        [JsonProperty("working_time_intervals")]
        public IList<WorkingTimeInterval>? WorkingTimeIntervals { get; set; }

        [JsonProperty("working_time_modes")]
        public IList<WorkingTimeMode>? WorkingTimeModes { get; set; }

        [JsonProperty("accept_temporary")]
        public bool? AcceptTemporary { get; set; }

        [JsonProperty("professional_roles")]
        public IList<ProfessionalRole>? ProfessionalRoles { get; set; }
    }
}
