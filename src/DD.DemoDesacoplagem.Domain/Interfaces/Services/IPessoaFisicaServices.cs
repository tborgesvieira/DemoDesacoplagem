using System;
using DD.DemoDesacoplagem.Domain.Entities;

namespace DD.DemoDesacoplagem.Domain.Interfaces.Services
{
    public interface IPessoaFisicaServices : IDisposable
    {
        PessoaFisica Add(PessoaFisica pessoaFisica);
        PessoaFisica ObjectForId(object id);
    }
}