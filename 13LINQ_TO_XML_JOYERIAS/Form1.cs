using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _13LINQ_TO_XML_JOYERIAS
{
    public partial class Form1 : Form
    {
        XDocument documento;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            documento = XDocument.Load("joyeria.xml");
            var joyerias = from datos in documento.Descendants("joyeria")
                           select new
                           {
                               nombre = datos.Element("nombrejoyeria").Value,
                               cif = datos.Attribute("cif").Value
                           };

            foreach (var nombrejoy in joyerias)
            {
                this.cmbJoyeria.Items.Add(nombrejoy.nombre);
            }
            this.label4.Text = joyerias.First().nombre;
            this.label5.Text= joyerias.First().cif;

        }
    }
}
