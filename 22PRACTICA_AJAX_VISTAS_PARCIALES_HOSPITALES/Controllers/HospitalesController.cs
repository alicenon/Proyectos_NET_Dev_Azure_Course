using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using _22PRACTICA_AJAX_VISTAS_PARCIALES_HOSPITALES;
namespace _22PRACTICA_AJAX_VISTAS_PARCIALES_HOSPITALES.Controllers
{
    public class HospitalesController : Controller
    {
        // GET: Hospitales
        public ActionResult Index()
        {
            Models.ModeloHospital modelo = new Models.ModeloHospital();
            List<Models.HOSPITAL> lista = modelo.GetHospitales();
            return View(lista);
        }
    }
}