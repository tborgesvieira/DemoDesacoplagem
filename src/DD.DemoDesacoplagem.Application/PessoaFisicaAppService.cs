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

        public PessoaPessoaFisicaViewModel Add(PessoaPessoaFisicaViewModel pessoaPessoaFisicaViewModel)
        {
            var pessoaFisica = Mapper.Map<PessoaFisica>(pessoaPessoaFisicaViewModel);

            var pessoa = Mapper.Map<Pessoa>(pessoaPessoaFisicaViewModel);

            pessoaFisica.FkPessoa = pessoa;

            _pessoaFisicaServices.Add(pessoaFisica);            

            return pessoaPessoaFisicaViewModel;
        }

        public PessoaPessoaFisicaViewModel ObjectForId(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}