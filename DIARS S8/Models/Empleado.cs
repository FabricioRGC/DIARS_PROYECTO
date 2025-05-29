using System;
using DIARS_S8.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DIARS_S8.Models
{
    [Table("Empleado")]
    public class Empleado
    {
        [Key]
        [Column("empleado_id")]
        public int EmpleadoId { get; set; }

        [Required]
        [Column("usuario_id")]
        public int UsuarioId { get; set; }

        [ForeignKey(nameof(UsuarioId))]
        public Usuario Usuario { get; set; }

        [Required]
        [Column("nombres")]
        [StringLength(100)]
        public string Nombres { get; set; }

        [Required]
        [Column("dni")]
        [StringLength(15)]
        public string Dni { get; set; }

        [Column("telefono")]
        [StringLength(20)]
        public string Telefono { get; set; }

        [Required]
        [Column("cargo")]
        [StringLength(50)]
        public string Cargo { get; set; }

        [Column("fecha_contrato")]
        public DateTime FechaContrato { get; set; }

        public ICollection<Contrato> Contratos { get; set; } = new List<Contrato>();
        public ICollection<PedidoInstalacion> PedidosInstalacion { get; set; } = new List<PedidoInstalacion>();
    }
}