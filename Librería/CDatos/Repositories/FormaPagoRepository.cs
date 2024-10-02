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
    public class FormaPagoRepository : Repository<FormaPago>, IFormaPagoRepository
    {
        public FormaPagoRepository(LibreriaContext context) : base(context)
        {

        }

        public async Task<List<FormaPago>> GetAll()
        {
            try
            {
                return await _context.FormaPago.ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
