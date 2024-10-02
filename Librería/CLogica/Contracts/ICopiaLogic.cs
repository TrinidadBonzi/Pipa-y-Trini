using CEntidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLogica.Contracts
{
    public interface ICopiaLogic
    {

        Task<List<Copia>> GetAll();

        void AltaCopia(Copia copiaNueva);

        void ActualizarCopia(string ISBN, Copia copiaActualizar);

        void EliminarCopia(string ISBN);
    }
}
