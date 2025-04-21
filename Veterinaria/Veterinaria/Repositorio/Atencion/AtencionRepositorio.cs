using Veterinaria.Datos;


namespace Veterinaria.Repositorio.Atencion
{
    public class AtencionRepositorio : IAtencionRepositorio
    {
        private readonly ApplicationDbContext _context;

        public AtencionRepositorio(ApplicationDbContext context)
        {
            _context = context;
        }
        public Datos.Entidades.Atencion ObtenerAtencion(int id)
        {
            return _context.Atenciones.FirstOrDefault(x => x.idAtencion == id);
        }
    }
}
