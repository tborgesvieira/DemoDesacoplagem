using DD.DemoDesacoplagem.Domain.Entities;
using DD.DemoDesacoplagem.Domain.Interfaces.Repository;
using DD.DemoDesacoplagem.Infra.Data.Context;

namespace DD.DemoDesacoplagem.Infra.Data.Repository
{
    public class PessoaFisicaRepository : Repository<PessoaFisica>, IPessoaFisicaRepository
    {
        public PessoaFisicaRepository(DemoDesacoplagemContext context) 
            : base(context)
        {

        }
    }
}