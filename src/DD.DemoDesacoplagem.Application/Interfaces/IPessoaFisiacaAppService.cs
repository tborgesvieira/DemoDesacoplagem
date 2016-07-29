using DD.DemoDesacoplagem.Application.ViewModels;

namespace DD.DemoDesacoplagem.Application.Interfaces
{
    public interface IPessoaFisiacaAppService
    {
        PessoaPessoaFisicaViewModel Add(PessoaPessoaFisicaViewModel pessoaPessoaFisicaViewModel);
        PessoaPessoaFisicaViewModel ObjectForId(int id);
    }
}