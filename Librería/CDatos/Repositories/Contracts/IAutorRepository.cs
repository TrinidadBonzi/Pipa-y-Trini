

using CEntidades.Entidades;

namespace CDatos.Repositories.Contracts
{
    public interface IAutorRepository : IRepository<Autor>
    {
        void CreateAutor(Autor autor);

        List<Autor> ObtenerAutores();
    }
}
