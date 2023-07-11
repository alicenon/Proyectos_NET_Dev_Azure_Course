using _19EJEM_MVC_CRUD_MATENIMIENTO_DEPT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _19EJEM_MVC_CRUD_MATENIMIENTO_DEPT.Controllers
{
    public class DepartamentosController : Controller
    {
        // GET: Departamentos
        public ActionResult Index()
        {
            ModeloDepartamento modelo = new ModeloDepartamento();
            List<DEPT> lista = modelo.MostrarDepartamentos();
            return View(lista);
        }

        public ActionResult New()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(int id, string nombre, string localizacion)
        {
            ModeloDepartamento modelo = new ModeloDepartamento();
            modelo.AltaDepartamento(id, nombre, localizacion);

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {

            ModeloDepartamento modelo = new ModeloDepartamento();
            DEPT departamento = modelo.EditarDepartamento(id);
            return View(departamento);
        }

        [HttpPost]
        public ActionResult Update(string id, string nombre, string localizacion)
        {

            ModeloDepartamento modelo = new ModeloDepartamento();
            modelo.ModificarDepartamento(id, nombre, localizacion);
            return RedirectToAction("Index");
        }

        public ActionResult Destroy(int id)
        {
            ModeloDepartamento modelo = new ModeloDepartamento();
            modelo.EliminarDepartamento(id);

            return RedirectToAction("Index");
        }
    }
}