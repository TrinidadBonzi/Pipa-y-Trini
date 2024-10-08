using CEntidades.Entidades;
using CLogica.Contracts;

namespace CPresentacion
{
    public partial class ABMAutor : Form
    {

        private IAutorLogic _autorLogic;

        public ABMAutor(IAutorLogic autorLogic)
        {
            _autorLogic = autorLogic;
            InitializeComponent();
        }

        private void tabControlPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlPrincipal.SelectedIndex == 0)
            {
                CargarListadoAutores();
            }
        }

        private void ABMAutor_Load(object sender, EventArgs e)
        {
            if (tabControlPrincipal.SelectedIndex == 0)
            {
                CargarListadoAutores();
            }
        }

        private void CargarListadoAutores()
        {
            List<dynamic> autors = _autorLogic.ObtenerAutoresParaListado();
            //List<Autor> autors = _autorLogic.ObtenerAutores();
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



    }
}
