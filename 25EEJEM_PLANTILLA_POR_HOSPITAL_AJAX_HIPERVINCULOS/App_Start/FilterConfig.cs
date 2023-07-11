using System.Web;
using System.Web.Mvc;

namespace _25EEJEM_PLANTILLA_POR_HOSPITAL_AJAX_HIPERVINCULOS
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
