using System.Text.Json.Serialization;

namespace HH.DB.Models
{
    public partial class Experience : IEquatable<Experience>
    {
        public Experience()
        {
            Vacancies = new HashSet<Vacancy>();
        }

        public string IdExperience { get; set; } = null!;
        public string Name { get; set; } = null!;

        [JsonIgnore]
        public virtual ICollection<Vacancy>? Vacancies { get; set; }

        public bool Equals(Experience? other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return IdExperience == other.IdExperience;
        }

        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Experience) obj);
        }

        public override int GetHashCode()
        {
            return IdExperience.GetHashCode();
        }
    }
}
