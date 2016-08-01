using System;
using System.Collections.Generic;
using DD.DemoDesacoplagem.Domain.Entities;
using DD.DemoDesacoplagem.Domain.Interfaces.Repository;
using DD.DemoDesacoplagem.Domain.Interfaces.Services;

namespace DD.DemoDesacoplagem.Domain.Services
{
    public class PessoaServices : IPessoaServices
    {
        private readonly IPessoaRepository _pessoaRepository;

        public PessoaServices(IPessoaRepository pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }

        public Pessoa Add(Pessoa pessoa)
        {
            return _pessoaRepository.Add(pessoa);
        }

        public Pessoa ObjectForId(object id)
        {
            return _pessoaRepository.ObjectForId(id);
        }

        public Pessoa Update(Pessoa obj)
        {
            return _pessoaRepository.Update(obj);
        }

        public ICollection<Pessoa> GetAll()
        {
            return _pessoaRepository.GetAll();
        }

        public void Dispose()
        {
            _pessoaRepository.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}