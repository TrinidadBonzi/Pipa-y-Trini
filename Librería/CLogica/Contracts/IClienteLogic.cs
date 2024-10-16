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

        void AltaCliente(string nombre, string apellido, string documento, string nacionalidad, string email, string telefono, string socio, string iva);

        void ActualizarCliente(int id, string nombre, string apellido, string documento, string nacionalidad, string email, string telefono, string socio, string iva);

        void EliminarCliente(string id);

    }
}
