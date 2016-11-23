using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TutorCognitivoDS2.Startup))]
namespace TutorCognitivoDS2
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
