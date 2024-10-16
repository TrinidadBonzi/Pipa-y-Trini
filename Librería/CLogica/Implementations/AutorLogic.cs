using CDatos.Repositories;
using CDatos.Repositories.Contracts;
using CEntidades.Entidades;
using CLogica.Contracts;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CLogica.Implementations
{
    public class AutorLogic : IAutorLogic
    {
        private IAutorRepository _autorRepository;

        private IPersonaLogic _personaLogic;

        public AutorLogic(IAutorRepository AutorRepository, IPersonaLogic personaLogic)
        {
            _autorRepository = AutorRepository;
            _personaLogic = personaLogic;
        }

        public List<Autor> ObtenerAutores()
        {
            return _autorRepository.FindAll().ToList();
        }

        public List<dynamic> ObtenerAutoresParaListado()
        {
            return _autorRepository.ObtenerAutores().Select(a => new { IdAutor = a.IdAutor, Nombre = a.Persona.Nombre, Apellido = a.Persona.Apellido, Nacionalidad = a.Persona.Nacionalidad, Email = a.Persona.Email, Telefono = a.Persona.Telefono, Biografia = a.Biografia }).ToList<dynamic>();
        }

        public void AltaAutor(string nombre, string apellido, string nacionalidad, string email, string telefono, string biografia)
        {
            try
            {
                Persona personaNueva = new Persona()
                {
                    Nombre = nombre,
                    Apellido = apellido,
                    Telefono = telefono,
                    Email = email,
                    Nacionalidad = nacionalidad
                };

                Persona persona = _personaLogic.AltaPersona(personaNueva);

                Autor autorNuevo = new Autor()
                {
                    Persona = persona,
                    Biografia = biografia
                };

                List<string> camposErroneos = new List<string>();

                if (string.IsNullOrEmpty(autorNuevo.Biografia))
                    camposErroneos.Add("Biografia");

                if (camposErroneos.Count > 0)
                {
                    throw new ArgumentException("Los siguientes campos son inválidos: ", string.Join(", ", camposErroneos));
                }

                _autorRepository.CreateAutor(autorNuevo);
                _autorRepository.Save();
            }
            catch(Exception)
            {
                throw;
            }
        }

        public void ActualizarAutor(int id, string nombre, string apellido, string nacionalidad, string email, string telefono, string biografia)
        {
            // Buscamos el autor en la base de datos por su ID
            Autor? autor = _autorRepository.FindByCondition(a => a.Persona.IdPersona == id).FirstOrDefault();

            if (autor == null)
            {
                throw new ArgumentNullException("No se ha encontrado un autor con ese ID.");
            }

            // Actualizamos los campos con los nuevos valores
            autor.Persona.Nombre = nombre;
            autor.Persona.Apellido = apellido;
            autor.Persona.Nacionalidad = nacionalidad;
            autor.Persona.Email = email;
            autor.Persona.Telefono = telefono;
            autor.Biografia = biografia;

            // Guardamos los cambios en la base de datos
            _autorRepository.Update(autor);
            _autorRepository.Save();
        }

        public void EliminarAutor(string id)
        {
            if (string.IsNullOrEmpty(id))
                throw new ArgumentException("El documento ingresado es inválido.");

            // Intentamos convertir el 'id' a un entero
            if (!int.TryParse(id, out int idPersona))
                throw new ArgumentException("El ID proporcionado no es un número válido.");

            // Buscamos el autor usando el 'idPersona' que ahora es de tipo int
            Autor? autor = _autorRepository.FindByCondition(p => p.Persona.IdPersona == idPersona).FirstOrDefault();

            if (autor == null)
            {
                throw new ArgumentNullException("No se ha encontrado un autor con ese ID");
            }

            // Eliminamos el autor si fue encontrado
            _autorRepository.Delete(autor);
            _autorRepository.Save();
        }


        #region validaciones
        private bool ContainsInvalidCharacter(string text)
        {
            char[] caracteres = { '!', '"', '#', '$', '%', '/', '(', ')', '=', '.', ',' };
            return caracteres.Any(c => text.Contains(c));
        }
        private bool IsValidName(string nombre)
        {
            return nombre.Length < 15 && !ContainsInvalidCharacter(nombre);
        }
        private bool IsValidDocumento(string documento)
        {
            return documento.Length == 8 && documento.All(c => Char.IsNumber(c));
        }
        public bool IsValidTelefono(string telefono)
        {
            return telefono.Length == 10 && telefono.All(c => Char.IsNumber(c));
        }
        public bool IsValidEmail(string email)
        {
            return email.Contains('@') && !ContainsInvalidCharacter(email);
        }
        private bool IsValidBiografia(string biografia)
        {
            return biografia.Length < 32 && !ContainsInvalidCharacter(biografia);
        }

        #endregion validaciones 

    }
}