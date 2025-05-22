using DIARS_S8.Models;

namespace DIARS_S8.Services
{
    public interface IFiltroClienteStrategy
    {
        Task<IEnumerable<Cliente>> FiltrarClientes(string ciudad, int estado);
    }
}
