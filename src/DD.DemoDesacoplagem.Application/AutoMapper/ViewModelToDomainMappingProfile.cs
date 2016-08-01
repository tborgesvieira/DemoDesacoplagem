using AutoMapper;
using DD.DemoDesacoplagem.Application.ViewModels;
using DD.DemoDesacoplagem.Domain.Entities;

namespace DD.DemoDesacoplagem.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<PessoaPessoaFisicaViewModel, PessoaFisica>()
                .ForMember(d=>d.Id, op=>op.MapFrom(s=>s.PessoaFisicaId));
            CreateMap<PessoaPessoaFisicaViewModel, Pessoa>()
                .ForMember(d => d.Id, op => op.MapFrom(s => s.PessoaId));
        }
    }
}