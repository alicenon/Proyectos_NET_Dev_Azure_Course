using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _17EJEM_MVC_NET_FRAME_ADMIN_OBJ_DIFERENTES_VISTAS.Controllers
{
    public class HospitalesController : Controller
    {
        // GET: Hospitales
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ListaHospitales()
        {
            Models.ModeloHospital modelo = new Models.ModeloHospital();
            List<Models.HOSPITAL> lista = modelo.GetHospitales();
            return View(lista);
        }

        public ActionResult EmpleadosHospital(int? idhospital, String tabla)
        {
            Models.ModeloHospital modelo = new Models.ModeloHospital();
            if (tabla == "PLANTILLA")
            {
                List<Models.PLANTILLA> lista = modelo.GetPlantilla(idhospital.Value);
                return View(lista);
            }
            else if (tabla == "DOCTOR")
            {
                List<Models.DOCTOR> lista = modelo.GetDoctores(idhospital.Value);
                return View(lista);
            }

            return View();
        }
    }
}