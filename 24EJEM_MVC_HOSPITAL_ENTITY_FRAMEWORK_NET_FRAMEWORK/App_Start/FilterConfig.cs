using System.Web;
using System.Web.Mvc;

namespace _24EJEM_MVC_HOSPITAL_ENTITY_FRAMEWORK_NET_FRAMEWORK
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
