using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07LINQ_TO_SQL_TRABAJAR_FORM_NAV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            //f2.Show(); // LLAMADA NO MODAL PUEDE USARSE AMBOS FORMS O LOS QUE SEA. NO ESPERA RESPUESTA
            //f2.ShowDialog(); //LLAMADA MODAL, ESTE ESPERA POR LA RESPUESTA, QUE HAGA ALGO Y NO SE PUEDE LA ANTERIOR
            if (f2.ShowDialog() == DialogResult.OK)
            {
                lstClientes.Items.Add(f2.txtNombre.Text);
            }

        }
    }
}
