using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10LINQ_TO_SQL_PROCEDURE_OUTPUT_PLANTILLA
{
    public partial class Form1 : Form
    {
        DbPlantillaDataContext dbContext = new DbPlantillaDataContext();
        //recuperando datos de los procedures a traves de sus parametros de salida (output)
        //lo recuperamos en las txtBox 
        //procedure: cargarDatos
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var datosturno = (from p in dbContext.PLANTILLA select p.T).Distinct();
            foreach (var t in datosturno)
            {
                this.cmbTurno.Items.Add(t);
            }

            var datosplantilla = from p in dbContext.PLANTILLA
                                 select p.APELLIDO;

            foreach (var p in datosplantilla)
            {
                this.lstPlantilla.Items.Add(p);
            }
        }

        private void lstPlantilla_SelectedIndexChanged(object sender, EventArgs e)
        {

            this.lstPlantilla.Items.Clear();
            String turno = this.cmbTurno.SelectedItem.ToString();
            //Debemos declarar los parámetros de REFERENCIA como 
            //el tipo de dato System.Nullable debido a que un valor
            //por referencia podría admitir NULOS también además de números.
            int? media, suma;
            media = 0;
            suma = 0;
            this.dbContext.DATOSPLANTILLA(turno, ref media, ref suma);

            var datosape = from p in dbContext.PLANTILLA
                           where p.T == turno
                           select p.APELLIDO;

            foreach (var ape in datosape)
            {
                this.lstPlantilla.Items.Add(ape);
            }
            this.txtMedia.Text = media.ToString();
            this.txtSuma.Text = suma.ToString();
        }
    }
}
