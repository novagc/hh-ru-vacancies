using System.Diagnostics;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HH.DB.Models
{
    public partial class Vacancy : IEquatable<Vacancy>
    {
        public int IdVacancy { get; set; }
        public string Name { get; set; } = null!;
        public int IdArea { get; set; }
        public decimal? SalaryFrom { get; set; }
        public decimal? SalaryTo { get; set; }
        public string? SalaryCurrency { get; set; }
        public DateTime PublishedAt { get; set; }
        public string? SnippetRequirement { get; set; }
        public string? SnippetResponsibility { get; set; }
        public string Description { get; set; } = null!;
        public string IdExperience { get; set; } = null!;

        [JsonIgnore]
        public virtual Area? IdAreaNavigation { get; set; } = null!;
        [JsonIgnore]
        public virtual Experience? IdExperienceNavigation { get; set; } = null!;

        public bool Equals(Vacancy? other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            Debug.WriteLine("!!!!");
            return IdVacancy == other.IdVacancy;
        }

        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Vacancy) obj);
        }

        public override int GetHashCode()
        {
            return IdVacancy;
        }
    }
}
