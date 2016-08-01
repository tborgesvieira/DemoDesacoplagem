using System.Data.Entity.ModelConfiguration;
using DD.DemoDesacoplagem.Domain.Entities;

namespace DD.DemoDesacoplagem.Infra.Data.EntityConfig
{
    public class PessoaFisicaConfig : EntityTypeConfiguration<PessoaFisica>
    {
        public PessoaFisicaConfig()
        {
            HasKey(pf => pf.Id);

            Property(pf => pf.Cpf)
                .IsRequired()
                .HasMaxLength(11);

            HasRequired(pf => pf.Pessoa)
                .WithRequiredPrincipal(p => p.PessoaFisica);


            ToTable("PessoasFisicas");                                    
        }
    }
}