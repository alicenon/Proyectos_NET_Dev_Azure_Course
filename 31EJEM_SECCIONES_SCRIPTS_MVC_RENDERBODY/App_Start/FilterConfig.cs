using System.Web;
using System.Web.Mvc;

namespace _31EJEM_SECCIONES_SCRIPTS_MVC_RENDERBODY
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
