using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace _33EJEM_INTERNACIONALIZACION_MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //ViewBag.Saludo = Resources.Saludos.TITULO;

            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
            ViewBag.Saludo =
                Resources.Saludos.TITULO;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
       
    }
}