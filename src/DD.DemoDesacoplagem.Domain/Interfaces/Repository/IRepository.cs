using System;
using System.Collections.Generic;

namespace DD.DemoDesacoplagem.Domain.Interfaces.Repository
{
    public interface IRepository<T> : IDisposable where T : class
    {
        T Add(T obj);
        T Update(T obj);
        T ObjectForId(object id);
        ICollection<T> GetAll();
        int SaveChanges();
    }
}