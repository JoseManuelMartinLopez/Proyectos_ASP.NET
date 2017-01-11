using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProyectoMVC4conBD.Startup))]
namespace ProyectoMVC4conBD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
