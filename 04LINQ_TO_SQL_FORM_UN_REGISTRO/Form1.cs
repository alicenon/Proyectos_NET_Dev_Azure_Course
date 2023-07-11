using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04LINQ_TO_SQL_FORM_UN_REGISTRO
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
           
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) { 
            var resultado = from enf in context.ENFERMO
                            where enf.NSS == txtNSS.Text
                            select new { enf.INSCRIPCION, enf.APELLIDO, enf.DIRECCION };

            if (resultado.Count() == 0 )
            {
                MessageBox.Show("Dato nom encontrado", "Busqueda",MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtInscripcion.Clear();
                txtApellido.Clear();
                txtDir.Clear();

            }
            else
            {
                txtInscripcion.Text = resultado.First().INSCRIPCION;
                txtApellido.Text = resultado.First().APELLIDO;
                txtDir.Text = resultado.First().DIRECCION;
            }

            
            
        }
    }
}
