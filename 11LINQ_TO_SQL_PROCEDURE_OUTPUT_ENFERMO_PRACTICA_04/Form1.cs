using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11LINQ_TO_SQL_PROCEDURE_OUTPUT_ENFERMO_PRACTICA_04
{
    public partial class Form1 : Form
    {
        DbEnfermosDataContext dbContext = new DbEnfermosDataContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerDatos_Click(object sender, EventArgs e)
        {
            string nomb = "";
             string sex = "";
            //int indice = this.dgvPlantilla.CurrentCell.RowIndex;
            //nomb = this.lblNombre.Text;
            //sex = this.lblSexo.Text;

            try{
                int codigo_nss = Int32.Parse(txtNSS.Text);
                this.dbContext.DEVOLVERENFERMO(codigo_nss, ref nomb, ref sex);

                var resultado = (from plan in dbContext.ENFERMO
                                 where plan.NSS == codigo_nss
                                 select new
                                 {
                                     Apellido = plan.APELLIDO
                                     ,
                                     Sex = plan.S
                                 }).First();
            }
            catch (InvalidOperationException ex){
                MessageBox.Show("Error: "+ ex.Message + "\nDEBES INTRODUCIR UN NUMERO DE SEGURIDAD EXISTENTE");
            }
            catch (FormatException){
                MessageBox.Show("TIENEN QUE SER NUMEROS!!");
            }
            catch (OverflowException ){
                MessageBox.Show("Es demasiado grande? ");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Test Error: " + ex.Message);
            }


            this.lblNombre.Text = nomb;
            this.lblSexo.Text = sex; // ToString();

        }
    }
}
