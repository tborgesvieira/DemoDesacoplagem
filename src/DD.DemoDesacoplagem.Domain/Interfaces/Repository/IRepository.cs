using System;

namespace DD.DemoDesacoplagem.Domain.Interfaces.Repository
{
    public interface IRepository<T> : IDisposable where T : class
    {
        T Add(T obj);
        T ObjectForId(object id);
    }
}