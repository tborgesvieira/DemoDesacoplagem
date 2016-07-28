using System.Data.Entity.Migrations;
using DD.DemoDesacoplagem.Infra.Data.Context;

namespace DD.DemoDesacoplagem.Infra.Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<DemoDesacoplagemContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(DemoDesacoplagemContext context)
        {
        }
    }
}
