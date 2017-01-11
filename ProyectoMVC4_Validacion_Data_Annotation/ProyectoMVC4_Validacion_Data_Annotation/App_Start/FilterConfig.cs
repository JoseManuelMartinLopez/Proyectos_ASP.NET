using System.Web;
using System.Web.Mvc;

namespace ProyectoMVC4_Validacion_Data_Annotation
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
