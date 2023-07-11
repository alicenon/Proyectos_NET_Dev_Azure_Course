using System.Web;
using System.Web.Mvc;

namespace _34PRACTICA_INTERNACIONALIZACION_REGISTRO_USUARIO_ES_EN
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
