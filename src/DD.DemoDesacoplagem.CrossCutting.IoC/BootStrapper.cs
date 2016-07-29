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
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SimpleInjector;

namespace DD.DemoDesacoplagem.Infra.CrossCutting.IoC
{
    public class BootStrapper
    {
        public static void RegisterServices(Container container)
        {
            container.RegisterPerWebRequest<ApplicationDbContext>();
            container.RegisterPerWebRequest<IUserStore<ApplicationUser>>(() => new UserStore<ApplicationUser>(new ApplicationDbContext()));
            container.RegisterPerWebRequest<IRoleStore<IdentityRole, string>>(() => new RoleStore<IdentityRole>());
            container.RegisterPerWebRequest<ApplicationRoleManager>();
            container.RegisterPerWebRequest<ApplicationUserManager>();
            container.RegisterPerWebRequest<ApplicationSignInManager>();

            container.Register<DemoDesacoplagemContext>(Lifestyle.Scoped);

            container.Register<IUsuarioRepository, UsuarioRepository>(Lifestyle.Scoped);

            container.Register<IPessoaFisiacaAppService, PessoaFisicaAppService>(Lifestyle.Scoped);

            container.Register<IPessoaFisicaServices, PessoaFisicaServices>(Lifestyle.Scoped);

            container.Register<IPessoaFisicaRepository, PessoaFisicaRepository>(Lifestyle.Scoped);
        }
    }
}
