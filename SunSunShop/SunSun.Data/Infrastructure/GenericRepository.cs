using SunSun.Model.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SunSun.Data.Infrastructure
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        internal SunSunDbContext context;
        internal DbSet<T> dbSet;
        public GenericRepository(SunSunDbContext context)
        {
            this.context = context;
            dbSet = context.Set<T>();
        }
        public virtual T Add(T entity)
        {
           return dbSet.Add(entity);

        }

        public virtual T Delete(T entity)
        {
            return dbSet.Remove(entity);
        }

        public virtual T Delete(int id)
        {
            var entity = dbSet.Find(id);
            return dbSet.Remove(entity);
        }

        public IEnumerable<T> GetAll(string[] includes = null)
        {
            if (includes != null && includes.Count() > 0)
            {
                var query = context.Set<T>().Include(includes.First());
                foreach (var include in includes.Skip(1))
                    query = query.Include(include);
                return query.AsQueryable();
            }

            return context.Set<T>().AsQueryable();
        }

        public virtual T GetSingleById(int id)
        {
            return dbSet.Find(id);
        }

        public virtual void Update(T entity)
        {
            dbSet.Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
        }
    }
}
