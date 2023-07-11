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
    public partial class FormAlta : Form
    {
        dbPlantillaDataContext dBcontext = new dbPlantillaDataContext();
        PLANTILLA objPlantilla= new PLANTILLA();
        public FormAlta()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            objPlantilla.HOSPITAL_COD = this.txtHospitalCod.Text;
            objPlantilla.SALA_COD = this.txtSala.Text;
            objPlantilla.EMPLEADO_NO = this.txtEmpleadoNum.Text;
            objPlantilla.APELLIDO = this.txtApellido.Text;
            objPlantilla.FUNCION = txtFuncion.Text;
            objPlantilla.T = txtTurno.Text;
            objPlantilla.SALARIO = int.Parse(this.txtSalario.Text);

            dBcontext.PLANTILLA.InsertOnSubmit(objPlantilla);
            try
            {

                dBcontext.SubmitChanges(); //COMMIT DE SQL, ORACLE POR EJEM
                                           //cargarDatos();
                this.DialogResult = DialogResult.OK;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar: " + ex.ToString());
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtEmpleadoNum_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
