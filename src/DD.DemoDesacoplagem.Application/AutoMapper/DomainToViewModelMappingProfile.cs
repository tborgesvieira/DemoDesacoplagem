using AutoMapper;
using DD.DemoDesacoplagem.Application.ViewModels;
using DD.DemoDesacoplagem.Domain.Entities;

namespace DD.DemoDesacoplagem.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<Pessoa, PessoaPessoaFisicaViewModel>()
                .ForMember(d => d.PessoaId, op => op.MapFrom(s => s.Id));
            CreateMap<PessoaFisica, PessoaPessoaFisicaViewModel>()
                .ForMember(d => d.PessoaFisicaId, op => op.MapFrom(s => s.Id));
        }
    }
}