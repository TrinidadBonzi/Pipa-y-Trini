using Veterinaria.Datos.Dtos;

namespace Veterinaria.Logica.Duenio
{
    public interface IDuenioLogica
    {
        DuenioDto ObtenerDuenio(int id);
        bool EliminarDuenio(int id);
        bool AgregarDuenio(DuenioDto nuevoDuenio);
    }
}
