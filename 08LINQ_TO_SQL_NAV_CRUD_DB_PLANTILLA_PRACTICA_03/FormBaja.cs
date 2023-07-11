using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08LINQ_TO_SQL_NAV_CRUD_DB_PLANTILLA_PRACTICA_03
{
    public partial class FormBaja : Form
    {
        dbPlantillaDataContext dBcontext = new dbPlantillaDataContext();

        public FormBaja()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var consulta =
         (from d in dBcontext.PLANTILLA
          where d.EMPLEADO_NO == this.txtEmpleadoNum.Text
          select d).First();
            
            dBcontext.PLANTILLA.DeleteOnSubmit(consulta);

            try
            {

                dBcontext.SubmitChanges();
                //cargarDatos();
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al borrar: " + ex.ToString());
            }
            
        }
    }
}
