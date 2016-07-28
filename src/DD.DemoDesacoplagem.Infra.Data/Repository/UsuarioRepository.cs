using System;
using System.Collections.Generic;
using System.Linq;
using DD.DemoDesacoplagem.Domain.Entities;
using DD.DemoDesacoplagem.Domain.Interfaces.Repository;
using DD.DemoDesacoplagem.Infra.Data.Context;

namespace DD.DemoDesacoplagem.Infra.Data.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly DemoDesacoplagemContext _db;

        public UsuarioRepository()
        {
            _db = new DemoDesacoplagemContext();
        }

        public Usuario ObjectForId(string id)
        {
            return _db.Usuarios.Find(id);
        }

        public IEnumerable<Usuario> GetAll()
        {
            return _db.Usuarios.ToList();
        }

        public void Dispose()
        {
            _db.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}