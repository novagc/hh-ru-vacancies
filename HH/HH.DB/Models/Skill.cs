namespace HH.DB.Models
{
    public partial class Skill : IEquatable<Skill>
    {
        public int IdSkill { get; set; }
        public string Name { get; set; } = null!;

        public bool IsEqual(Skill o)
        {
            return Name == o.Name;
        }

        public bool Equals(Skill? other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Name == other.Name;
        }

        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Skill) obj);
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}
