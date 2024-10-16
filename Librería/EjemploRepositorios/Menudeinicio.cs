using CDatos.Repositories.Contracts;
using CDatos.Repositories;
using CLogica.Contracts;
using CLogica.Implementations;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;
using CDatos.Contexts;

namespace CPresentacion
{
    public partial class Menudeinicio : Form
    {

        private PrivateFontCollection pfc = new PrivateFontCollection();

        public Menudeinicio()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(Menudeinicio_Paint);
            CargarFuente();
            this.Resize += Menudeinicio_Resize;
        }

        private void CargarFuente()
        {
            // Carga la fuente desde la ruta especificada
            pfc.AddFontFile(@"./Fuente/Grandson.otf"); // Cambia el nombre del archivo según sea necesario

            // Asigna la fuente al label
            lblBienvenido.Font = new Font(pfc.Families[0], 30, FontStyle.Bold); // Cambia el tamaño y estilo según sea necesario
        }

        private void Menudeinicio_Paint(object sender, PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                                                                  Color.HotPink,
                                                                  Color.Black,
                                                                  90F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }
        
        

        private void btSalirSistema_Click_1(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro de que quiere salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Menudeinicio_Resize(object sender, EventArgs e)
        {
            panelRedondeado1.Size = new Size(ClientSize.Width - 50, ClientSize.Height - 100); // Ajusta según sea necesario
            panelRedondeado1.Location = new Point(25, lblBienvenido.Bottom + 10); // Coloca el panel debajo del label

            // Ajustar la posición del botón Salir
            btSalirSistema.Location = new Point(ClientSize.Width - btSalirSistema.Width - 20, ClientSize.Height - btSalirSistema.Height - 20);

            // Ajustar la posición de los botones dentro del panel
            foreach (Control control in panelRedondeado1.Controls)
            {
                control.Width = panelRedondeado1.Width - 40; // Ajustar el ancho de los botones
            }

            lblBienvenido.Location = new Point((ClientSize.Width - lblBienvenido.Width) / 2, lblBienvenido.Location.Y);
        }

        private void btAutor_Click(object sender, EventArgs e)
        {
            // Crear instancia de LibreriaContext
            LibreriaContext context = new LibreriaContext();

            // Crear instancia de IPersonaRepository
            IPersonaRepository personaRepository = new PersonaRepository(context);

            // Crear instancia de PersonaLogic pasando personaRepository
            IPersonaLogic personaLogic = new PersonaLogic(personaRepository);

            // Crear instancia de IAutorRepository
            IAutorRepository autorRepository = new AutorRepository(context);

            // Crear instancia de AutorLogic pasando autorRepository y personaLogic
            IAutorLogic autorLogic = new AutorLogic(autorRepository, personaLogic);

            // Ahora pasas autorLogic a ABMAutor
            ABMAutor ambautor = new ABMAutor(autorLogic);
            ambautor.Show();
            this.Hide();
        }

        private void btClientes_Click(object sender, EventArgs e)
        {
            LibreriaContext context = new LibreriaContext();
            IPersonaRepository personaRepository = new PersonaRepository(context);
            IPersonaLogic personaLogic = new PersonaLogic(personaRepository);
            IClienteRepository clienteRepository = new ClienteRepository(context);
            IClienteLogic clienteLogic = new ClienteLogic(clienteRepository, personaLogic);
            ABMCliente ambcliente = new ABMCliente(clienteLogic);
            ambcliente.Show();
            this.Hide();
        }
    }
}

