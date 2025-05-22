using Microsoft.EntityFrameworkCore;
namespace DIARS_S8.Data
{
    public sealed class ConexionBD
    {
        private static ConexionBD instancia = null!;
        private static readonly object candado = new();
        private AppDbContext _context;

        private ConexionBD(DbContextOptions<AppDbContext> options)
        {
            _context = new AppDbContext(options);
        }

        public static ConexionBD ObtenerInstancia(DbContextOptions<AppDbContext> options)
        {
            lock (candado)
            {
                if (instancia == null)
                {
                    instancia = new ConexionBD(options);
                }
            }
            return instancia;
        }

        public AppDbContext ObtenerContexto() => _context;
    }
}
