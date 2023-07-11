using System.Web;
using System.Web.Mvc;

namespace _19EJEM_MVC_CRUD_MATENIMIENTO_DEPT
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
