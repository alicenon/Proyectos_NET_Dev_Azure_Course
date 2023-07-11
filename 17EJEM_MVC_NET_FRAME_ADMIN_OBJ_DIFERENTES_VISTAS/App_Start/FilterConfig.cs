using System.Web;
using System.Web.Mvc;

namespace _17EJEM_MVC_NET_FRAME_ADMIN_OBJ_DIFERENTES_VISTAS
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
