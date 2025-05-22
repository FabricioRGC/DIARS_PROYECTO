using DIARS_S8.Models;
using DIARS_S8.Repositories;

namespace DIARS_S8.Services
{
    public class FiltroPorCiudad : IFiltroClienteStrategy
    {
        private readonly IClienteRepository _clienteRepository;

        public FiltroPorCiudad(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task<IEnumerable<Cliente>> FiltrarClientes(string ciudad, int estado)
        {
            return await _clienteRepository.ObtenerPorCiudad(ciudad);
        }
    }
}