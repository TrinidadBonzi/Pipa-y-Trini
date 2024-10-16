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
            string socio = cbSocioCliente.SelectedItem?.ToString();
            string iva = cbIvaCliente.SelectedItem?.ToString();

            try
            {
                _clienteLogic.AltaCliente(nombre, apellido, documento, nacionalidad, email, telefono, socio, iva);
                MessageBox.Show("El cliente se ha registrado con éxito.");
                CargarListadoClientes(); // Actualizamos el listado después de guardar un nuevo autor.
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Menudeinicio minicio = new Menudeinicio();
            minicio.Show();
            this.Hide();
        }

        private void dgvListadoClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tbNombreCliente.Text = dgvListadoClientes.CurrentRow.Cells[0].Value.ToString();
                tbApellidoCliente.Text = dgvListadoClientes.CurrentRow.Cells[1].Value.ToString();
                tbDocumentoCliente.Text = dgvListadoClientes.CurrentRow.Cells[2].Value.ToString();
                tbNacionalidadCliente.Text = dgvListadoClientes.CurrentRow.Cells[3].Value.ToString();
                tbEmailCliente.Text = dgvListadoClientes.CurrentRow.Cells[4].Value.ToString();
                tbTelefonoCliente.Text = dgvListadoClientes.CurrentRow.Cells[5].Value.ToString();
                cbSocioCliente.Text = dgvListadoClientes.CurrentRow.Cells[6].Value.ToString();
                cbIvaCliente.Text = dgvListadoClientes.CurrentRow.Cells[7].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public static int Id = -1;
        private void dgvListadoClientes_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Id = Convert.ToInt32(dgvListadoClientes.Rows[e.RowIndex].Cells[0].Value.ToString());
            tbNombreCliente.Text = dgvListadoClientes.Rows[e.RowIndex].Cells[1].Value == DBNull.Value ? "" : dgvListadoClientes.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbApellidoCliente.Text = dgvListadoClientes.Rows[e.RowIndex].Cells[2].Value == DBNull.Value ? "" : dgvListadoClientes.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbDocumentoCliente.Text = dgvListadoClientes.Rows[e.RowIndex].Cells[3].Value == DBNull.Value ? "" : dgvListadoClientes.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbNacionalidadCliente.Text = dgvListadoClientes.Rows[e.RowIndex].Cells[5].Value == DBNull.Value ? "" : dgvListadoClientes.Rows[e.RowIndex].Cells[5].Value.ToString();
            tbEmailCliente.Text = dgvListadoClientes.Rows[e.RowIndex].Cells[6].Value == DBNull.Value ? "" : dgvListadoClientes.Rows[e.RowIndex].Cells[6].Value.ToString();
            tbTelefonoCliente.Text = dgvListadoClientes.Rows[e.RowIndex].Cells[4].Value == DBNull.Value ? "" : dgvListadoClientes.Rows[e.RowIndex].Cells[4].Value.ToString();
            cbSocioCliente.Text = dgvListadoClientes.Rows[e.RowIndex].Cells[7].Value == DBNull.Value ? "" : dgvListadoClientes.Rows[e.RowIndex].Cells[7].Value.ToString();
            cbIvaCliente.Text = dgvListadoClientes.Rows[e.RowIndex].Cells[8].Value == DBNull.Value ? "" : dgvListadoClientes.Rows[e.RowIndex].Cells[8].Value.ToString();
        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            if (Id != -1)
            {
                string nombre = tbNombreCliente.Text;
                string apellido = tbApellidoCliente.Text;
                string documento = tbDocumentoCliente.Text;
                string nacionalidad = tbNacionalidadCliente.Text;
                string email = tbEmailCliente.Text;
                string telefono = tbTelefonoCliente.Text;
                string socio = cbSocioCliente.SelectedItem?.ToString();
                string iva = cbIvaCliente.SelectedItem?.ToString();

                try
                {

                    _clienteLogic.ActualizarCliente(Id, nombre, apellido, documento, nacionalidad, email, telefono, socio, iva);


                    MessageBox.Show("El cliente ha sido modificado con éxito.");
                    CargarListadoClientes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar el cliente: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Selecciona un cliente para modificar.");
            }
        }

        private void btEliminarCliente_Click(object sender, EventArgs e)
        {
            if (Id != -1)
            {

                var confirmResult = MessageBox.Show("¿Estás seguro de eliminar este cliente?", "Confirmar Eliminación", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {

                        _clienteLogic.EliminarCliente(Id.ToString()); // Convertimos 'Id' a string si es necesario.


                        MessageBox.Show("El cliente ha sido eliminado con éxito.");
                        CargarListadoClientes();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar el autor: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona un autor para eliminar.");
            }
        }

    }
}
