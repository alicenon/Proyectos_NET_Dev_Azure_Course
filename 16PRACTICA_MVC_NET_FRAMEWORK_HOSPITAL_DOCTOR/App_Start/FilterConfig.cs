using System.Web;
using System.Web.Mvc;

namespace _16PRACTICA_MVC_NET_FRAMEWORK_HOSPITAL_DOCTOR
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
