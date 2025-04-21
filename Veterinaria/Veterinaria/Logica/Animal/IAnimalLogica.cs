using Veterinaria.Datos.Dtos;

namespace Veterinaria.Logica.Animal
{
    public interface IAnimalLogica
    {
        AnimalDto ObtenerAnimal(int id);
        bool EliminarAnimal(int id);

    }
}
