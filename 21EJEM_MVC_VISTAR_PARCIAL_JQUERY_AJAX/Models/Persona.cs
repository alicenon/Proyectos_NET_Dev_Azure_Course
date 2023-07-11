using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _21EJEM_MVC_VISTAR_PARCIAL_JQUERY_AJAX.Models
{
    public class Persona
    {
        public Persona() { }
        public Persona(String nombre, String apellidos, int edad, String deporte)
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Edad = edad;
            this.DeporteFavorito = deporte;
        }

        public String Nombre { get; set; }
        public String Apellidos { get; set; }
        public int Edad { get; set; }
        public String DeporteFavorito { get; set; }
    }
}