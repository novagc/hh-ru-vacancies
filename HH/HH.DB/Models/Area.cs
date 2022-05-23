namespace HH.DB.Models
{
    public partial class Area : IEquatable<Area>
    {
        public Area()
        {
            Vacancies = new HashSet<Vacancy>();
        }

        public int IdArea { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Vacancy> Vacancies { get; set; }

        public bool Equals(Area? other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return IdArea == other.IdArea;
        }

        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Area) obj);
        }

        public override int GetHashCode()
        {
            return IdArea;
        }
    }
}
