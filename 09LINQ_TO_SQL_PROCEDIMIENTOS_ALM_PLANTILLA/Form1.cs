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

namespace _09LINQ_TO_SQL_PROCEDIMIENTOS_ALM_PLANTILLA
{
    public partial class Form1 : Form
    {
        DbEmpleadosDataContext dbContext = new DbEmpleadosDataContext();
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CargarDatosPlantilla();

        }
        private void CargarDatosPlantilla()
        {
            var datosPlantillas = from plan in dbContext.PLANTILLA
                                  select new
                                  {
                                      Codigo = plan.EMPLEADO_NO,
                                      Apellido = plan.APELLIDO,
                                      Funcion = plan.FUNCION
                                  };

            this.dgvPlantilla.DataSource = datosPlantillas;
            this.dgvPlantilla.AllowUserToAddRows = false;
            this.dgvPlantilla.ReadOnly = true;
        }

        private void dgvPlantilla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //el valor inicial siempre es -1 (para props numericas). Para evitar decimos que si es distinto de -1, entonces procede.
            if (e.RowIndex != -1) // para que no de error al lanzar el evento sobre la cabezera del datagridview
            {
                this.txtApellido.Text = this.dgvPlantilla[1, e.RowIndex].Value.ToString();
                this.txtFuncion.Text = this.dgvPlantilla[2, e.RowIndex].Value.ToString();
            }
            else
            {
                MessageBox.Show("PINCHA EN LOS EN UNA FILA DE LOS REGISTROS");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            string ape, fun, codigo;
            int indice = this.dgvPlantilla.CurrentCell.RowIndex;
            ape = this.txtApellido.Text;
            fun = this.txtFuncion.Text;
            codigo = this.dgvPlantilla[0, indice].Value.ToString();

            this.dbContext.MODIFICARPLANTILLA(int.Parse(codigo), ape, fun);

            var resultado = (from plan in dbContext.PLANTILLA
                             where plan.EMPLEADO_NO == codigo
                             select new
                             {
                                 Apellido = plan.APELLIDO
                                 ,
                                 Funcion = plan.FUNCION
                             }).First();

            MessageBox.Show("Registro Modificado:\n" + resultado.Apellido + "\n" + resultado.Funcion);

            this.CargarDatosPlantilla();
        }
    }
}
