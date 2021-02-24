using DAL.Interfaces;
using Domain;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace DAL.Repositories
{
    public class VacancyRepository : BaseRepository<Vacancy>, IVacancyRepository
    {
        public VacancyRepository(ApplicationContext context) : base(context)
        {
        }

        public override IEnumerable<Vacancy> GetAll() 
        {
            return dbContext.Vacancies.Include(x => x.Company).Include(x => x.Recruiter);
        }
    }
}
