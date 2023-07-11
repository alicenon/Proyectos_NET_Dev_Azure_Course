using System.Web;
using System.Web.Mvc;

namespace _32PRACTICA_CONTROL_MASTER_PAGES
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
