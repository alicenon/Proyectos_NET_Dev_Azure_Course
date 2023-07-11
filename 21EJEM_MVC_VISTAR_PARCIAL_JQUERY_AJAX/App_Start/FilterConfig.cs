using System.Web;
using System.Web.Mvc;

namespace _21EJEM_MVC_VISTAR_PARCIAL_JQUERY_AJAX
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
