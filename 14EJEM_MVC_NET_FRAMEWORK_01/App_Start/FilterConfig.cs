using System.Web;
using System.Web.Mvc;

namespace _14EJEM_MVC_NET_FRAMEWORK_01
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
