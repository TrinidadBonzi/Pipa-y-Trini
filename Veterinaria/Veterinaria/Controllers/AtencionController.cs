using Microsoft.AspNetCore.Mvc;
using Veterinaria.Datos.Dtos;
using Veterinaria.Logica.Atencion;

namespace Veterinaria.Controllers
{
    [Route("atenciones")]
    [ApiController]
    public class AtencionController : ControllerBase
    {
        private readonly IAtencionLogica _atencionLogica;
        public AtencionController(IAtencionLogica atencionLogica)
        {
            _atencionLogica = atencionLogica;
        }

        [HttpGet("{id}")]
        public IActionResult ObtenerPorId(int id)
        {
            AtencionDto atencionDto = _atencionLogica.ObtenerAtencion(id);

            if (atencionDto == null)
            {
                return NotFound();
            }

            return Ok(atencionDto);
        }
        [HttpDelete("{id}")]
        public IActionResult Eliminar(int id)
        {
            bool eliminado = _atencionLogica.EliminarAtencion(id);
            if (!eliminado)
                return NotFound();

            return NoContent();
        }
        [HttpPost]
        public IActionResult AgregarAtencion([FromBody] AtencionDto nuevaAtencion)
        {
            if (nuevaAtencion == null)
            {
                return BadRequest("La atención no puede ser nula.");
            }
            bool agregado = _atencionLogica.AgregarAtencion(nuevaAtencion);
            if (!agregado)
            {
                return BadRequest("Error al agregar la atención.");
            }
            return CreatedAtAction(nameof(ObtenerPorId), new { id = nuevaAtencion.idAtencion }, nuevaAtencion);
        }
    }
}
