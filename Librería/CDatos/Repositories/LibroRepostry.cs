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
    public class LibroRepostry : Repository<Libro>, ILibroRepository
    {
        public LibroRepostry(LibreriaContext context) : base(context) { }
        public async Task<List<Libro>> GetAll()
        {
            try
            {
                return await _context.Libro.ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
