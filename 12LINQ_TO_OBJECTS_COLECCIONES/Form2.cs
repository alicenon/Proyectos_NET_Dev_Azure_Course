using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12LINQ_TO_OBJECTS_COLECCIONES
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnMostrarPeliculas_Click(object sender, EventArgs e)
        {
            List<Peliculas> Pelis = new List<Peliculas>()
            {
                new Peliculas
                {
                    Titulo="AMERICAN PIE",
                    IdEstreno=2,
                    Director="Paul Weitz",
                },
                new Peliculas 
                {  
                    Titulo="OPERACION SWORFISH",
                    IdEstreno=5,
                    Director="Dominic Sena",
                },
                new Peliculas
                {
                    Titulo="LOS LUNES AL SOL",
                    IdEstreno=9,
                    Director="Fernando León de Aranoa" 
                },
                new Peliculas {Titulo="L.A CONFIDENTIAL",
                    IdEstreno=15,
                    Director="Curtis Hanson"
                }
            };
            //
            var datospelis = from peli in Pelis
                             where (peli.IdEstreno > 4)
                             && (peli.IdEstreno < 10)
                             select peli;
            foreach (var datosp in datospelis)
            {
                this.lstPeliculas.Items.Add(datosp.Titulo + "\t" + datosp.Director);


            }
            
        }
    }
}
