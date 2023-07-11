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

namespace _03LINQ_TO_SQL_FORM_PRACTICA_01
{
    public partial class Form1 : Form
    {
        ClsDoctorDataContext context = new ClsDoctorDataContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            var datos = (from p in context.DOCTOR
                         select p.ESPECIALIDAD).Distinct();

            //para los no repetidos con el metodo   (consulta).Distinct()
            cmbDoctor.DataSource = datos;
            //cmbDoctor.DisplayMember = "CARDIO";
           
        }

        private void cmbDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cmbDoctor.ValueMember = "EMP_NO"; //ENVIA LA INFORMACION 
            String value_combo = cmbDoctor.SelectedValue.ToString();

            var dato = from p in context.DOCTOR
                       where p.ESPECIALIDAD == value_combo
                       select p;

           dataGridView1.DataSource= dato;


        }
    }
}
