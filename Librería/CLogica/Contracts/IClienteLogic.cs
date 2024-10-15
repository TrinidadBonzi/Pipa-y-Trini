using CEntidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLogica.Contracts
{
    public interface IClienteLogic
    {
        List<dynamic> ObtenerClientesParaListado();
        List<Cliente> ObtenerClientes();

        void AltaCliente(Cliente nuevoCliente);

        void ActualizarCliente(string documento, Cliente clienteActualizar);

        void EliminarCliente(string documento);

    }
}
