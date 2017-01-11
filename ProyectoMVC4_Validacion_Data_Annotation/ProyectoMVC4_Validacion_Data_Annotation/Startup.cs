using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProyectoMVC4_Validacion_Data_Annotation.Startup))]
namespace ProyectoMVC4_Validacion_Data_Annotation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
