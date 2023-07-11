using System.Web;
using System.Web.Mvc;

namespace _36EJEM_MVC_CONTROL_ERRORES
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
