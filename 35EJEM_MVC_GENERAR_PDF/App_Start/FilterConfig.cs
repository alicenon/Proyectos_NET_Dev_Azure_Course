using System.Web;
using System.Web.Mvc;

namespace _35EJEM_MVC_GENERAR_PDF
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
