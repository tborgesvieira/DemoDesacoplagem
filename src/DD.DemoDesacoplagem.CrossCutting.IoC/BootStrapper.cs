using DD.DemoDesacoplagem.Application;
using DD.DemoDesacoplagem.Application.Interfaces;
using DD.DemoDesacoplagem.Domain.Entities;
using DD.DemoDesacoplagem.Infra.CrossCutting.Identity.Configuration;
using DD.DemoDesacoplagem.Infra.CrossCutting.Identity.Context;
using DD.DemoDesacoplagem.Infra.CrossCutting.Identity.Model;
using DD.DemoDesacoplagem.Domain.Interfaces.Repository;
using DD.DemoDesacoplagem.Domain.Interfaces.Services;
using DD.DemoDesacoplagem.Domain.Services;
using DD.DemoDesacoplagem.Infra.Data.Context;
using DD.DemoDesacoplagem.Infra.Data.Repository;
using DD.DemoDesacoplagem.Infra.Data.UnitOfWork;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SimpleInjector;

namespace DD.DemoDesacoplagem.Infra.CrossCutting.IoC
{
    public class BootStrapper
    {
        public static void RegisterServices(Container container)
        {
            container.Register<ApplicationDbContext>();
            container.Register<IUserStore<ApplicationUser>>(() => new UserStore<ApplicationUser>(new ApplicationDbContext()));
            container.Register<IRoleStore<IdentityRole, string>>(() => new RoleStore<IdentityRole>());
            container.Register<ApplicationRoleManager>();
            container.Register<ApplicationUserManager>();
            container.Register<ApplicationSignInManager>();

            //AppServices            
            container.Register<IPessoaFisicaAppService, PessoaFisicaAppService>(Lifestyle.Scoped);

            //Service
            container.Register<IPessoaServices, PessoaServices>(Lifestyle.Scoped);
            container.Register<IPessoaFisicaServices, PessoaFisicaServices>(Lifestyle.Scoped);

            //Repository
            container.Register<IUsuarioRepository, UsuarioRepository>(Lifestyle.Scoped);
            container.Register<IPessoaFisicaRepository, PessoaFisicaRepository>(Lifestyle.Scoped);
            container.Register<IPessoaRepository, PessoaRepository>(Lifestyle.Scoped);

            //UnitOfWork
            container.Register<IUnitOfWork, UnitOfWork>(Lifestyle.Scoped);

            //Context
            container.Register<DemoDesacoplagemContext>(Lifestyle.Scoped);
        }
    }
}
