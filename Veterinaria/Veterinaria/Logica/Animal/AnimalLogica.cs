using Microsoft.AspNetCore.Razor.Hosting;
using Veterinaria.Datos.Dtos;
using Veterinaria.Repositorio.Animal;

namespace Veterinaria.Logica.Animal
{
    public class AnimalLogica : IAnimalLogica
    {
        private readonly IAnimalRepositorio _animalRepositorio;

        public AnimalLogica(IAnimalRepositorio animalRepositorio)
        {
            _animalRepositorio = animalRepositorio;
        }
        public AnimalDto ObtenerAnimal(int id)
        {
            Datos.Entidades.Animal animal = _animalRepositorio.ObtenerAnimal(id);

            if (animal == null)
            {
                return null;
            }

            return new AnimalDto
            {
                idAnimal = animal.idAnimal,
                nombreAnimal = animal.nombreAnimal,
                razaAnimal = animal.razaAnimal,
                edadAnimal = animal.edadAnimal,
                sexoAnimal = animal.sexoAnimal,
            };
        }
    }
}
