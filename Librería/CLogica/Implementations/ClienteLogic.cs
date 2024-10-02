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

            public ClienteLogic(IClienteRepository clienteRepository)
            {
                _clienteRepository = clienteRepository;
            }

            public async Task<List<Cliente>> GetAll()
            {
                return await _clienteRepository.GetAll();
            }

            public void AltaCliente(Cliente clienteNuevo)
            {
                List<string> camposErroneos = new List<string>();
                if (string.IsNullOrEmpty(clienteNuevo.Persona.Nombre) || !IsValidName(clienteNuevo.Persona.Nombre))
                    camposErroneos.Add("Nombre");

                if (string.IsNullOrEmpty(clienteNuevo.Persona.Apellido) || !IsValidName(clienteNuevo.Persona.Apellido))
                    camposErroneos.Add("Apellido");

                if (string.IsNullOrEmpty(clienteNuevo.Persona.Documento) || !IsValidDocumento(clienteNuevo.Persona.Documento) || _clienteRepository.FindByCondition(p => p.Persona.Documento == clienteNuevo.Persona.Documento).Count() != 0)
                    camposErroneos.Add("Documento");

                if (string.IsNullOrEmpty(clienteNuevo.Persona.Telefono) || !IsValidTelefono(clienteNuevo.Persona.Telefono))
                    camposErroneos.Add("Teléfono");

                if (string.IsNullOrEmpty(clienteNuevo.Persona.Email) || !IsValidEmail(clienteNuevo.Persona.Email))
                    camposErroneos.Add("Email");

                if (!clienteNuevo.EsSocio.ToString().Equals("true", StringComparison.OrdinalIgnoreCase) && !clienteNuevo.EsSocio.ToString().Equals("false", StringComparison.OrdinalIgnoreCase))
                camposErroneos.Add("EsSocio");

                if (!clienteNuevo.PagaIVA.ToString().Equals("true", StringComparison.OrdinalIgnoreCase) && !clienteNuevo.PagaIVA.ToString().Equals("false", StringComparison.OrdinalIgnoreCase))
                camposErroneos.Add("PagaIVA");

            if (camposErroneos.Count > 0)
                {
                    throw new ArgumentException("Los siguientes campos son inválidos: ", string.Join(", ", camposErroneos));
                }

                Cliente cliente = new Cliente();
                cliente.Persona.Nombre = clienteNuevo.Persona.Nombre;
                cliente.Persona.Apellido = clienteNuevo.Persona.Apellido;
                cliente.Persona.Nacionalidad = clienteNuevo.Persona.Nacionalidad;
                cliente.Persona.Documento = clienteNuevo.Persona.Documento;
                cliente.Persona.Telefono = clienteNuevo.Persona.Telefono;
                cliente.Persona.Email = clienteNuevo.Persona.Email;
                cliente.Persona.TipoDocumento = clienteNuevo.Persona.TipoDocumento;
                cliente.EsSocio = clienteNuevo.EsSocio;
                cliente.PagaIVA = clienteNuevo.PagaIVA;


                _clienteRepository.Create(cliente);
                _clienteRepository.Save();
            }

            public void ActualizarCliente(string documento, Cliente clienteActualizar)
            {
                List<string> camposErroneos = new List<string>();
                if (string.IsNullOrEmpty(clienteActualizar.Persona.Nombre) || !IsValidName(clienteActualizar.Persona.Nombre))
                    camposErroneos.Add("Nombre");

                if (string.IsNullOrEmpty(clienteActualizar.Persona.Apellido) || !IsValidName(clienteActualizar.Persona.Apellido))
                    camposErroneos.Add("Apellido");

                if (string.IsNullOrEmpty(clienteActualizar.Persona.Documento) || !IsValidDocumento(clienteActualizar.Persona.Documento))
                    camposErroneos.Add("Documento");

                if (string.IsNullOrEmpty(clienteActualizar.Persona.Telefono) || !IsValidTelefono(clienteActualizar.Persona.Telefono))
                    camposErroneos.Add("Teléfono");

                if (string.IsNullOrEmpty(clienteActualizar.Persona.Email) || !IsValidEmail(clienteActualizar.Persona.Email))
                    camposErroneos.Add("Email");

                if (!clienteActualizar.EsSocio.ToString().Equals("true", StringComparison.OrdinalIgnoreCase) && !clienteActualizar.EsSocio.ToString().Equals("false", StringComparison.OrdinalIgnoreCase))
                camposErroneos.Add("EsSocio");

                if (!clienteActualizar.PagaIVA.ToString().Equals("true", StringComparison.OrdinalIgnoreCase) && !clienteActualizar.PagaIVA.ToString().Equals("false", StringComparison.OrdinalIgnoreCase))
                camposErroneos.Add("PagaIVA");

            if (camposErroneos.Count > 0)
                {
                    throw new ArgumentException("Los siguientes campos son inválidos: ", string.Join(", ", camposErroneos));
                }

                if (string.IsNullOrEmpty(documento) || !IsValidDocumento(documento))
                    throw new ArgumentException("El documento ingresado es inválido.");

                Cliente? cliente = _clienteRepository.FindByCondition(p => p.Persona.Documento == documento).FirstOrDefault();

                if (cliente == null)
                {
                    throw new ArgumentNullException("No se ha encontrado un cliente con ese documento");
                }

                cliente.Persona.Nombre = clienteActualizar.Persona.Nombre;
                cliente.Persona.Apellido = clienteActualizar.Persona.Apellido;
                cliente.Persona.Nacionalidad = clienteActualizar.Persona.Nacionalidad;
                cliente.Persona.Documento = clienteActualizar.Persona.Documento;
                cliente.Persona.Telefono = clienteActualizar.Persona.Telefono;
                cliente.Persona.Email = clienteActualizar.Persona.Email;
                cliente.Persona.TipoDocumento = clienteActualizar.Persona.TipoDocumento;
                cliente.EsSocio = clienteActualizar.EsSocio;
                cliente.PagaIVA = clienteActualizar.PagaIVA;

                _clienteRepository.Create(cliente);
                _clienteRepository.Save();
            }

            public void EliminarCliente(string documento)
            {
                if (string.IsNullOrEmpty(documento) || !IsValidDocumento(documento))
                    throw new ArgumentException("El documento ingresado es inválido.");

                Cliente? cliente = _clienteRepository.FindByCondition(p => p.Persona.Documento == documento).FirstOrDefault();

                if (cliente == null)
                {
                    throw new ArgumentNullException("No se ha encontrado un cliente con ese documento");
                }
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

