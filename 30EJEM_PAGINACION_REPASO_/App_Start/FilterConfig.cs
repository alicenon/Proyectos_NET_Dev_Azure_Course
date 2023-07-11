using System.Web;
using System.Web.Mvc;

namespace _30EJEM_PAGINACION_REPASO_
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
