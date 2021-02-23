using Domain;

namespace DAL.Repositories
{
    public class RecruiterRepository : BaseRepository<Recruiter>
    {
        public RecruiterRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
