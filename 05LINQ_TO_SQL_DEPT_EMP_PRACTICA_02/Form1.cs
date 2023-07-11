using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05LINQ_TO_SQL_DEPT_EMP_PRACTICA_02
{
    public partial class Form1 : Form
    {
        ClsEmpleadoDeptDataContext context = new ClsEmpleadoDeptDataContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            var query = from emp in context.EMP
                        join dept in context.DEPT on emp.DEPT_NO equals dept.DEPT_NO
                        where emp.EMP_NO == int.Parse(txt_emp_no.Text)
                        select new {
                            emp.APELLIDO,
                            dept.LOC,
                            dept.DNOMBRE};

            try
            {
                if (query.Count() == 0)
                {
                    MessageBox.Show("Dato nom encontrado", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    textBox1.Text = query.First().APELLIDO;
                    textBox2.Text = query.First().LOC;
                    textBox3.Text = query.First().DNOMBRE;
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("TIENE QUE SER UN NUMERO", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Exception generica", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
    }
}
