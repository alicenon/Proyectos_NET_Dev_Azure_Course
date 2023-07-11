using System.Web;
using System.Web.Mvc;

namespace _28EJEM_ALMACENAR_EMPLEADO_SESSION_SIMPLE
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
