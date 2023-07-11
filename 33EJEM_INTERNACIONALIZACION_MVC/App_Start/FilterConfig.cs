using System.Web;
using System.Web.Mvc;

namespace _33EJEM_INTERNACIONALIZACION_MVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
