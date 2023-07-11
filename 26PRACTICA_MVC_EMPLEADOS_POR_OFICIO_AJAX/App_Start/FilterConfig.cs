using System.Web;
using System.Web.Mvc;

namespace _26PRACTICA_MVC_EMPLEADOS_POR_OFICIO_AJAX
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
