using System.Web;
using System.Web.Mvc;

namespace _29PRACTICA_SESSION_EMP
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
