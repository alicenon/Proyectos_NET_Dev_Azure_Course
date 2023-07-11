using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _24EJEM_MVC_HOSPITAL_ENTITY_FRAMEWORK_NET_FRAMEWORK.Models;

namespace _24EJEM_MVC_HOSPITAL_ENTITY_FRAMEWORK_NET_FRAMEWORK.Controllers
{
    public class AjaxController : Controller
    {
        ModeloHospital modelo = new ModeloHospital();

        // GET: Ajax
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult EmpleadosAjax()
        {
            return View();
        }



        [HttpPost]
        public PartialViewResult FiltrarEmpleados(String apellido)
        {
            //BUSCAMOS LOS EMPLEADOS EN EL MODELO
            IQueryable<EMP> empleados = modelo.BuscarEmpleados(apellido);
            if (empleados.Count() == 0)
            {
                //DEVOLVEMOS LA VISTA SIN EMPLEADOS
                return PartialView("_ListaEmpleados");
            }
            else
            {
                //DEVOLVEMOS LA VISTA CON DATOS DE EMPLEADOS
                //FILTRADOS POR SU APELLIDO
                return PartialView("_ListaEmpleados", empleados);
            }
        }
    }
}