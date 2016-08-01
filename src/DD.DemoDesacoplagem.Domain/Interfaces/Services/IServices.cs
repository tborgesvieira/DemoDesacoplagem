using System;
using System.Collections.Generic;

namespace DD.DemoDesacoplagem.Domain.Interfaces.Services
{
    public interface IServices <T> : IDisposable where T : class 
    {
        T Add(T obj);
        T ObjectForId(object id);
        T Update(T obj);
        IEnumerable<T> GetAll();
    }
}