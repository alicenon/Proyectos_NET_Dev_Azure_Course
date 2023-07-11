using System.Web;
using System.Web.Mvc;

namespace _18PRACTICA_MVC_NET_FRAME_PLANTILLA_POR_HOSPITAL
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
