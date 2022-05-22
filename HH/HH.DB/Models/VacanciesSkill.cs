using System;
using System.Collections.Generic;

namespace HH.DB.Models
{
    public partial class VacanciesSkill
    {
        public int IdVacancy { get; set; }
        public int IdSkill { get; set; }

        public virtual Skill IdSkillNavigation { get; set; } = null!;
        public virtual Vacancy IdVacancyNavigation { get; set; } = null!;
    }
}
