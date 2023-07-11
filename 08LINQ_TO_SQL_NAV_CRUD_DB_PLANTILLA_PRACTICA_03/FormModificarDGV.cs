using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08LINQ_TO_SQL_NAV_CRUD_DB_PLANTILLA_PRACTICA_03
{
    public partial class FormModificarDGV : Form
    {
        public FormModificarDGV(string arg_emp_no, string arg_funcion, string arg_salario)
        {
            InitializeComponent();
            txtEmpleadoNum.Text = arg_emp_no;
            txtFuncion.Text = arg_funcion;
            txtSalario.Text = arg_salario;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            dbPlantillaDataContext dBcontext = new dbPlantillaDataContext();

            var consulta =
            from d in dBcontext.PLANTILLA
            where d.EMPLEADO_NO == this.txtEmpleadoNum.Text
            select d;

            consulta.First().FUNCION = this.txtFuncion.Text;
            try
            {
                consulta.First().SALARIO = int.Parse(this.txtSalario.Text);

                dBcontext.SubmitChanges();
                DialogResult = DialogResult.OK;
                //cargarDatos();
            }
            catch (System.FormatException ex)
            {
                MessageBox.Show("Error el SALARIO tiene que ser NUMERO ENTERO: " + ex.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.ToString());
            }
        }
    }
}
