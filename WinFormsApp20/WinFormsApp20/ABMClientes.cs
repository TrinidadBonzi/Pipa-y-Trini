using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormsApp20
{
    public partial class ABMClientes : Form
    {
        public ABMClientes()
        {
            InitializeComponent();
        }

        private void ABMClientes_Load(object sender, EventArgs e)
        {
            // 1. Mostrar usuario en el título de la pestaña
            if (Sesiones.Instance.UsuarioActual != null)
            {
                this.Text = $"ABM Clientes - Usuario: {Sesiones.Instance.UsuarioActual.nombre}";
            }

            // 2. Cargar lista de clientes
            CargarClientes();
        }

        private void CargarClientes()
        {
            try
            {
                List<Clientes> listita = new List<Clientes>
                {
                    new Clientes { direccion = "Calle Falsa 123", id = 1, nombre = "Juan Perez" },
                    new Clientes { direccion = "Avda eee 234", id = 2, nombre = "Ernesto Perez" }
                };

                dataGridView1.DataSource = listita;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar clientes: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}