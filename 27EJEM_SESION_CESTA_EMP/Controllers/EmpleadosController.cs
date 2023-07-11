using _27EJEM_SESION_CESTA_EMP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _27EJEM_SESION_CESTA_EMP.Controllers
{
    public class EmpleadosController : Controller
    {
        // GET: /Empleados/
        public ActionResult Index()
        {
            return View();
        }

        //GET
        public ActionResult AlmacenarSalario(int? salario)
        {
            ModeloEmpleado modelo = new ModeloEmpleado();
            IQueryable<EMP> empleados = modelo.GetEmpleados();
            //Session["KEY"]
            //Session["KEY"] = null;
            //if Session["KEY"] != null ???
            if (salario != null)
            {
                //CAPTURAR LA SUMA SALARIAL
                int sumasalarial = 0;
                //PREGUNTAR SI EXISTE UNA SUMA PREVIA (SESSION)
                if (Session["SUMASALARIAL"] != null)
                {
                    //TENEMOS DATOS EN LA SESSION
                    //GUARDAMOS SU VALOR
                    sumasalarial = int.Parse(Session["SUMASALARIAL"].ToString());
                }
                //AÑADIMOS A LA SESSION EL NUEVO VALOR
                sumasalarial += salario.GetValueOrDefault();
                //ALMACENAMOS EN LA SESSION LOS NUEVOS DATOS
                Session["SUMASALARIAL"] = sumasalarial;
            }
            return View(empleados);
        }

        public ActionResult MostrarSalario()
        {
            return View();
        }
    }
}