using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories
{
    public class CompanyRepository : BaseRepository<Company>
    {
        public CompanyRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
