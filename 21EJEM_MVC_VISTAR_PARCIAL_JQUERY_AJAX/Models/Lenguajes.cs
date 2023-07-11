using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _21EJEM_MVC_VISTAR_PARCIAL_JQUERY_AJAX.Models
{
    public class Lenguajes
    {
        public Lenguajes() { }

        public Lenguajes(String nombre, String tipo, String proveedor)
        {
            this.Nombre = nombre;
            this.Tipo = tipo;
            this.Proveedor = proveedor;
        }
        public String Nombre { get; set; }
        public String Tipo { get; set; }
        public String Proveedor { get; set; }
    }
}