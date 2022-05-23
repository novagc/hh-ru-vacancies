namespace HH.DB.Models
{
    public partial class Specialization : IEquatable<Specialization>
    {
        public string IdSpecialization { get; set; } = null!;
        public string Name { get; set; } = null!;

        public bool Equals(Specialization? other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return IdSpecialization == other.IdSpecialization;
        }

        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Specialization) obj);
        }

        public override int GetHashCode()
        {
            return IdSpecialization.GetHashCode();
        }
    }
}
