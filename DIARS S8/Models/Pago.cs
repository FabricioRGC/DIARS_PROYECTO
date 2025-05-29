using DIARS_S8.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DIARS_S8.Models
{
    [Table("Pago")]
    public class Pago
    {
        [Key]
        [Column("pago_id")]
        public int PagoId { get; set; }

        [Required]
        [Column("contrato_id")]
        public int ContratoId { get; set; }
        [ForeignKey(nameof(ContratoId))]
        public Contrato Contrato { get; set; }

        [Column("fecha_pago_estimada")]
        public DateTime FechaPagoEstimada { get; set; }

        [Required]
        [Column("monto")]
        public decimal Monto { get; set; }

        [Column("estado_pago")]
        [StringLength(20)]
        public string EstadoPago { get; set; } = "pendiente";

        [Column("fecha_pago_real")]
        public DateTime? FechaPagoReal { get; set; }

        [Column("metodo_pago")]
        [StringLength(50)]
        public string MetodoPago { get; set; }
    }
}
