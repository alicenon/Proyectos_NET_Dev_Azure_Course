using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _16PRACTICA_MVC_NET_FRAMEWORK_HOSPITAL_DOCTOR.Models;
namespace _16PRACTICA_MVC_NET_FRAMEWORK_HOSPITAL_DOCTOR.Controllers
{
    public class HospitalController : Controller
    {
        // GET: Hospital
        public ActionResult Index()
        {
            ModeloHospital modelo = new ModeloHospital();
            List<HOSPITAL> lista = modelo.GetEmpleados();
            //modelo.GetEmpleadoApellido();
            return View(lista);
        }

        //este estaba comentado ojo
        public ActionResult DetailsDoctor(String empno)
        {
            Models.ModeloHospital modelo = new Models.ModeloHospital();
            DOCTOR empleado = modelo.GetHospId(empno);
            return View(empleado);
            //if (empno == null)
            //{
            //    // manejar el caso en que empno es nulo
            //    return View("Error");
            //}
            //else
            //{
            //    ModeloHospital modelo = new ModeloHospital();
            //    HOSPITAL empleado = modelo.GetHospId(empno);  //.Value
            //    if (empleado == null)
            //    {
            //        // manejar el caso en que el empleado es nulo
            //        return View("NoEncontrado");
            //    }
            //    else
            //    {
            //        return View(empleado);
            //    }
            //}
        }


        public ActionResult EliminarHospital(String empno)
        {
            //Models.ModeloHospital modelo = new Models.ModeloHospital();
            //Models.EMP empleado = modelo.GetEmpleadoId(empno.Value);
            //return View(empleado);
            ModeloHospital modelo = new ModeloHospital();
            HOSPITAL lista = modelo.DeleteHospitalForID(empno);
            //modelo.GetEmpleadoApellido();
            return RedirectToAction("Index"); // redirecciona a Index
        }
    }
}