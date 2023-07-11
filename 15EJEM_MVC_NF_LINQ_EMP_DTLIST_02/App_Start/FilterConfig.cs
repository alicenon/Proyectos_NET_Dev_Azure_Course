using System.Web;
using System.Web.Mvc;

namespace _15EJEM_MVC_NF_LINQ_EMP_DTLIST_02
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
