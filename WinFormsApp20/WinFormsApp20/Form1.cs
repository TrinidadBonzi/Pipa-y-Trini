using ClassLibrary1; // Aseg�rate de que esta referencia est� correcta
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Windows.Forms;

namespace WinFormsApp20
{
    // Form1 es el formulario principal del programa
    public partial class Form1 : Form
    {
        // Constructor del formulario, inicializa los componentes gr�ficos
        public Form1()
        {
            InitializeComponent(); // M�todo generado autom�ticamente que configura el formulario
        }

        // Evento que se ejecuta cuando se hace clic en el bot�n1 (por ejemplo, bot�n "Clientes")
        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormularioConLogin<ABMClientes>(); // Llama al m�todo para abrir el formulario ABMClientes despu�s del login
        }

        // Evento que se ejecuta cuando se hace clic en el bot�n2 (por ejemplo, bot�n "Ventas")
        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormularioConLogin<FormVentas>(); // Llama al m�todo para abrir el formulario FormVentas despu�s del login
        }

        // Evento que se ejecuta cuando se hace clic en el bot�n3 (por ejemplo, bot�n "Reportes")
        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormularioConLogin<FormReportes>(); // Llama al m�todo para abrir el formulario FormReportes despu�s del login
        }

        // Evento que se ejecuta cuando se hace clic en el bot�n4 (por ejemplo, bot�n "Salir")
        private void button4_Click(object sender, EventArgs e)
        {
            // Cerrar sesi�n al salir
            Sesiones.Instance.CerrarSesion(); // Limpia el usuario actual y el m�dulo
            MessageBox.Show("Gracias por usar el sistema"); // Muestra mensaje de despedida
            this.Close(); // Cierra el formulario actual
        }

        // M�todo gen�rico para abrir cualquier formulario que herede de Form, solo si hay un usuario logueado
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
                    return; // Salir del m�todo si el login fall�
                }
            }

            // Si el usuario est� logueado, crea y muestra el formulario solicitado
            T formulario = new T(); // Crea una nueva instancia del formulario T
            formulario.ShowDialog(); // Muestra el formulario como ventana modal
        }

        // M�todo que guarda una lista de usuarios en un archivo de texto como JSON
        public void escribeBase()
        {
            // Crea una lista de usuarios de ejemplo
            List<Usuarios> list = new List<Usuarios>
        {
            new Usuarios { nombre = "Juan", id = 1, direccion = "por ah�", clave = "12345" },
            new Usuarios { nombre = "Pedro", id = 2, direccion = "m�s all�", clave = "666666" }
        };

            // Convierte la lista a formato JSON con sangr�a
            string json = JsonSerializer.Serialize(list, new JsonSerializerOptions { WriteIndented = true });

            // Guarda el JSON en un archivo llamado "usuarios.txt"
            File.WriteAllText("usuarios.txt", json);
        }
    }

}

