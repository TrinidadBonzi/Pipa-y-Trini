using ClassLibrary1; // Asegúrate de que esta referencia esté correcta
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Windows.Forms;

namespace WinFormsApp20
{
    // Form1 es el formulario principal del programa
    public partial class Form1 : Form
    {
        // Constructor del formulario, inicializa los componentes gráficos
        public Form1()
        {
            InitializeComponent(); // Método generado automáticamente que configura el formulario
        }

        // Evento que se ejecuta cuando se hace clic en el botón1 (por ejemplo, botón "Clientes")
        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormularioConLogin<ABMClientes>(); // Llama al método para abrir el formulario ABMClientes después del login
        }

        // Evento que se ejecuta cuando se hace clic en el botón2 (por ejemplo, botón "Ventas")
        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormularioConLogin<FormVentas>(); // Llama al método para abrir el formulario FormVentas después del login
        }

        // Evento que se ejecuta cuando se hace clic en el botón3 (por ejemplo, botón "Reportes")
        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormularioConLogin<FormReportes>(); // Llama al método para abrir el formulario FormReportes después del login
        }

        // Evento que se ejecuta cuando se hace clic en el botón4 (por ejemplo, botón "Salir")
        private void button4_Click(object sender, EventArgs e)
        {
            // Cerrar sesión al salir
            Sesiones.Instance.CerrarSesion(); // Limpia el usuario actual y el módulo
            MessageBox.Show("Gracias por usar el sistema"); // Muestra mensaje de despedida
            this.Close(); // Cierra el formulario actual
        }

        // Método genérico para abrir cualquier formulario que herede de Form, solo si hay un usuario logueado
        private void AbrirFormularioConLogin<T>() where T : Form, new()
        {
            // Verifica si no hay un usuario logueado
            if (Sesiones.Instance.UsuarioActual == null)
            {
                FormLogin formLogin = new FormLogin(); // Crea un nuevo formulario de login
                formLogin.ShowDialog(); // Muestra el formulario de login como ventana modal

                if (Sesiones.Instance.UsuarioActual == null) // Verifica si el login fue exitoso
                {
                    // Si no hay usuario activo, muestra error y no abre el formulario solicitado
                    MessageBox.Show("Usuario o clave incorrectos", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Salir del método si el login falló
                }
            }

            // Si el usuario está logueado, crea y muestra el formulario solicitado
            T formulario = new T(); // Crea una nueva instancia del formulario T
            formulario.ShowDialog(); // Muestra el formulario como ventana modal
        }

        // Método que guarda una lista de usuarios en un archivo de texto como JSON
        public void escribeBase()
        {
            // Crea una lista de usuarios de ejemplo
            List<Usuarios> list = new List<Usuarios>
        {
            new Usuarios { nombre = "Juan", id = 1, direccion = "por ahí", clave = "12345" },
            new Usuarios { nombre = "Pedro", id = 2, direccion = "más allá", clave = "666666" }
        };

            // Convierte la lista a formato JSON con sangría
            string json = JsonSerializer.Serialize(list, new JsonSerializerOptions { WriteIndented = true });

            // Guarda el JSON en un archivo llamado "usuarios.txt"
            File.WriteAllText("usuarios.txt", json);
        }
    }

}

