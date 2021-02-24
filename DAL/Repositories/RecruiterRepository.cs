using DAL.Interfaces;
using Domain;

namespace DAL.Repositories
{
    public class RecruiterRepository : BaseRepository<Recruiter>, IRecruiterRepository
    {
        public RecruiterRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
