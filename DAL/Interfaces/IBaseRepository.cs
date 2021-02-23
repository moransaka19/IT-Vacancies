using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public interface IBaseRepository<T>
    {
        IEnumerable<T> GetAll();
        void Add(T item);
        void Update(T item);
    }
}
