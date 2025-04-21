namespace Veterinaria.Repositorio.Duenio
{
    public interface IDuenioRepositorio
    {
        Datos.Entidades.Duenio ObtenerDuenio(int idDuenio);
        void Eliminar(Datos.Entidades.Duenio duenio);
    }
}
