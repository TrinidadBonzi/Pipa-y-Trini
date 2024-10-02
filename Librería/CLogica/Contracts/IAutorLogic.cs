using CEntidades.Entidades;

namespace CLogica.Contracts
{
    public interface IAutorLogic
    {
        List<dynamic> ObtenerAutoresParaListado();
        List<Autor> ObtenerAutores();

        void AltaAutor(string nombre, string apellido, string nacionalidad, string email, string telefono, string biografia);

        void ActualizarAutor(string documento, Autor autorActualizar);

        void EliminarAutor(string documento);


    }
}
