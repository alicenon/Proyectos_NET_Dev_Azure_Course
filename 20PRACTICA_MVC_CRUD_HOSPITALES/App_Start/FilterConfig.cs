using System.Web;
using System.Web.Mvc;

namespace _20PRACTICA_MVC_CRUD_HOSPITALES
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
