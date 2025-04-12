using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            ServiceReference1.WebService1SoapClient client = new ServiceReference1.WebService1SoapClient();
            ServiceReference1.TipoDocumento aTipo = new ServiceReference1.TipoDocumento();

            aTipo.codigoDocumento = int.Parse(textBox1.Text);
            aTipo.descripcionDocumento = textBox2.Text;

            client.agregarTipoDocumento(aTipo);
        }

        private void Mostrar_Click(object sender, EventArgs e)
        {
            ServiceReference1.WebService1SoapClient client = new ServiceReference1.WebService1SoapClient();

            var listaDocumentos = client.dameListaTipoDocumentos();

            dataGridView1.DataSource = listaDocumentos;
        }
    }
}
