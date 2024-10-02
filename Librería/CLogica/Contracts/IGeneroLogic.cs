using CEntidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLogica.Contracts
{
    public interface IGeneroLogic
    {
        Task<List<Genero>> GetAll();

        void AltaGenero(Genero generoNuevo);

        void ActualizarGenero(string nombre, Genero generoActualizar);

        void EliminarGenero(string nombre);

    }
}
