using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _18PRACTICA_MVC_NET_FRAME_PLANTILLA_POR_HOSPITAL.Models;

namespace _18PRACTICA_MVC_NET_FRAME_PLANTILLA_POR_HOSPITAL.Controllers
{
    public class HospitalesController : Controller
    {
        // GET: Hospitales
        public ActionResult Index()
        {
            ModeloHospital model_ = new ModeloHospital();
             List<PLANTILLA> lista = model_.GetPLANTILLA();
            return View(lista);
        }

        [HttpPost]
        public ActionResult Index(string txthospitalcod)
        {
            ViewData["Message"] = "Error codigo no encontrado";
            //return View(empleado);
            if (txthospitalcod == null)
            {
                // manejar el caso en que empno es nulo
                return View("Error");
            }
            else
            {
                ModeloHospital modelo = new ModeloHospital();
                List <HOSPITAL> empleados = modelo.GetHospitalId(txthospitalcod);  //.Value
                if (empleados == null)
                {
                    // manejar el caso en que el empleado es nulo
                    return View("NoEncontrado");
                }
                else
                {
                    return View(empleados);
                }
            }
        }
    }
}