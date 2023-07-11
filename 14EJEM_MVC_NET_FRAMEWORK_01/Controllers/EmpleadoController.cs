using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _14EJEM_MVC_NET_FRAMEWORK_01.Controllers
{
    public class EmpleadoController : Controller
    {
        // GET: Empleado
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Inicio()
        {
            return View();
        }

        //POST: Empleado
       [HttpPost]
        public ActionResult Inicio(string txtnombre, string txtapellido, string txtedad)
        {
            ViewBag.Nombre = txtnombre;
            ViewBag.Apellido = txtapellido;
            ViewBag.Edad = txtedad;

            return View();
        }


        //[HttpPost]
        public ActionResult ResultadoInicio(string txtnombre, string txtapellido, string txtedad)
        {
            ViewBag.Nombre = txtnombre;
            ViewBag.Apellido = txtapellido;
            ViewBag.Edad = txtedad;

            return View();
        }
    }
}