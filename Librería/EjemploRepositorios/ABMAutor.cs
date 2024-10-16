using CLogica.Contracts;
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
    public partial class ABMAutor : Form
    {
        private IAutorLogic _autorLogic;
        public ABMAutor(IAutorLogic autorLogic)
        {
            _autorLogic = autorLogic;
            InitializeComponent();
            CargarListadoAutores();
        }
        private void ABMAutor_Load(object sender, EventArgs e)
        {
            CargarListadoAutores();
        }
        private void CargarListadoAutores()
        {
            List<dynamic> autors = _autorLogic.ObtenerAutoresParaListado();
            dgvListadoAutores.DataSource = autors;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = tbNombreAlta.Text;
            string apellido = tbApellidoAlta.Text;
            string nacionalidad = tbNacionalidadAlta.Text;
            string email = tbEmailAlta.Text;
            string telefono = tbTelefonoAlta.Text;
            string biografia = tbBiografiaAlta.Text;

            try
            {
                _autorLogic.AltaAutor(nombre, apellido, nacionalidad, email, telefono, biografia);
                MessageBox.Show("El autor se ha registrado con éxito.");
                CargarListadoAutores(); // Actualizamos el listado después de guardar un nuevo autor.
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void dgvListadoAutores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tbNombreAlta.Text = dgvListadoAutores.CurrentRow.Cells[0].Value.ToString();
                tbApellidoAlta.Text = dgvListadoAutores.CurrentRow.Cells[1].Value.ToString();
                tbNacionalidadAlta.Text = dgvListadoAutores.CurrentRow.Cells[2].Value.ToString();
                tbEmailAlta.Text = dgvListadoAutores.CurrentRow.Cells[3].Value.ToString();
                tbTelefonoAlta.Text = dgvListadoAutores.CurrentRow.Cells[4].Value.ToString();
                tbBiografiaAlta.Text = dgvListadoAutores.CurrentRow.Cells[5].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public static int Id = -1;
        private void dgvListadoAutores_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Id = Convert.ToInt32(dgvListadoAutores.Rows[e.RowIndex].Cells[0].Value.ToString());
            tbNombreAlta.Text = dgvListadoAutores.Rows[e.RowIndex].Cells[1].Value == DBNull.Value ? "" : dgvListadoAutores.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbApellidoAlta.Text = dgvListadoAutores.Rows[e.RowIndex].Cells[2].Value == DBNull.Value ? "" : dgvListadoAutores.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbNacionalidadAlta.Text = dgvListadoAutores.Rows[e.RowIndex].Cells[3].Value == DBNull.Value ? "" : dgvListadoAutores.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbEmailAlta.Text = dgvListadoAutores.Rows[e.RowIndex].Cells[4].Value == DBNull.Value ? "" : dgvListadoAutores.Rows[e.RowIndex].Cells[4].Value.ToString();
            tbTelefonoAlta.Text = dgvListadoAutores.Rows[e.RowIndex].Cells[5].Value == DBNull.Value ? "" : dgvListadoAutores.Rows[e.RowIndex].Cells[5].Value.ToString();
            tbBiografiaAlta.Text = dgvListadoAutores.Rows[e.RowIndex].Cells[6].Value == DBNull.Value ? "" : dgvListadoAutores.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (Id != -1)
            {
                // Obtenemos los datos modificados desde los TextBox
                string nombre = tbNombreAlta.Text;
                string apellido = tbApellidoAlta.Text;
                string nacionalidad = tbNacionalidadAlta.Text;
                string email = tbEmailAlta.Text;
                string telefono = tbTelefonoAlta.Text;
                string biografia = tbBiografiaAlta.Text;

                try
                {
                    // Llamamos a la lógica para actualizar el autor
                    _autorLogic.ActualizarAutor(Id, nombre, apellido, nacionalidad, email, telefono, biografia);

                    // Actualizamos el listado de autores después de modificar
                    MessageBox.Show("El autor ha sido modificado con éxito.");
                    CargarListadoAutores();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar el autor: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Selecciona un autor para modificar.");
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Id != -1)
            {
                // Confirmación de eliminación
                var confirmResult = MessageBox.Show("¿Estás seguro de eliminar este autor?", "Confirmar Eliminación", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        // Llamada a la lógica para eliminar el autor por su Id
                        _autorLogic.EliminarAutor(Id.ToString()); // Convertimos 'Id' a string si es necesario.

                        // Actualizamos el listado después de eliminar
                        MessageBox.Show("El autor ha sido eliminado con éxito.");
                        CargarListadoAutores();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Menudeinicio menuinicio = new Menudeinicio();
            menuinicio.Show();
            this.Hide();
        }
    }
}
