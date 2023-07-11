using System.Web;
using System.Web.Mvc;

namespace _27EJEM_SESION_CESTA_EMP
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
