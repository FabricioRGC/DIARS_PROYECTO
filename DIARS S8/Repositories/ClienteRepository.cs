using DIARS_S8.Data;
using DIARS_S8.Models;
using Microsoft.EntityFrameworkCore;

namespace DIARS_S8.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly AppDbContext _context;

        public ClienteRepository(AppDbContext context)
        {
            _context = context;
        }

        // SI USARAMOS EL SINGLETON MANUAL
        /*
        public ClienteRepository(IDbContextOptions<AppDbContext> options)
        {
            // En lugar de recibir AppDbContext directamente, recibimos las opciones
            var singleton = ConexionBD.ObtenerInstancia(options);
            _context = singleton.ObtenerContexto();
        }
        */

        // Obtener todos los clientes
        public async Task<IEnumerable<Cliente>> ObtenerTodos()
        {
            return await _context.Clientes.ToListAsync();
        }

        // Obtener clientes por estado
        public async Task<IEnumerable<Cliente>> ObtenerPorEstado(int estado)
        {
            return await _context.Clientes
                .Where(c => c.EstCliente == estado)
                .ToListAsync();
        }

        // Obtener clientes por ciudad
        public async Task<IEnumerable<Cliente>> ObtenerPorCiudad(string ciudad)
        {
            return await _context.Clientes
                .Where(c => c.Ciudad.Contains(ciudad))
                .ToListAsync();
        }

        // Obtener clientes por estado y ciudad
        public async Task<IEnumerable<Cliente>> ObtenerPorEstadoYCiudad(int estado, string ciudad)
        {
            return await _context.Clientes
                .Where(c => c.EstCliente == estado && c.Ciudad.Contains(ciudad))
                .ToListAsync();
        }
    }

}
