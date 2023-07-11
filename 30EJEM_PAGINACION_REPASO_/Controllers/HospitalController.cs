using _30EJEM_PAGINACION_REPASO_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _30EJEM_PAGINACION_REPASO_.Controllers
{
    public class HospitalController : Controller
    {
        // GET: Hospital
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult EmpleadosHospital(int? posicion, int? hospital)
        {
            if (posicion == null)
            {
                posicion = 1;
            }

            ModeloHospital modelo = new ModeloHospital();

            List<PAGINAR_EMPLEADOS_HOSPITAL_Result> listaempleados =
                modelo.GetEmpleadosHospital(posicion.GetValueOrDefault()
                , hospital.GetValueOrDefault());
            int numeroempleados = modelo.GetNumeroEmpleadosHospital(hospital.GetValueOrDefault());
            String paginacion = "<div>";

            int numeropagina = 1;
            for (int i = 1; i <= numeroempleados; i += 3)
            {
                paginacion += "<a href='EmpleadosHospital?posicion="
                    + i + "&hospital=" + hospital + "'>" + numeropagina + "</a>";
                numeropagina += 1;
            }
            ViewBag.Paginacion = paginacion;

            return View(listaempleados);
        }

        [HttpPost]
        public ActionResult EmpleadosHospital(int hospital)
        {
            ModeloHospital modelo = new ModeloHospital();

            List<PAGINAR_EMPLEADOS_HOSPITAL_Result> listaempleados =
                modelo.GetEmpleadosHospital(1
                , hospital);
            int numeroempleados = modelo.GetNumeroEmpleadosHospital(hospital);
            String paginacion = "<div>";

            int numeropagina = 1;
            for (int i = 1; i <= numeroempleados; i += 3)
            {
                paginacion += "<a href='EmpleadosHospital?posicion="
                    + i + "&hospital=" + hospital + "'>" + numeropagina + "</a>";
                numeropagina += 1;
            }
            ViewBag.Paginacion = paginacion;

            return View(listaempleados);
        }
    }
}