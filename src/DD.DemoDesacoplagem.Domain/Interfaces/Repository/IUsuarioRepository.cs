using System;
using System.Collections.Generic;
using DD.DemoDesacoplagem.Domain.Entities;

namespace DD.DemoDesacoplagem.Domain.Interfaces.Repository
{
    public interface IUsuarioRepository : IDisposable
    {
        Usuario ObjectForId(string id);
        IEnumerable<Usuario> GetAll();
    }
}