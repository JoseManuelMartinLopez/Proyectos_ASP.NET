using System.Web;
using System.Web.Mvc;

namespace ProyectoMVC4conBD
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
