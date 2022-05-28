using System.Text.Json.Serialization;

namespace HH.DB.Models
{
    public partial class VacanciesSkill
    {
        public int IdVacancy { get; set; }
        public int IdSkill { get; set; }

        [JsonIgnore]
        public virtual Skill? IdSkillNavigation { get; set; } = null!;
        [JsonIgnore]
        public virtual Vacancy? IdVacancyNavigation { get; set; } = null!;
    }
}
