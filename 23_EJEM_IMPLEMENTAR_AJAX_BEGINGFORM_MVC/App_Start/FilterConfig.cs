using System.Web;
using System.Web.Mvc;

namespace _23_EJEM_IMPLEMENTAR_AJAX_BEGINGFORM_MVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
