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
    public partial class Form1 : Form
    {
        string dato_fun = "";
        string dato_sal = "";
        string dato_emp_no = "";
        dbPlantillaDataContext dbContext;
        public Form1()
        {
            InitializeComponent(); // inicia los componentes del formulario, los Args van despues de esto
            //propiedad enable.false ??
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            cargarDatos();

        }
        public void cargarDatos()
        {
            dbContext = new dbPlantillaDataContext();

            var datos = from p in dbContext.PLANTILLA
                        select p;
            this.dataGridView1.DataSource = datos;
        }

        private void btnAgragar_Click(object sender, EventArgs e)
        {
            FormAlta f_alta = new FormAlta();
            // f_alta.ShowDialog();
            if (f_alta.ShowDialog() == DialogResult.OK)
            {
                cargarDatos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            FormBaja f_baja = new FormBaja();
            if (f_baja.ShowDialog() == DialogResult.OK)
            {
                cargarDatos();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FormModificar fm = new FormModificar();
            if (fm.ShowDialog() == DialogResult.OK)
            {
                cargarDatos();
            }
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(this.dataGridView1[2, e.RowIndex].Value.ToString());
            string value_dgv = this.dataGridView1[2, e.RowIndex].Value.ToString();

            borrarDGV(value_dgv);
            string salarios = "";
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (salarios == null)
                {
                    MessageBox.Show("null ver aqui?");
                }
                salarios += dataGridView1[6, i].Value.ToString() + "\n";

            }
            MessageBox.Show("salarios: " + salarios);



            //
            dato_emp_no = this.dataGridView1[2, e.RowIndex].Value.ToString();
            dato_fun = this.dataGridView1[4, e.RowIndex].Value.ToString();
            dato_sal = this.dataGridView1[6, e.RowIndex].Value.ToString();
            //
        }
        public void borrarDGV(string dato)
        {
            DialogResult result = MessageBox.Show("desea borrar el registro: " + dato + "??", "Borrado", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                var consulta =
                (from d in dbContext.PLANTILLA
                 where d.EMPLEADO_NO == dato
                 select d).First();

                dbContext.PLANTILLA.DeleteOnSubmit(consulta);

                try
                {

                    dbContext.SubmitChanges();
                    // DialogResult = DialogResult.OK;
                    cargarDatos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al borrar: " + ex.ToString());
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            FormModificarDGV fm_dgv = new FormModificarDGV(dato_emp_no, dato_fun, dato_sal);
            //fm_dgv.ShowDialog();
            if (fm_dgv.ShowDialog() == DialogResult.OK)
            {
                cargarDatos();
            }
        }
    }
}
