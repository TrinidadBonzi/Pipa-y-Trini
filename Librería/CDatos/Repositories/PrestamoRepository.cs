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
    public class PrestamoRepository : Repository<Prestamo>, IPrestamoRepository
    {
        public PrestamoRepository(LibreriaContext context) : base(context) { }

        public async Task<List<Prestamo>> GetAll()
        {
            try
            {
                return await _context.Prestamo.ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
