using System;
using System.Collections.Generic;

namespace HH.DB.Models
{
    public partial class Area
    {
        public Area()
        {
            Vacancies = new HashSet<Vacancy>();
        }

        public int IdArea { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Vacancy> Vacancies { get; set; }
    }
}
