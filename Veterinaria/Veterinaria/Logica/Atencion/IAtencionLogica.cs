using Veterinaria.Datos.Dtos;

namespace Veterinaria.Logica.Atencion
{
    public interface IAtencionLogica
    {
        AtencionDto ObtenerAtencion(int id);
    }
}
