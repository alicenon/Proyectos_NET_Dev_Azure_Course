using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01LINQ_TO_SQL_FORM
{
   
    public partial class Form1 : Form
    {
        empleadosDataContext contexto = new empleadosDataContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var datos = (from p in contexto.EMP
                        select p.OFICIO).Distinct();

            //para los no repetidos con el metodo   (consulta).Distinct()
            cmbOficios.DataSource= datos;
            cmbOficios.DisplayMember = "oficio";
            //cmbOficios.ValueMember = "EMP_NO"; //ENVIA LA INFORMACION 

        }

        private void cmbOficios_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cmbOficios_SelectedIndexChanged   cuando cambie en el indice del elemento seleccionado
            var datosEmpleados = from p in contexto.EMP
                                  select new { p.OFICIO, p.APELLIDO, p.SALARIO };

            var datosEmpleado1s = from p in contexto.EMP select p;

            var datos_emp = from p in contexto.EMP where p.OFICIO == "ANALISTA" select p;

            //DATAGRIDVIEW
            String dato_oficio = cmbOficios.SelectedValue.ToString();
            var datos = from p in contexto.EMP
                        where p.OFICIO == dato_oficio
                        select new { 
                                        p.APELLIDO,
                                        p.OFICIO, 
                                        p.FECHA_ALT ,
                                        p.SALARIO , 
                                        p.COMISION  
                        };

            dgvEmpleados.DataSource = datos; //genera columnas
        }
    }
}
