using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public interface IVacancyService
    {
        IEnumerable<Vacancy> GetAllVacansies();
        Recruiter GetRecruterByVacancy(Vacancy vacancy);
        Company GetCompanyByVacancy(Vacancy vacancy);

    }
}
