using CEntidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLogica.Contracts
{
    public interface IPersonaLogic
    {
        Task<List<Persona>> GetAll();

        Persona AltaPersona(Persona persona);

        void ActualizarPersona(string documento, Persona personaActualizar);

        void EliminarPersona(string documento);


    }
}
