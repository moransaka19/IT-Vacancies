using Domain;

namespace DAL.Repositories
{
    public class VacancyRepository : BaseRepository<Vacancy>
    {
        public VacancyRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
