using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DD.DemoDesacoplagem.Domain.Interfaces.Repository;
using DD.DemoDesacoplagem.Infra.Data.Context;

namespace DD.DemoDesacoplagem.Infra.Data.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected DemoDesacoplagemContext Db;

        protected DbSet<T> DbSet;

        public Repository(DemoDesacoplagemContext context)
        {
            Db = context;

            DbSet = Db.Set<T>();
        }

        public T Add(T obj)
        {
            var ret = DbSet.Add(obj);

            Db.SaveChanges();

            return ret;
        }

        public T ObjectForId(object id)
        {
            return DbSet.Find(id);
        }

        public ICollection<T> GetAll()
        {
            return DbSet.ToList();
        }        

        public T Update(T obj)
        {
            var entry = Db.Entry(obj);
            DbSet.Attach(obj);
            entry.State = EntityState.Modified;

            return obj;
        }

        public int SaveChanges()
        {
            return Db.SaveChanges();
        }

        public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}