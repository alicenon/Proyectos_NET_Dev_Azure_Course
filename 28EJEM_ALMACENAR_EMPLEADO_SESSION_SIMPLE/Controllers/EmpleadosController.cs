using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _28EJEM_ALMACENAR_EMPLEADO_SESSION_SIMPLE.Models;

namespace _28EJEM_ALMACENAR_EMPLEADO_SESSION_SIMPLE.Controllers
{
    public class EmpleadosController : Controller
    {
        ModeloHospital modelo = new ModeloHospital();

        //GET
        public ActionResult AlmacenarEmpleados(int? empno)
        {
            IQueryable<EMP> empleados = modelo.GetEmpleados();
            if (empno != null)
            {
                //NECESITAMOS ALMACENAR CADA UNO DE LOS NUMEROS DE EMPLEADO
                //SELECCIONADOS (List<>)
                List<int> listaempleados;
                if (Session["EMPLEADOS"] == null)
                {
                    //NO EXISTE NADA EN LA SESSION Y CREAMOS LA 
                    //LISTA LA PRIMERA VEZ
                    listaempleados = new List<int>();
                }
                else
                {
                    //RECUPERAMOS LA LISTA DEL OBJETO SESSION
                    listaempleados = (List<int>)Session["EMPLEADOS"];
                }
                //GUARDAMOS EL NUEVO EMPLEADO EN LA LISTA
                listaempleados.Add(empno.GetValueOrDefault());
                //ALMACENAMOS LA LISTA EN LA SESSION
                Session["EMPLEADOS"] = listaempleados;
                ViewBag.Mensaje = "Empleados almacenados: " + listaempleados.Count();
            }
            return View(empleados);
        }

        public ActionResult MostrarEmpleados()
        {
            if (Session["EMPLEADOS"] == null)
            {
                return View();
            }
            else
            {
                List<int> lista = (List<int>)Session["EMPLEADOS"];
                IQueryable<EMP> empleados = this.modelo.GetEmpleadosSession(lista);
                return View(empleados);
            }
        }
    }
}