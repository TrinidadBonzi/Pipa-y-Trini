using Microsoft.AspNetCore.Mvc;
using Veterinaria.Datos.Dtos;
using Veterinaria.Logica.Duenio;

namespace Veterinaria.Controllers
{
    [Route("duenios")]
    [ApiController]
    public class DuenioController : ControllerBase
    {
        private readonly IDuenioLogica _duenioLogica;
        public DuenioController(IDuenioLogica duenioLogica)
        {
            _duenioLogica = duenioLogica;
        }

        [HttpGet("{id}")]
        public IActionResult ObtenerPorId(int id)
        {
            DuenioDto duenioDto = _duenioLogica.ObtenerDuenio(id);

            if (duenioDto == null)
            {
                return NotFound();
            }

            return Ok(duenioDto);
        }
        [HttpDelete("{id}")]
        public IActionResult Eliminar(int id)
        {
            bool eliminado = _duenioLogica.EliminarDuenio(id);
            if (!eliminado)
                return NotFound();

            return NoContent();
        }
    }
}
