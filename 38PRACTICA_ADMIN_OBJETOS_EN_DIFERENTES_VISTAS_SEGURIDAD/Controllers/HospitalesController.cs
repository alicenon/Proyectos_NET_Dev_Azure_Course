using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _38PRACTICA_ADMIN_OBJETOS_EN_DIFERENTES_VISTAS_SEGURIDAD.Models;

namespace _38PRACTICA_ADMIN_OBJETOS_EN_DIFERENTES_VISTAS_SEGURIDAD.Controllers
{
    
    public class HospitalesController : Controller
    {
        ModeloHospital modelo = new ModeloHospital();
        // GET: Hospitales
        public ActionResult Index()
        {
            return View();
        }
        [Authorize(Roles = "administradores")]
        public ActionResult ListaHospitales()
        {
            
            IQueryable<HOSPITAL> Ilista = modelo.GetHospitales();

            return View(Ilista);
        }
        //
        [Authorize(Roles = "administradores")]
        public ActionResult ListaHospitalesAdmin()
        {

            IQueryable<HOSPITAL> Ilista = modelo.GetHospitales();

            return View(Ilista);
        }
        //
        [Authorize(Users = "usuario@usuario.com")]
        public ActionResult ListaHospitalesUser()
        {
            ModeloHospital modelo = new Models.ModeloHospital();
            IQueryable<Models.HOSPITAL> lista = modelo.GetHospitales();
            return View(lista);
        }
        ////

        [Authorize(Users = "usuario@usuario.com")]
        public ActionResult EmpleadosHospital(int? ID)
        {
            List<PLANTILLA> Ilista = modelo.GetPlantilla(ID.Value);
            return View(Ilista);
        }

       
    }
}