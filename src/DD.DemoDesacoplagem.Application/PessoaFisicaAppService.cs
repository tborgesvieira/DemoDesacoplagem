using System;
using System.Collections.Generic;
using AutoMapper;
using DD.DemoDesacoplagem.Application.Interfaces;
using DD.DemoDesacoplagem.Application.ViewModels;
using DD.DemoDesacoplagem.Domain.Entities;
using DD.DemoDesacoplagem.Domain.Interfaces.Services;
using DD.DemoDesacoplagem.Infra.CrossCutting.Identity.Configuration;
using DD.DemoDesacoplagem.Infra.CrossCutting.Identity.Model;
using DD.DemoDesacoplagem.Infra.Data.UnitOfWork;
using Microsoft.AspNet.Identity;

namespace DD.DemoDesacoplagem.Application
{
    public class PessoaFisicaAppService : AppService, IPessoaFisicaAppService
    {
        private readonly IPessoaFisicaServices _pessoaFisicaServices;
        private ApplicationSignInManager _signInManager;
        private ApplicationUserManager _userManager;

        public PessoaFisicaAppService(IUnitOfWork uow, IPessoaFisicaServices pessoaFisicaServices, ApplicationSignInManager signInManager, ApplicationUserManager userManager) : base(uow)
        {
            _pessoaFisicaServices = pessoaFisicaServices;
            _signInManager = signInManager;
            _userManager = userManager;
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

            pessoaFisica.Pessoa = pessoa;

            _pessoaFisicaServices.Update(pessoaFisica);          
            
            Commit();  

            return pessoaPessoaFisicaViewModel;
        }
       
        public PessoaPessoaFisicaViewModel Add(PessoaPessoaFisicaViewModel pessoaPessoaFisicaViewModel)
        {
            var user = new ApplicationUser { UserName = pessoaPessoaFisicaViewModel.CPF, Email = pessoaPessoaFisicaViewModel.Email };
            var result = _userManager.CreateAsync(user, pessoaPessoaFisicaViewModel.CPF.Substring(0,6));

            var pessoaFisica = Mapper.Map<PessoaFisica>(pessoaPessoaFisicaViewModel);

            var pessoa = Mapper.Map<Pessoa>(pessoaPessoaFisicaViewModel);                        

            pessoaFisica.Pessoa = pessoa;

            _pessoaFisicaServices.Add(pessoaFisica);            

            Commit();

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