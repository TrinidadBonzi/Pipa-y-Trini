using Microsoft.AspNetCore.Mvc;
using Veterinaria.Datos.Dtos;
using Veterinaria.Logica.Animal;

namespace Veterinaria.Controllers
{
    [Route("animales")]
    [ApiController]
    public class AnimalController : ControllerBase
    {
        private readonly IAnimalLogica _animalLogica;
        public AnimalController(IAnimalLogica animalLogica)
        {
            _animalLogica = animalLogica;
        }
        
        [HttpGet("{id}")]
        public IActionResult ObtenerPorId(int id)
        {
            AnimalDto animalDto = _animalLogica.ObtenerAnimal(id);

            if (animalDto == null)
            {
                return NotFound();
            }

            return Ok(animalDto);
        }
        [HttpDelete("{id}")]
        public IActionResult Eliminar(int id)
        {
            bool eliminado = _animalLogica.EliminarAnimal(id);
            if (!eliminado)
                return NotFound();

            return NoContent();
        }

    }
}
