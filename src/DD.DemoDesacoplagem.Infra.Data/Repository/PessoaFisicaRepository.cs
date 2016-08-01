using System.Collections.Generic;
using System.Data.Entity.Core.Mapping;
using System.Linq;
using Dapper;
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

        public override IEnumerable<PessoaFisica> GetAll()
        {
            var cn = Db.Database.Connection;
            var sql = "SELECT t1.*, t2.* FROM PessoasFisicas t1 " +
                      "LEFT JOIN Pessoas t2 " +
                      "on t1.Id = T2.Id " +
                      "order by t2.DataCadastro";

            var pfs = cn.Query<PessoaFisica, Pessoa, PessoaFisica>(sql,
                (t1, t2) =>
                {
                    t1.Pessoa = t2;
                    return t1;
                },                
                splitOn: "Id, Id").ToList();

            return pfs;
        }
    }
}