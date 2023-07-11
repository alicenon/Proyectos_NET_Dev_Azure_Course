using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _14EJEM_MVC_NET_FRAMEWORK_01.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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
        public ActionResult VistaDatos(String aplicacion, String tecnologia, int? version)
        {
            ViewBag.Aplicacion = aplicacion;
            ViewBag.Tecnologia = tecnologia;
            ViewBag.Version = version;
            return View();
        }
        public ActionResult vistaPost()
        {
            return View();
        }


        [HttpPost]
        public ActionResult vistaPost(string txtmarca, string txtmodelo)
        {
            ViewBag.Marca = txtmarca;
            ViewBag.Modelo = txtmodelo;
            return View();
        }
        public ActionResult Inicio()
        {
            return View();
        }


    }
}