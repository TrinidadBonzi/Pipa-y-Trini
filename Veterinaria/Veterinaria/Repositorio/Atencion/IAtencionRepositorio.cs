namespace Veterinaria.Repositorio.Atencion
{
    public interface IAtencionRepositorio
    {
        Datos.Entidades.Atencion ObtenerAtencion(int idAtencion);
        void Eliminar(Datos.Entidades.Atencion atencion);
    }
}
