using CDatos.Repositories.Contracts;
using CEntidades.Entidades;
using CLogica.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLogica.Implementations
{
    public class EmpleadoLogic : IEmpleadoLogic
    { 
        private IEmpleadoRepository _empleadoRepository;

        public EmpleadoLogic(IEmpleadoRepository empleadorepository)
        {
            _empleadoRepository = empleadorepository;
        }

        public async Task<List<Empleado>> GetAll()
        {
            return await _empleadoRepository.GetAll();
        }

        public void AltaEmpleado(Empleado empleadoNuevo)
        {
            List<string> camposErroneos = new List<string>();
            if (string.IsNullOrEmpty(empleadoNuevo.Persona.Nombre) || !IsValidName(empleadoNuevo.Persona.Nombre))
                camposErroneos.Add("Nombre");

            if (string.IsNullOrEmpty(empleadoNuevo.Persona.Apellido) || !IsValidName(empleadoNuevo.Persona.Apellido))
                camposErroneos.Add("Apellido");

            if (string.IsNullOrEmpty(empleadoNuevo.Persona.Documento) || !IsValidDocumento(empleadoNuevo.Persona.Documento) || _empleadoRepository.FindByCondition(p => p.Persona.Documento == empleadoNuevo.Persona.Documento).Count() != 0)
                camposErroneos.Add("Documento");

            if (string.IsNullOrEmpty(empleadoNuevo.Persona.Telefono) || !IsValidTelefono(empleadoNuevo.Persona.Telefono))
                camposErroneos.Add("Teléfono");

            if (string.IsNullOrEmpty(empleadoNuevo.Persona.Email) || !IsValidEmail(empleadoNuevo.Persona.Email))
                camposErroneos.Add("Email");

            if (string.IsNullOrEmpty(empleadoNuevo.Cargo) || !IsValidCargo(empleadoNuevo.Cargo))
                camposErroneos.Add("Cargo");

            if (empleadoNuevo.Sueldo == 0 || !IsValidSueldo(empleadoNuevo.Cargo, empleadoNuevo.Sueldo))
                camposErroneos.Add("Sueldo");

            if (camposErroneos.Count > 0)
            {
                throw new ArgumentException("Los siguientes campos son inválidos: ", string.Join(", ", camposErroneos));
            }

            Empleado empleado = new Empleado();
            empleado.Persona.Nombre = empleadoNuevo.Persona.Nombre;
            empleado.Persona.Apellido = empleadoNuevo.Persona.Apellido;
            empleado.Persona.Nacionalidad = empleadoNuevo.Persona.Nacionalidad;
            empleado.Persona.Documento = empleadoNuevo.Persona.Documento;
            empleado.Persona.Telefono = empleadoNuevo.Persona.Telefono;
            empleado.Persona.Email = empleadoNuevo.Persona.Email;
            empleado.Persona.TipoDocumento = empleadoNuevo.Persona.TipoDocumento;
            empleado.Cargo = empleadoNuevo.Cargo;
            empleado.Sueldo = empleadoNuevo.Sueldo;


            _empleadoRepository.Create(empleado);
            _empleadoRepository.Save();
        }

        public void ActualizarEmpleado(string documento, Empleado empleadoActualizar)
        {
            List<string> camposErroneos = new List<string>();
            if (string.IsNullOrEmpty(empleadoActualizar.Persona.Nombre) || !IsValidName(empleadoActualizar.Persona.Nombre))
                camposErroneos.Add("Nombre");

            if (string.IsNullOrEmpty(empleadoActualizar.Persona.Apellido) || !IsValidName(empleadoActualizar.Persona.Apellido))
                camposErroneos.Add("Apellido");

            if (string.IsNullOrEmpty(empleadoActualizar.Persona.Documento) || !IsValidDocumento(empleadoActualizar.Persona.Documento))
                camposErroneos.Add("Documento");

            if (string.IsNullOrEmpty(empleadoActualizar.Persona.Telefono) || !IsValidTelefono(empleadoActualizar.Persona.Telefono))
                camposErroneos.Add("Teléfono");

            if (string.IsNullOrEmpty(empleadoActualizar.Persona.Email) || !IsValidEmail(empleadoActualizar.Persona.Email))
                camposErroneos.Add("Email");

            if (string.IsNullOrEmpty(empleadoActualizar.Cargo) || !IsValidCargo(empleadoActualizar.Cargo))
                camposErroneos.Add("Cargo");

            if (empleadoActualizar.Sueldo == 0 || !IsValidSueldo(empleadoActualizar.Cargo, empleadoActualizar.Sueldo))
                camposErroneos.Add("Sueldo");
            

            if (camposErroneos.Count > 0)
            {
                throw new ArgumentException("Los siguientes campos son inválidos: ", string.Join(", ", camposErroneos));
            }

            if (string.IsNullOrEmpty(documento) || !IsValidDocumento(documento))
                throw new ArgumentException("El documento ingresado es inválido.");

            Empleado? empleado = _empleadoRepository.FindByCondition(p => p.Persona.Documento == documento).FirstOrDefault();

            if (empleado == null)
            {
                throw new ArgumentNullException("No se ha encontrado un empleado con ese documento");
            }

            empleado.Persona.Nombre = empleadoActualizar.Persona.Nombre;
            empleado.Persona.Apellido = empleadoActualizar.Persona.Apellido;
            empleado.Persona.Nacionalidad = empleadoActualizar.Persona.Nacionalidad;
            empleado.Persona.Documento = empleadoActualizar.Persona.Documento;
            empleado.Persona.Telefono = empleadoActualizar.Persona.Telefono;
            empleado.Persona.Email = empleadoActualizar.Persona.Email;
            empleado.Persona.TipoDocumento = empleadoActualizar.Persona.TipoDocumento;
            empleado.Cargo = empleadoActualizar.Cargo;
            empleado.Sueldo = empleadoActualizar.Sueldo;

            _empleadoRepository.Create(empleado);
            _empleadoRepository.Save();
        }

        public void EliminarEmpleado(string documento)
        {
            if (string.IsNullOrEmpty(documento) || !IsValidDocumento(documento))
                throw new ArgumentException("El documento ingresado es inválido.");

            Empleado? empleado = _empleadoRepository.FindByCondition(p => p.Persona.Documento == documento).FirstOrDefault();

            if (empleado == null)
            {
                throw new ArgumentNullException("No se ha encontrado un empleado con ese documento");
            }
            _empleadoRepository.Delete(empleado);
            _empleadoRepository.Save();
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
        public bool IsValidCargo(string cargo)
        {
            var cargosValidos = new List<string> { "Gerente", "Supervisor", "Asistente", "Operario" };

            return cargosValidos.Contains(cargo, StringComparer.OrdinalIgnoreCase);
        }

        public bool IsValidSueldo(string cargo, float sueldo)
        {
            if (string.Equals(cargo, "Gerente", StringComparison.OrdinalIgnoreCase))
            {
                return sueldo >= 3000 && sueldo <= 7000;
            }
            else if (string.Equals(cargo, "Supervisor", StringComparison.OrdinalIgnoreCase))
            {
                return sueldo >= 2000 && sueldo <= 4000;
            }
            else if (string.Equals(cargo, "Asistente", StringComparison.OrdinalIgnoreCase))
            {
                return sueldo >= 1500 && sueldo <= 2500;
            }
            else if (string.Equals(cargo, "Operario", StringComparison.OrdinalIgnoreCase))
            {
                return sueldo >= 1000 && sueldo <= 2000;
            }
            // Si el cargo no es válido, el sueldo no es válido
            return false;
        }

        #endregion validaciones 
    }
}
