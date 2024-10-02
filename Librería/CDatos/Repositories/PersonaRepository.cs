using CDatos.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDatos.Contexts;
using CEntidades.Entidades;
using Microsoft.EntityFrameworkCore;

namespace CDatos.Repositories
{
    public class PersonaRepository : Repository<Persona>, IPersonaRepository
    {
        public PersonaRepository(LibreriaContext context) : base(context) { }

        public async Task<List<Persona>> GetAll()
        {
            try
            {
                return await _context.Persona.ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
