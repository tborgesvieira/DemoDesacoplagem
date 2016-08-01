using System.Collections.Generic;
using System.Linq;
using Dapper;
using DD.DemoDesacoplagem.Domain.Entities;
using DD.DemoDesacoplagem.Domain.Interfaces.Repository;
using DD.DemoDesacoplagem.Infra.Data.Context;
using Dapper;

namespace DD.DemoDesacoplagem.Infra.Data.Repository
{
    public class PessoaRepository : Repository<Pessoa>, IPessoaRepository
    {
        public PessoaRepository(DemoDesacoplagemContext context) 
            : base(context)
        {
        }        
    }
}