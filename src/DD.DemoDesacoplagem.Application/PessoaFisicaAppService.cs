using System;
using System.Collections.Generic;
using AutoMapper;
using DD.DemoDesacoplagem.Application.Interfaces;
using DD.DemoDesacoplagem.Application.ViewModels;
using DD.DemoDesacoplagem.Domain.Entities;
using DD.DemoDesacoplagem.Domain.Interfaces.Services;
using DD.DemoDesacoplagem.Infra.Data.UnitOfWork;

namespace DD.DemoDesacoplagem.Application
{
    public class PessoaFisicaAppService : IPessoaFisicaAppService
    {
        private readonly IPessoaFisicaServices _pessoaFisicaServices;
        private readonly IPessoaServices _pessoaServices;

        public PessoaFisicaAppService(IPessoaFisicaServices pessoaFisicaServices, IPessoaServices pessoaServices)
        {
            _pessoaFisicaServices = pessoaFisicaServices;
            _pessoaServices = pessoaServices;
        }

        public IEnumerable<PessoaPessoaFisicaViewModel> GetAll()
        {

            var pfs = _pessoaFisicaServices.GetAll();

            return Mapper.Map<IEnumerable<PessoaPessoaFisicaViewModel>>(pfs);
        }

        public PessoaPessoaFisicaViewModel Update(PessoaPessoaFisicaViewModel pessoaPessoaFisicaViewModel)
        {
            var pessoaFisica = Mapper.Map<PessoaFisica>(pessoaPessoaFisicaViewModel);

            var pessoa = Mapper.Map<Pessoa>(pessoaPessoaFisicaViewModel);

            pessoaFisica.FkPessoa = pessoa;

            _pessoaFisicaServices.Update(pessoaFisica);            

            return pessoaPessoaFisicaViewModel;
        }

        public PessoaPessoaFisicaViewModel Add(PessoaPessoaFisicaViewModel pessoaPessoaFisicaViewModel)
        {
            var pessoaFisica = Mapper.Map<PessoaFisica>(pessoaPessoaFisicaViewModel);

            var pessoa = Mapper.Map<Pessoa>(pessoaPessoaFisicaViewModel);            

            pessoaFisica.FkPessoa = pessoa;            

            _pessoaFisicaServices.Add(pessoaFisica);            

            return pessoaPessoaFisicaViewModel;
        }

        public PessoaPessoaFisicaViewModel ObjectForId(object id)
        {
            var pf = _pessoaFisicaServices.ObjectForId(id);

            return Mapper.Map<PessoaPessoaFisicaViewModel>(pf);
        }

        public void Dispose()
        {
            _pessoaFisicaServices.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}