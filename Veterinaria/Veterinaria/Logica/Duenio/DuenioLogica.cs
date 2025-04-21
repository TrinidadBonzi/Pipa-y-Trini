using Veterinaria.Datos.Dtos;
using Veterinaria.Logica.Duenio;
using Veterinaria.Repositorio.Duenio;

namespace Veterinaria.Logica.Duenio
{
    public class DuenioLogica : IDuenioLogica
    {
        private readonly IDuenioRepositorio _duenioRepositorio;

        public DuenioLogica(IDuenioRepositorio duenioRepositorio)
        {
            _duenioRepositorio = duenioRepositorio;
        }
        public DuenioDto ObtenerDuenio(int id)
        {
            Datos.Entidades.Duenio duenio = _duenioRepositorio.ObtenerDuenio(id);

            if (duenio == null)
            {
                return null;
            }

            return new DuenioDto
            {
                idDuenio = duenio.idDuenio,
                dniDuenio = duenio.dniDuenio,
                nombreDuenio = duenio.nombreDuenio,
                apellidoDuenio = duenio.apellidoDuenio,
            };
        }
        public bool EliminarDuenio(int id)
        {
            var duenio = _duenioRepositorio.ObtenerDuenio(id);
            if (duenio == null) return false;

            _duenioRepositorio.Eliminar(duenio);
            return true;
        }
    }
}
