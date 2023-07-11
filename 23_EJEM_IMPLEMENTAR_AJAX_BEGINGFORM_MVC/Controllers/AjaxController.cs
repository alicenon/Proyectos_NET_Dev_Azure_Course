using _23_EJEM_IMPLEMENTAR_AJAX_BEGINGFORM_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _23_EJEM_IMPLEMENTAR_AJAX_BEGINGFORM_MVC.Controllers
{
    public class AjaxController : Controller
    {
        public List<Producto> lista = new List<Producto>();

        public AjaxController()
        {
            Producto p1 = new Producto { Codigo = "001", Nombre = "Juegos", Cantidad = 75 };
            Producto p2 = new Producto { Codigo = "002", Nombre = "Películas", Cantidad = 125 };
            Producto p3 = new Producto { Codigo = "003", Nombre = "Pen Drives", Cantidad = 100 };
            lista.Add(p1);
            lista.Add(p2);
            lista.Add(p3);
        }

        // GET: Ajax
        public ActionResult Index()
        {
            return View();
        }


        public PartialViewResult MostrarDetalles(String codigo)
        {
            //creamos un hilo para que la aplicación tarde 3 segundos en 
            // buscar y muestre la imagen para visualizar la práctica completa.
            System.Threading.Thread.Sleep(3000);
            Producto prod = new Producto();
            foreach (Producto p in lista)
            {
                if (p.Codigo == codigo)
                {
                    prod = p;
                    break;
                }
            }
            return PartialView("_MostrarDetalles", prod);
        }
    }
}