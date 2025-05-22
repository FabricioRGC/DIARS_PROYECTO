using DIARS_S8.Models;
using Microsoft.EntityFrameworkCore;
namespace DIARS_S8.Data
{
    public partial class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        { }
        public DbSet<Cliente> Clientes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente);
                entity.ToTable("Cliente");
                entity.Property(e => e.IdCliente).HasColumnName("idCliente");
                entity.Property(e => e.Ciudad).HasMaxLength(50);
                entity.Property(e => e.Direccion).HasMaxLength(50);
                entity.Property(e => e.EstCliente).HasColumnName("estCliente");
                entity.Property(e => e.IdTipoCliente).HasColumnName("idTipoCliente");
                entity.Property(e => e.RazonSocial).HasMaxLength(50);
            });
            OnModelCreatingPartial(modelBuilder); 
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
