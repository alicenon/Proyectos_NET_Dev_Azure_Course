using _21EJEM_MVC_VISTAR_PARCIAL_JQUERY_AJAX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _21EJEM_MVC_VISTAR_PARCIAL_JQUERY_AJAX.Controllers
{
    public class DetallesController : Controller
    {
        
        List<Persona> listapersonas = new List<Persona>();
        List<Lenguajes> listalenguajes = new List<Lenguajes>();

        // GET: Detalles
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RecuperarPersonas()
        {
            Persona p = new Persona("Carlos", "Tormo", 30, "Futbol");
            this.listapersonas.Add(p);
            p = new Persona("Alejandro", "Gutierrez", 34, "Padel");
            this.listapersonas.Add(p);
            p = new Persona("Pedro", "Casales", 35, "Running");
            this.listapersonas.Add(p);
            p = new Persona("Adrian", "Ramos", 18, "Atletismo");
            this.listapersonas.Add(p);
            p = new Persona("Fran", "Sanchez", 33, "Rugby");
            this.listapersonas.Add(p);
            p = new Persona("Lucia", "Serrano", 12, "Curling");
            this.listapersonas.Add(p);

            return View("DetallesPersona", this.listapersonas);
        }

        public ActionResult RecuperarLenguajes()
        {
            Lenguajes lenguaje = new Lenguajes("C#", "Programación", "Microsoft");
            this.listalenguajes.Add(lenguaje);
            lenguaje = new Lenguajes("Java", "Programación", "Oracle");
            this.listalenguajes.Add(lenguaje);
            lenguaje = new Lenguajes("SQL Server", "Base de datos", "Microsoft");
            this.listalenguajes.Add(lenguaje);
            lenguaje = new Lenguajes("MySql", "Base de datos", "Oracle");
            this.listalenguajes.Add(lenguaje);
            lenguaje = new Lenguajes("Cobol", "Programación", "IBM");
            this.listalenguajes.Add(lenguaje);

            return View("DetallesLenguaje", this.listalenguajes);
        }
    }
}