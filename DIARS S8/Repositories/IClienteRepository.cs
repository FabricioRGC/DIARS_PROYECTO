using DIARS_S8.Models;

namespace DIARS_S8.Repositories
{
    public interface IClienteRepository
    {
        Task<IEnumerable<Cliente>> ObtenerTodos();
        Task<IEnumerable<Cliente>> ObtenerPorEstado(int estado);
        Task<IEnumerable<Cliente>> ObtenerPorCiudad(string ciudad);
    }
}
