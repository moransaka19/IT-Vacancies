
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Company : BaseEntity
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public Recruiter Recruiter { get; set; }

        public IEnumerable<Vacancy> Vacancies { get; set; }
        public IEnumerable<Recruiter> Recruiters { get; set; }

        public Company()
        {
            Vacancies = new List<Vacancy>();
            Recruiters = new List<Recruiter>();
        }

    }
}
