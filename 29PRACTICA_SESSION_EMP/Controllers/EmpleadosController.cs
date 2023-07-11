using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _29PRACTICA_SESSION_EMP.Models;

namespace _29PRACTICA_SESSION_EMP.Controllers
{
    public class EmpleadosController : Controller
    {
        // GET: Empleados
        ModeloHospital modelo = new ModeloHospital();

        //GET
        public ActionResult AlmacenarEmpleados(int? empno, int? salario)
        {
            //IQueryable<EMP> empleados = modelo.GetEmpleados();
            //
            if (salario.HasValue)
            {
                int sumasalarial = (int)(Session["SUMASALARIAL"] ?? 0);
                Session["SUMASALARIAL"] = sumasalarial + salario.Value;
            }
            //
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

            IQueryable<EMP> empleados = this.modelo.GetEmpleados();
            return View(empleados);
        }
        //
        public ActionResult MostrarEmpleados(int? eliminaremp)
        {
            if (eliminaremp != null)
            {
                List<int> lista = (List<int>)Session["EMPLEADOS"];
                lista.Remove(eliminaremp.GetValueOrDefault());
                if (lista.Count() == 0)
                {
                    Session["EMPLEADOS"] = null;
                }
                else
                {
                    Session["EMPLEADOS"] = lista;
                }
            }
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




        //aqui metodos
        public ActionResult QuitarEmpleado(int? empno)
        {
            Session["EJEM"] = null;
            Session["EJEM"] = Session["SUMASALARIAL"];
            //IQueryable<EMP> empleado = modelo.GetEmpleados();

            //IQueryable<EMP> empleados = modelo.GetEmpleados();
            //List<int> lista_empleados = ()
            //empleados.Remove(empno.GetValueOrDefault());

            //if (salario != null)
            //{
            //    //CAPTURAR LA SUMA SALARIAL
            //    int sumasalarial = 0;
            //    //PREGUNTAR SI EXISTE UNA SUMA PREVIA (SESSION)
            //    if (Session["SUMASALARIAL"] != null)
            //    {
            //        //TENEMOS DATOS EN LA SESSION
            //        //GUARDAMOS SU VALOR
            //        sumasalarial = int.Parse(Session["SUMASALARIAL"].ToString());
            //    }
            //    //AÑADIMOS A LA SESSION EL NUEVO VALOR
            //    sumasalarial += salario.GetValueOrDefault();
            //    //ALMACENAMOS EN LA SESSION LOS NUEVOS DATOS
            //    Session["SUMASALARIAL"] = sumasalarial;
            //}
            // return View(empleados);
            return RedirectToAction("MostrarEmpleados");
        }
    }


    //

    //public ActionResult QuitarEmpleado(int? empno)
    //{
    //    Session["EJEM"]=null;
    //    Session["EJEM"] = Session["SUMASALARIAL"];
    //    //IQueryable<EMP> empleado = modelo.GetEmpleados();

    //    //IQueryable<EMP> empleados = modelo.GetEmpleados();
    //    //List<int> lista_empleados = ()
    //    //empleados.Remove(empno.GetValueOrDefault());

    //    //if (salario != null)
    //    //{
    //    //    //CAPTURAR LA SUMA SALARIAL
    //    //    int sumasalarial = 0;
    //    //    //PREGUNTAR SI EXISTE UNA SUMA PREVIA (SESSION)
    //    //    if (Session["SUMASALARIAL"] != null)
    //    //    {
    //    //        //TENEMOS DATOS EN LA SESSION
    //    //        //GUARDAMOS SU VALOR
    //    //        sumasalarial = int.Parse(Session["SUMASALARIAL"].ToString());
    //    //    }
    //    //    //AÑADIMOS A LA SESSION EL NUEVO VALOR
    //    //    sumasalarial += salario.GetValueOrDefault();
    //    //    //ALMACENAMOS EN LA SESSION LOS NUEVOS DATOS
    //    //    Session["SUMASALARIAL"] = sumasalarial;
    //    //}
    //    // return View(empleados);
    //    return RedirectToAction("MostrarEmpleados");
    //}
}
