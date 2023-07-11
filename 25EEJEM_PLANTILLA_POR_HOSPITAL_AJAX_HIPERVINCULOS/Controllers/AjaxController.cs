using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _25EEJEM_PLANTILLA_POR_HOSPITAL_AJAX_HIPERVINCULOS.Models;

namespace _25EEJEM_PLANTILLA_POR_HOSPITAL_AJAX_HIPERVINCULOS.Controllers
{
    public class AjaxController : Controller
    {

        ModeloHospital modelo = new ModeloHospital();
        
        // GET: Ajax
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult HospitalPlatillaAjax()
        {
            IQueryable<HOSPITAL> hospitales = modelo.GetHospitales();
            return View(hospitales);
        }

        public PartialViewResult FiltrarPlantilla(int hospitalcod)
        {
            //BUSCAMOS LA PLANTILLA EN EL MODELO
            //EL IEDNTIFICADOR ES STRING EL LAS DOS TABLAS. POR ELLOO USO EL TOSTRING() 
            IQueryable<PLANTILLA> plantilla = modelo.GetPlantillaHospital(hospitalcod.ToString());
            if (plantilla.Count() == 0)
            {
                return PartialView("_PlantillaHospital");
            }
            else
            {
                return PartialView("_PlantillaHospital", plantilla);
            }
        }
    }
}