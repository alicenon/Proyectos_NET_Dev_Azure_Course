using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using _26PRACTICA_MVC_EMPLEADOS_POR_OFICIO_AJAX.Models;

namespace _26PRACTICA_MVC_EMPLEADOS_POR_OFICIO_AJAX.Controllers
{
    public class EmpleadosController : Controller
    {
        ModeloHospitalEmpleados modelContext = new ModeloHospitalEmpleados();
        // GET: Empleados
        public ActionResult Index()
        {
            ModeloHospitalEmpleados emp = new ModeloHospitalEmpleados();
            List<String> oficios = emp.ObtenerOficiosSinRepetirConLinq();
            return View(oficios);

        }

        public PartialViewResult BuscarEmpleo(string oficio)
        {
            //BUSCAMOS LA PLANTILLA EN EL MODELO
            IQueryable<EMP> plantilla = modelContext.ObtenerTodosLosEmpleadosConLinq(oficio);
            if (plantilla.Count() == 0)
            {
                return PartialView("_Empleados");
            }
            else
            {
                return PartialView("_Empleados", plantilla);
            }
        }
    }
}