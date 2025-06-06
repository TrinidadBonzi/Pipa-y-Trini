using ClassLibrary1;
using System;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace WinFormsApp20
{
    // Formulario de login del sistema
    public partial class FormLogin : Form
    {
        // Constructor del formulario
        public FormLogin()
        {
            InitializeComponent(); // Inicializa todos los componentes visuales del formulario
        }

        // Evento que se ejecuta cuando el formulario se carga por primera vez
        private void FormLogin_Load(object sender, EventArgs e)
        {
            // Configuración inicial del formulario
            textBox2.PasswordChar = '*'; // Hace que los caracteres del textbox2 (contraseña) se oculten con '*'
            this.ActiveControl = textBox1; // Coloca el foco en el textbox1 (usuario) al abrir el formulario

            // Carga los usuarios desde el archivo JSON si existe
            CargarUsuariosDesdeArchivo();
        }

        // Método para cargar usuarios desde el archivo "usuarios.txt"
        private void CargarUsuariosDesdeArchivo()
        {
            try
            {
                if (File.Exists("usuarios.txt")) // Verifica si el archivo existe
                {
                    string json = File.ReadAllText("usuarios.txt"); // Lee el contenido del archivo
                    Sesiones.Instance.CargarUsuariosDesdeJson(json); // Carga los usuarios en el sistema desde ese JSON
                }
            }
            catch (Exception ex) // Captura cualquier error que ocurra
            {
                // Muestra un mensaje de error si algo sale mal al leer el archivo
                MessageBox.Show($"Error al cargar usuarios: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento del botón "Aceptar" para intentar iniciar sesión
        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = textBox1.Text.Trim(); // Obtiene el texto ingresado en el textbox de usuario (sin espacios al inicio o final)
            string clave = textBox2.Text; // Obtiene la contraseña ingresada

            // Verifica si alguno de los campos está vacío
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(clave))
            {
                MessageBox.Show("Ingrese usuario y clave", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Sale del método si faltan datos
            }

            // Intenta hacer login usando la clase Sesiones
            if (Sesiones.Instance.Login(usuario, clave))
            {
                this.DialogResult = DialogResult.OK; // Indica que el login fue exitoso
                this.Close(); // Cierra el formulario
            }
            else
            {
                // Si el login falla, limpia la contraseña y vuelve a enfocar ese campo
                textBox2.Clear();
                textBox2.Focus();
            }
        }

        // Evento del botón "Cancelar"
        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; // Indica que se canceló el login
            this.Close(); // Cierra el formulario
        }

        // Permite cerrar el formulario al presionar la tecla ESC
        private void FormLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) // Verifica si se presionó la tecla Escape
            {
                button2_Click(sender, e); // Simula el clic en el botón Cancelar
            }
        }
    }

}