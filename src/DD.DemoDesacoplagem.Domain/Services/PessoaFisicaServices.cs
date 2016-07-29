using System;
using DD.DemoDesacoplagem.Domain.Entities;
using DD.DemoDesacoplagem.Domain.Interfaces.Repository;
using DD.DemoDesacoplagem.Domain.Interfaces.Services;

namespace DD.DemoDesacoplagem.Domain.Services
{
    public class PessoaFisicaServices : IPessoaFisicaServices
    {
        private readonly IPessoaFisicaRepository _pessoaFisicaRepository;

        public PessoaFisicaServices(IPessoaFisicaRepository pessoaFisicaRepository)
        {
            _pessoaFisicaRepository = pessoaFisicaRepository;
        }
     
        public PessoaFisica Add(PessoaFisica pessoaFisica)
        {
            return _pessoaFisicaRepository.Add(pessoaFisica);
        }

        public PessoaFisica ObjectForId(object id)
        {
            return _pessoaFisicaRepository.ObjectForId(id);
        }

        public void Dispose()
        {
            _pessoaFisicaRepository.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}