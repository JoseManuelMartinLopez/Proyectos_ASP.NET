using System.Web;
using System.Web.Mvc;

namespace ProyectoMVC4_DB_Stored_Procedures
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
