using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InfraProyecto.Startup))]
namespace InfraProyecto
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
