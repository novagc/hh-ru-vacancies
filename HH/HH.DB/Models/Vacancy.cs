using System;
using System.Collections.Generic;

namespace HH.DB.Models
{
    public partial class Vacancy
    {
        public int IdVacancy { get; set; }
        public string Name { get; set; } = null!;
        public int IdArea { get; set; }
        public decimal SalaryFrom { get; set; }
        public decimal SalaryTo { get; set; }
        public int SalaryCurrency { get; set; }
        public DateTime PublishedAt { get; set; }
        public string SnippetRequirement { get; set; } = null!;
        public string SnippetResponsibility { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string IdExperience { get; set; } = null!;

        public virtual Area IdAreaNavigation { get; set; } = null!;
        public virtual Experience IdExperienceNavigation { get; set; } = null!;
    }
}
