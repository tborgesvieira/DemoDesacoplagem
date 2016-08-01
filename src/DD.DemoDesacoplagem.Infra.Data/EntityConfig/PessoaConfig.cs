using System.Data.Entity.ModelConfiguration;
using DD.DemoDesacoplagem.Domain.Entities;

namespace DD.DemoDesacoplagem.Infra.Data.EntityConfig
{
    public class PessoaConfig : EntityTypeConfiguration<Pessoa>
    {
        public PessoaConfig()
        {
            HasKey(p => p.Id);

            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(256);

            Property(p => p.Email)
                .IsRequired()
                .HasMaxLength(50);

            ToTable("Pessoas");
        }
    }
}