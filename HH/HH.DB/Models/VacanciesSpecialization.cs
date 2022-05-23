namespace HH.DB.Models
{
    public partial class VacanciesSpecialization
    {
        public int IdVacancy { get; set; }
        public string IdSpecialization { get; set; } = null!;

        public virtual Specialization IdSpecializationNavigation { get; set; } = null!;
        public virtual Vacancy IdVacancyNavigation { get; set; } = null!;
    }
}
