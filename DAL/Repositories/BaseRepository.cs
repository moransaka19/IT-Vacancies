using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Domain;

namespace DAL
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        protected readonly ApplicationContext dbContext;

        public BaseRepository(ApplicationContext context)
        {
            dbContext = context;
        }

        public IEnumerable<T> GetAll()
        {
            return dbContext.Set<T>();
        }

        public void Add(T item)
        {
            dbContext.Add(item);
            dbContext.SaveChanges();
        }


        public virtual void Update(T item)
        {
            dbContext.Entry(item).State = EntityState.Modified;
            dbContext.SaveChanges();
        }
    }
}
