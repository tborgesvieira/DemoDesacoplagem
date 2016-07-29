using AutoMapper;
using DD.DemoDesacoplagem.Application.ViewModels;
using DD.DemoDesacoplagem.Domain.Entities;

namespace DD.DemoDesacoplagem.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<Pessoa, PessoaPessoaFisicaViewModel>();
            CreateMap<PessoaFisica, PessoaPessoaFisicaViewModel>();
        }
    }
}