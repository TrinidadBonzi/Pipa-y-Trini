using ClassLibrary1; 
using System; 
using System.Collections.Generic; 
using System.Text.Json; 

// Clase Sesiones: controla el inicio y cierre de sesión. Usa el patrón Singleton (solo una instancia).
public sealed class Sesiones
{
    // Instancia única de la clase Sesiones (patrón Singleton)
    private static readonly Sesiones _instance = new Sesiones();

    // Objeto para asegurar acceso seguro desde múltiples hilos (thread-safe)
    private static readonly object _lock = new object();

    // Propiedad que guarda el usuario que está actualmente logueado
    public Usuarios UsuarioActual { get; private set; }

    // Propiedad que indica en qué módulo del sistema se encuentra el usuario (por ejemplo: "Clientes", "Ventas")
    public string ModuloActual { get; set; }

    // Contador de intentos fallidos de inicio de sesión
    private int _intentosFallidos = 0;

    // Lista de usuarios simulada (como si fueran los registrados en una base de datos)
    private List<Usuarios> _usuariosRegistrados = new List<Usuarios>
    {
        new Usuarios { nombre = "admin", clave = "123", id = 1, direccion = "Calle 123" }
    };

    // Constructor privado para que no se pueda crear una instancia desde fuera de la clase
    private Sesiones() { }

    // Propiedad pública para acceder a la única instancia de la clase
    public static Sesiones Instance
    {
        get
        {
            // Asegura que solo un hilo pueda acceder a la instancia a la vez
            lock (_lock)
            {
                return _instance;
            }
        }
    }

    // Método para iniciar sesión. Devuelve true si el login es correcto, false si es incorrecto.
    public bool Login(string nombreUsuario, string clave)
    {
        lock (_lock) // Protege esta sección de código contra accesos simultáneos
        {
            // Busca un usuario en la lista que coincida con el nombre y la clave
            var usuario = _usuariosRegistrados.Find(u => u.nombre == nombreUsuario && u.clave == clave);

            if (usuario != null)
            {
                // Si lo encuentra, lo asigna como UsuarioActual y reinicia el contador de intentos
                UsuarioActual = usuario;
                _intentosFallidos = 0;
                return true; // Login exitoso
            }
            else
            {
                // Si no encuentra un usuario válido, suma un intento fallido
                _intentosFallidos++;

                // Si ya falló 3 veces, muestra un mensaje y cierra la aplicación
                if (_intentosFallidos >= 3)
                {
                    Console.WriteLine("Demasiados intentos fallidos. Cerrando sistema...");
                    Environment.Exit(0); // Cierra el programa
                }

                return false; // Login fallido
            }
        }
    }

    // Método para cerrar sesión, borra el usuario y el módulo actual
    public void CerrarSesion()
    {
        UsuarioActual = null;
        ModuloActual = null;
    }

    // Método que carga una nueva lista de usuarios desde un texto JSON
    public void CargarUsuariosDesdeJson(string json)
    {
        try
        {
            // Intenta convertir el JSON en una lista de usuarios
            _usuariosRegistrados = JsonSerializer.Deserialize<List<Usuarios>>(json) ?? new List<Usuarios>();
        }
        catch
        {
            // Si ocurre un error (por ejemplo el JSON está mal formado), deja la lista vacía
            _usuariosRegistrados = new List<Usuarios>();
        }
    }
}
