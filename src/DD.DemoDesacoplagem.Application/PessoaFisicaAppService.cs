﻿using System.Collections.Generic;
using AutoMapper;
using DD.DemoDesacoplagem.Application.Interfaces;
using DD.DemoDesacoplagem.Application.ViewModels;
using DD.DemoDesacoplagem.Domain.Entities;
using DD.DemoDesacoplagem.Domain.Interfaces.Services;

namespace DD.DemoDesacoplagem.Application
{
    public class PessoaFisicaAppService : IPessoaFisiacaAppService
    {
        private readonly IPessoaFisicaServices _pessoaFisicaServices;

        public PessoaFisicaAppService(IPessoaFisicaServices pessoaFisicaServices)
        {
            _pessoaFisicaServices = pessoaFisicaServices;
        }

        public ICollection<PessoaPessoaFisicaViewModel> GetAll()
        {
            return Mapper.Map<ICollection<PessoaPessoaFisicaViewModel>>(_pessoaFisicaServices.GetAll());
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
            return Mapper.Map<PessoaPessoaFisicaViewModel>(_pessoaFisicaServices.ObjectForId(id));
        }
    }
}