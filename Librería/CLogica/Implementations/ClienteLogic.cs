using CDatos.Repositories;
using CDatos.Repositories.Contracts;
using CEntidades.Entidades;
using CLogica.Contracts;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLogica.Implementations
{
    public class ClienteLogic : IClienteLogic
    {
        private IClienteRepository _clienteRepository;

        private IPersonaLogic _personaLogic;

        public ClienteLogic(IClienteRepository ClienteRepository, IPersonaLogic personaLogic)
        {
            _clienteRepository = ClienteRepository;
            _personaLogic = personaLogic;
        }

        public List<Cliente> ObtenerClientes()
        {
            return _clienteRepository.FindAll().ToList();
        }

        public List<dynamic> ObtenerClientesParaListado()
        {
            return _clienteRepository.ObtenerClientes().Select(a => new { IdCliente = a.IdCliente, Nombre = a.Persona.Nombre, Apellido = a.Persona.Apellido, Documento = a.Persona.Documento, Telefono = a.Persona.Telefono, Nacionalidad = a.Persona.Nacionalidad, Email = a.Persona.Email, Socio = a.EsSocio, Iva = a.PagaIVA}).ToList<dynamic>();
        }

        public void AltaCliente(string nombre, string apellido, string documento, string nacionalidad, string email, string telefono, string socio, string iva)
        {
            try
            {
                
                Persona personaNueva = new Persona()
                {
                    Nombre = nombre,
                    Apellido = apellido,
                    Documento = documento,
                    Telefono = telefono,
                    Email = email,
                    Nacionalidad = nacionalidad
                };

               
                Persona persona = _personaLogic.AltaPersona(personaNueva);

                
                bool esSocio = socio.Equals("Sí", StringComparison.OrdinalIgnoreCase); 
                bool pagaIVA = iva.Equals("Sí", StringComparison.OrdinalIgnoreCase); 

              
                Cliente clienteNuevo = new Cliente()
                {
                    Persona = persona,
                    EsSocio = esSocio,
                    PagaIVA = pagaIVA,
                };

                

               
                _clienteRepository.CreateCliente(clienteNuevo);
                _clienteRepository.Save(); // Asegúrate de que este método esté implementado en tu repositorio
            }
            catch (Exception ex)
            {
             
                throw new Exception("Error al dar de alta el cliente: " + ex.Message, ex);
            }
        }

        public void ActualizarCliente(int id, string nombre, string apellido, string documento, string nacionalidad, string email, string telefono, string socio, string iva)
        {
            // Asegúrate de que estás buscando por IdCliente
            Cliente? cliente = _clienteRepository.FindByCondition(a => a.IdCliente == id).FirstOrDefault();

            if (cliente == null)
            {
                throw new ArgumentNullException("No se ha encontrado un cliente con ese ID.");
            }

            // Actualiza los campos de cliente
            cliente.Persona.Nombre = nombre;
            cliente.Persona.Apellido = apellido;
            cliente.Persona.Documento = documento;
            cliente.Persona.Nacionalidad = nacionalidad;
            cliente.Persona.Email = email;
            cliente.Persona.Telefono = telefono;

            cliente.EsSocio = bool.TryParse(socio, out bool esSocio) && esSocio;
            cliente.PagaIVA = bool.TryParse(iva, out bool pagaIva) && pagaIva;

            _clienteRepository.Update(cliente);
            _clienteRepository.Save();
        }


        public void EliminarCliente(string id)
        {
            if (string.IsNullOrEmpty(id))
                throw new ArgumentException("El ID ingresado es inválido.");

            // Asegúrate de que 'id' se refiere al IdCliente y no al IdPersona
            if (!int.TryParse(id, out int idCliente))
                throw new ArgumentException("El ID proporcionado no es un número válido.");

            // Busca al cliente usando IdCliente en lugar de IdPersona
            Cliente? cliente = _clienteRepository.FindByCondition(p => p.IdCliente == idCliente).FirstOrDefault();

            if (cliente == null)
            {
                throw new ArgumentNullException("No se ha encontrado un cliente con ese ID.");
            }

            // Aquí eliminas al cliente
            _clienteRepository.Delete(cliente);
            _clienteRepository.Save();
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
            public bool IsValidEsSocio(string EsSocio)
            {
                return EsSocio.Equals("si", StringComparison.OrdinalIgnoreCase) && EsSocio.Equals("no", StringComparison.OrdinalIgnoreCase);
            }

            public bool IsValidPagaIVA(string PagaIVA)
            {
                return PagaIVA.Equals("si", StringComparison.OrdinalIgnoreCase) && PagaIVA.Equals("no", StringComparison.OrdinalIgnoreCase);
            }

        #endregion validaciones 
    }
}

