using HH.DB.Models;

namespace HH.WebApi
{
    public class VacancyResponse
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
        public List<Skill> Skills { get; set; } = null!;
        public List<Specialization> Specializations { get; set; } = null!;
    }
}
