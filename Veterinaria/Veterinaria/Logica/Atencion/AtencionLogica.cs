using Veterinaria.Datos.Dtos;
using Veterinaria.Logica.Atencion;
using Veterinaria.Repositorio.Atencion;

namespace Veterinaria.Logica.Atencion
{
    public class AtencionLogica : IAtencionLogica
    {
        private readonly IAtencionRepositorio _atencionRepositorio;

        public AtencionLogica(IAtencionRepositorio atencionRepositorio)
        {
            _atencionRepositorio = atencionRepositorio;
        }
        public AtencionDto ObtenerAtencion(int id)
        {
            Datos.Entidades.Atencion atencion = _atencionRepositorio.ObtenerAtencion(id);

            if (atencion == null)
            {
                return null;
            }

            return new AtencionDto
            {
                idAtencion = atencion.idAtencion,
                fechaAtencion = atencion.fechaAtencion,
                motivoAtencion = atencion.motivoAtencion,
                tratamientoAtencion = atencion.tratamientoAtencion,
                medicamentoAtencion = atencion.medicamentoAtencion,
                fechaRegistroAtencion = atencion.fechaRegistroAtencion
            };
        }
    }
}
