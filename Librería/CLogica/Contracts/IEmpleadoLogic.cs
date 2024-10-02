using CDatos.Repositories;
using CEntidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLogica.Contracts
{
    public interface IEmpleadoLogic
    {

        Task<List<Empleado>> GetAll();

        void AltaEmpleado(Empleado empleadoNuevo);

        void ActualizarEmpleado(string documento, Empleado empleadoActulizar);

        void EliminarEmpleado(string documento);

    }
}
