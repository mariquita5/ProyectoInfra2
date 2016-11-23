using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProyectoInfra2.Startup))]
namespace ProyectoInfra2
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
