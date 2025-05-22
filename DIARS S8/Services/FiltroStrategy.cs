using DIARS_S8.Models;

namespace DIARS_S8.Services
{
    public class FiltroStrategy
    {
        private IFiltroClienteStrategy _filtroCliente;

        public FiltroStrategy(IFiltroClienteStrategy filtroCliente)
        {
            _filtroCliente = filtroCliente;
        }

        public void establecerEstrategia(IFiltroClienteStrategy filtroCliente)
        {
            _filtroCliente = filtroCliente;
        }

        public Task<IEnumerable<Cliente>> FiltrarClientes(string ciudad, int estado)
        {
            return _filtroCliente.FiltrarClientes(ciudad, estado);
        }
    }
}