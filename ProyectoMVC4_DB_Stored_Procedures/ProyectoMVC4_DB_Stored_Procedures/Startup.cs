using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProyectoMVC4_DB_Stored_Procedures.Startup))]
namespace ProyectoMVC4_DB_Stored_Procedures
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
