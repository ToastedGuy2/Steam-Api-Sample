using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Steam.Repositories.Generic
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public SteamDbContext _context;
        public DbSet<T> table;

        public GenericRepository(SteamDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            table = _context.Set<T>();
        }

        public virtual IEnumerable<T> GetAll()
        {
            return table;
        }

        public virtual T GetById(object id)
        {
            return table.Find(id);
        }

        public virtual void Insert(T obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            table.Add(obj);
        }

        public virtual void Update(T obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            table.Update(obj);
        }

        public virtual void Delete(object id)
        {

            var entityToDelete = table.Find(id);
            if (entityToDelete == null)
            {
                throw new ArgumentNullException(nameof(entityToDelete));
            }
            table.Remove(entityToDelete);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}