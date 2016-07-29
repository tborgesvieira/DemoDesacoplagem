using AutoMapper;
using DD.DemoDesacoplagem.Application.ViewModels;
using DD.DemoDesacoplagem.Domain.Entities;

namespace DD.DemoDesacoplagem.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<PessoaPessoaFisicaViewModel, Pessoa>();
            CreateMap<PessoaPessoaFisicaViewModel, PessoaFisica>();
        }
    }
}