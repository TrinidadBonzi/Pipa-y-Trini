using CLogica.Contracts;
using CLogica.Implementations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPresentacion
{
    public partial class ABMCliente : Form
    {
        private IClienteLogic _clienteLogic;
        public ABMCliente(IClienteLogic clienteLogic)
        {
            _clienteLogic = clienteLogic;
            InitializeComponent();
            CargarListadoClientes();
        }
        private void ABMCliente_Load(object sender, EventArgs e)
        {
            CargarListadoClientes();
            cbSocioCliente.Items.Add("Sí");
            cbSocioCliente.Items.Add("No");
        }
        private void CargarListadoClientes()
        {
            List<dynamic> clientes = _clienteLogic.ObtenerClientesParaListado();
            dgvListadoClientes.DataSource = clientes;
        }

        private void btGuardarCliente_Click(object sender, EventArgs e)
        {
            string nombre = tbNombreCliente.Text;
            string apellido = tbApellidoCliente.Text;
            string documento = tbDocumentoCliente.Text;
            string nacionalidad = tbNacionalidadCliente.Text;
            string email = tbEmailCliente.Text;
            string telefono = tbTelefonoCliente.Text;

        }
    }
}
