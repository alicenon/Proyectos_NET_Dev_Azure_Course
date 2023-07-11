using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _14EJEM_MVC_NET_FRAMEWORK_01.Controllers
{
    public class PruebaController : Controller
    {
        // GET: Prueba
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Vista1()
        {
            List<String> lista = new List<string>();
            lista.Add("Ana");
            lista.Add("Andrea");
            lista.Add("Adrian");
            lista.Add("Maria");
            lista.Add("Lucia");
            lista.Add("Silvia");
            lista.Add("Gema");
            lista.Add("Carlos");
            lista.Add("Pedro");
            lista.Add("Javier");
            lista.Add("Antonio");
            lista.Add("Oscar");
            lista.Add("Maite");
            return View(lista);
        }

    }
}