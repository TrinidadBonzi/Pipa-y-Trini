using Veterinaria.Datos;

namespace Veterinaria.Repositorio.Duenio
{
    public class DuenioRepositorio : IDuenioRepositorio
    {
        private readonly ApplicationDbContext _context;

        public DuenioRepositorio(ApplicationDbContext context)
        {
            _context = context;
        }
        public Datos.Entidades.Duenio ObtenerDuenio(int id)
        {
            return _context.Duenios.FirstOrDefault(x => x.idDuenio == id);
        }
    }
}
