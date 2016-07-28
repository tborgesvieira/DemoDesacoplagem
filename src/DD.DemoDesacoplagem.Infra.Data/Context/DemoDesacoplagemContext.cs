using System;
using System.Data.Entity;
using System.Linq;
using DD.DemoDesacoplagem.Domain.Entities;
using DD.DemoDesacoplagem.Infra.Data.EntityConfig;

namespace DD.DemoDesacoplagem.Infra.Data.Context
{
    public class DemoDesacoplagemContext : DbContext
    {
        public DemoDesacoplagemContext()
            :base("DefaultConnection")
        {
            
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<PessoaFisica> PessoaFisicas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UsuarioConfig());

            modelBuilder.Ignore<Usuario>();

            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }
            }

            return base.SaveChanges();
        }

    }
}