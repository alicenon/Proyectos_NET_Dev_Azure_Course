using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _15EJEM_MVC_NF_LINQ_EMP_DTLIST_02.Controllers
{
    public class EmpleadosController : Controller
    {
        // GET: Empleados
        public ActionResult Index()
        {
            Models.ModeloHospital modelo = new Models.ModeloHospital();
            List<Models.EMP> lista = modelo.GetEmpleados();
            //modelo.GetEmpleadoApellido();
            return View(lista);
          
        }
        public ActionResult DetallesEmpleado(int? empno)
        {
            //Models.ModeloHospital modelo = new Models.ModeloHospital();
            //Models.EMP empleado = modelo.GetEmpleadoId(empno.Value);
            //return View(empleado);
            if (empno == null)
            {
                // manejar el caso en que empno es nulo
                return View("Error");
            }
            else
            {
                Models.ModeloHospital modelo = new Models.ModeloHospital();
                Models.EMP empleado = modelo.GetEmpleadoId(empno.Value);
                if (empleado == null)
                {
                    // manejar el caso en que el empleado es nulo
                    return View("NoEncontrado");
                }
                else
                {
                    return View(empleado);
                }
            }
        }
    }
}