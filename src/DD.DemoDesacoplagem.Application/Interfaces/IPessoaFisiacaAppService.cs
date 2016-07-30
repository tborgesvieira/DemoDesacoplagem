using System.Collections.Generic;
using DD.DemoDesacoplagem.Application.ViewModels;

namespace DD.DemoDesacoplagem.Application.Interfaces
{
    public interface IPessoaFisiacaAppService
    {
        PessoaPessoaFisicaViewModel Add(PessoaPessoaFisicaViewModel pessoaPessoaFisicaViewModel);
        PessoaPessoaFisicaViewModel ObjectForId(object id);
        ICollection<PessoaPessoaFisicaViewModel> GetAll();
        PessoaPessoaFisicaViewModel Update(PessoaPessoaFisicaViewModel pessoaPessoaFisicaViewModel);
    }
}