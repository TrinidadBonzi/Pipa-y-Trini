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
            return _autorRepository.ObtenerAutores().Select(a => new { IdAutor = a.IdAutor, Nombre = a.Persona.Nombre, Apellido = a.Persona.Apellido, Telefono = a.Persona.Telefono, Nacionalidad = a.Persona.Nacionalidad, Email = a.Persona.Email, Biografia = a.Biografia }).ToList<dynamic>();
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

        public void ActualizarAutor(string documento, Autor autorActualizar)
        {
            List<string> camposErroneos = new List<string>();
            if (string.IsNullOrEmpty(autorActualizar.Persona.Nombre) || !IsValidName(autorActualizar.Persona.Nombre))
                camposErroneos.Add("Nombre");

            if (string.IsNullOrEmpty(autorActualizar.Persona.Apellido) || !IsValidName(autorActualizar.Persona.Apellido))
                camposErroneos.Add("Apellido");

            if (string.IsNullOrEmpty(autorActualizar.Persona.Documento) || !IsValidDocumento(autorActualizar.Persona.Documento))
                camposErroneos.Add("Documento");

            if (string.IsNullOrEmpty(autorActualizar.Persona.Telefono) || !IsValidTelefono(autorActualizar.Persona.Telefono))
                camposErroneos.Add("Teléfono");

            if (string.IsNullOrEmpty(autorActualizar.Persona.Email) || !IsValidEmail(autorActualizar.Persona.Email))
                camposErroneos.Add("Email");

            if (string.IsNullOrEmpty(autorActualizar.Biografia) || !IsValidBiografia(autorActualizar.Biografia))
                camposErroneos.Add("Biografia");

            if (camposErroneos.Count > 0)
            {
                throw new ArgumentException("Los siguientes campos son inválidos: ", string.Join(", ", camposErroneos));
            }

            if (string.IsNullOrEmpty(documento) || !IsValidDocumento(documento))
                throw new ArgumentException("El documento ingresado es inválido.");

            Autor? autor = _autorRepository.FindByCondition(p => p.Persona.Documento == documento).FirstOrDefault();

            if (autor == null)
            {
                throw new ArgumentNullException("No se ha encontrado un autor con ese documento");
            }

            autor.Persona.Nombre = autorActualizar.Persona.Nombre;
            autor.Persona.Apellido = autorActualizar.Persona.Apellido;
            autor.Persona.Nacionalidad = autorActualizar.Persona.Nacionalidad;
            autor.Persona.Documento = autorActualizar.Persona.Documento;
            autor.Persona.Telefono = autorActualizar.Persona.Telefono;
            autor.Persona.Email = autorActualizar.Persona.Email;
            autor.Persona.TipoDocumento = autorActualizar.Persona.TipoDocumento;
            autor.Biografia = autorActualizar.Biografia;

            _autorRepository.Create(autor);
            _autorRepository.Save();
        }

        public void EliminarAutor(string documento)
        {
            if (string.IsNullOrEmpty(documento) || !IsValidDocumento(documento))
                throw new ArgumentException("El documento ingresado es inválido.");

            Autor? autor = _autorRepository.FindByCondition(p => p.Persona.Documento == documento).FirstOrDefault();

            if (autor == null)
            {
                throw new ArgumentNullException("No se ha encontrado un autor con ese documento");
            }
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