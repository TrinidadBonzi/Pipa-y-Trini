using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEntidades.Entidades;
namespace CDatos.Repositories.Contracts
{
    public interface IPersonaRepository : IRepository<Persona>
    {
        Task<List<Persona>> GetAll();
    }
}
