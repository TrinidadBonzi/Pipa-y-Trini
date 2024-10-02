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
    public class CopiaRepository : Repository<Copia>, ICopiaRepository
    {
        public CopiaRepository (LibreriaContext context) : base(context) { }
        public async Task<List<Copia>> GetAll()
        {
            try
            {
                return await _context.Copia.ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
