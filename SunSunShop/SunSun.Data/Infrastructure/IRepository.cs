using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SunSun.Data.Infrastructure
{
    public interface IRepository<T> where T : class
    {
        T Add(T entity);

        // Marks an entity as modified
        void Update(T entity);

        // Marks an entity to be removed
        T Delete(T entity);

        T Delete(int id);
        // Get an entity by int id
        T GetSingleById(int id);
        IEnumerable<T> GetAll(string[] includes = null);


    }
}
