using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06LINQ_TO_SQL_FORM_QUERY_ACCIONES_DOCTORES
{
    public partial class Form1 : Form
    {
        DbDoctoresDataContext dBcontext = new DbDoctoresDataContext();
        DOCTOR objDoctor = new DOCTOR();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }
        public void cargarDatos()
        {
            var datos = from p in dBcontext.DOCTOR
                        select p;
            this.dataGridView1.DataSource = datos;
        }

        private void btnAgragar_Click(object sender, EventArgs e)
        {
            int? salario = int.Parse(this.txtSalario.Text);


            objDoctor.HOSPITAL_COD = this.txtHospitalCod.Text;
            objDoctor.DOCTOR_NO = this.txtDoctorNo.Text;
            objDoctor.APELLIDO = this.txtApellido.Text;
            objDoctor.ESPECIALIDAD = this.txtEspecialidad.Text;
            objDoctor.SALARIO = salario;

            dBcontext.DOCTOR.InsertOnSubmit(objDoctor);
            try
            {

                dBcontext.SubmitChanges(); //COMMIT DE SQL, ORACLE POR EJEM
                cargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar: " + ex.ToString());
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var consulta =
         (from d in dBcontext.DOCTOR
          where d.DOCTOR_NO == this.txtDoctorNo.Text
          select d).First();

            dBcontext.DOCTOR.DeleteOnSubmit(consulta);




            try
            {

                dBcontext.SubmitChanges();
                cargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al borrar: " + ex.ToString());
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            var consulta2 =
            from d in dBcontext.DOCTOR
            where d.DOCTOR_NO == this.txtDoctorNo.Text
            select d;

            consulta2.First().APELLIDO = this.txtApellido.Text;
            consulta2.First().ESPECIALIDAD = this.txtEspecialidad.Text;

            try
            {

                dBcontext.SubmitChanges();
                cargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.ToString());
            }
        }
    }
}
