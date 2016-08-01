using System;
using System.Collections.Generic;

namespace DD.DemoDesacoplagem.Application.Interfaces
{
    public interface IAppService <T> : IDisposable where T : class
    {
        T Add(T obj);
        T ObjectForId(object id);
        IEnumerable<T> GetAll();
        T Update(T obj);
    }
}