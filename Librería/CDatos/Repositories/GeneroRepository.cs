using CDatos.Contexts;
using CDatos.Repositories.Contracts;
using CEntidades.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDatos.Repositories
{
    public class GeneroRepository : Repository<Genero>, IGeneroRepository
    {
        public GeneroRepository(LibreriaContext context) : base(context)
        {

        }

        public async Task<List<Genero>> GetAll()
        {
            try
            {
                return await _context.Genero.ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
