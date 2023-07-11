using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02LINQ_TO_SQL_FORM
{
    public partial class Form1 : Form
    {
        ClsPlantillaDataContext context = new ClsPlantillaDataContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // var se puede cualquier tipo de dato
            //clsplantilladatacontext context = new clsplantilladatacontext();
           /* var dato = from p in context.PLANTILLA
                       select p;*/

            //var dato1 = from p in context.PLANTILLA
            //            select new{p.APELLIDO, p.SALARIO};
            
            var dato2 = from p in context.PLANTILLA
                        where p.FUNCION == txtFuncion.Text
                        select new { p.APELLIDO };

            if (dato2.Count() == 0)
            {
                MessageBox.Show("FUNCION NO ENCONTRADA");

            }
            else
            {
                dgvPlantilla.DataSource = dato2;
            }

            
            //dataGridView1.DataSource= dato2;

            /*foreach (var p in context.PLANTILLA)
            {
                MessageBox.Show(p.APELLIDO); 
            }*/
        }
    }
}
