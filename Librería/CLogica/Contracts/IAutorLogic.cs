using CEntidades.Entidades;

namespace CLogica.Contracts
{
    public interface IAutorLogic
    {
        List<dynamic> ObtenerAutoresParaListado();
        List<Autor> ObtenerAutores();

        void AltaAutor(string nombre, string apellido, string nacionalidad, string email, string telefono, string biografia);

        void ActualizarAutor(int id, string nombre, string apellido, string nacionalidad, string email, string telefono, string biografia);

        void EliminarAutor(string id);


    }
}
