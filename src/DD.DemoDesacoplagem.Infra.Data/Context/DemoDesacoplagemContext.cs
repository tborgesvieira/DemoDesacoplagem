using System.Data.Entity;
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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UsuarioConfig());

            base.OnModelCreating(modelBuilder);
        }
    }
}