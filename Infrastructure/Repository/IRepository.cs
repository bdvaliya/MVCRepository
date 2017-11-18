using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IQueryable<TEntity> getAll();
        TEntity getById(int id);
    }

    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class 
    {
        private readonly AppUserEntities db;
        private readonly DbSet dbSet;

        public Repository(AppUserEntities _db)
        {
            db = _db;
            dbSet = db.Set<TEntity>();
        }

        public IQueryable<TEntity> getAll()
        {
            return (IQueryable<TEntity>) dbSet;
        }
        public TEntity getById(int id)
        {
            return (TEntity)dbSet.Find(id);
        }
    }
}
