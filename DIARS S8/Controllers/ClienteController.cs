using Microsoft.AspNetCore.Mvc;
using DIARS_S8.Repositories;
using DIARS_S8.Services;

namespace DIARS_S8.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IFiltroClienteStrategy _estrategia;
        private readonly IClienteRepository _clienteRepository;

        public ClienteController(IFiltroClienteStrategy estrategia, IClienteRepository clienteRepository)
        {
            _estrategia = estrategia;
            _clienteRepository = clienteRepository;
        }

        public async Task<IActionResult> Index(string tipoFiltro, string ciudad, int estado)
        {
            IFiltroClienteStrategy iestrategia = _estrategia;
            string estrategia = tipoFiltro;

            switch (estrategia)
            {
                case "Ciudad":
                    iestrategia = new FiltroPorCiudad(_clienteRepository);
                    break;
                case "Estado":
                    iestrategia = new FiltroPorEstado(_clienteRepository);
                    break;
            }

            FiltroStrategy filtroStrategy = new FiltroStrategy(iestrategia);

            var clientes = await filtroStrategy.FiltrarClientes(ciudad, estado);

            return View(clientes);
        }
    }
}
