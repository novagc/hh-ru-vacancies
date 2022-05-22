using System;
using System.Collections.Generic;

namespace HH.DB.Models
{
    public partial class Experience
    {
        public Experience()
        {
            Vacancies = new HashSet<Vacancy>();
        }

        public string IdExperience { get; set; } = null!;
        public string Name { get; set; } = null!;

        public virtual ICollection<Vacancy> Vacancies { get; set; }
    }
}
