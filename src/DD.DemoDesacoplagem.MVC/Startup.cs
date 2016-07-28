using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DD.DemoDesacoplagem.MVC.Startup))]
namespace DD.DemoDesacoplagem.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
