using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace _34PRACTICA_INTERNACIONALIZACION_REGISTRO_USUARIO_ES_EN.Controllers
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

        public ActionResult Contact(string lang)
        {
            
            ViewBag.Message = "Your contact page.";
            //
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(lang);
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(lang);
            //
            ViewBag.Nombre = Resources.Formulario.NOMBRE;
            ViewBag.Apellido1 = Resources.Formulario.PRIMERAPELLIDO;
            ViewBag.Apellido2 = Resources.Formulario.SEGUNDOAPELLIDO;

            //PARA LOS PLACEHOLDERS LA MISMA IDEA
            ViewBag.PholderNombre = Resources.Formulario.PLACEHOLDERNOMBRE;
            ViewBag.PholderPrimero = Resources.Formulario.PLACEHOLDERPRIMER;
            ViewBag.PholderSegundo = Resources.Formulario.PLACEHOLDERSEGUNDO;

           
         
            return View();
        }
    }
}