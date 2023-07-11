using System.Web;
using System.Web.Mvc;

namespace _38PRACTICA_ADMIN_OBJETOS_EN_DIFERENTES_VISTAS_SEGURIDAD
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
