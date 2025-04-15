using Negocios;
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este registro?", "Confirmar eliminación", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int codigo = Convert.ToInt32(dataGridView1.CurrentRow.Cells["codigoDocumento"].Value);

                    ServiceReference1.WebService1SoapClient client = new ServiceReference1.WebService1SoapClient();
                    string resultado = client.eliminarTipoDoc(codigo);

                    if (resultado == "OK")
                    {
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = client.dameListaTipoDocumentos();

                        MessageBox.Show("Registro eliminado correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el registro: " + resultado);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccioná una fila para eliminar.");
            }
        }
    }
}
