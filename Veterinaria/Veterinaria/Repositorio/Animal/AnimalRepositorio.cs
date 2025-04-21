using Veterinaria.Datos;

namespace Veterinaria.Repositorio.Animal
{
    public class AnimalRepositorio : IAnimalRepositorio
    {
        private readonly ApplicationDbContext _context;

        public AnimalRepositorio(ApplicationDbContext context)
        {
            _context = context;
        }
        public Datos.Entidades.Animal ObtenerAnimal(int id)
        {
            return _context.Animales.FirstOrDefault(x => x.idAnimal == id);
        }
    }
}
