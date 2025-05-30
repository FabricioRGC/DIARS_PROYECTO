﻿using DIARS_S8.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DIARS_S8.Models
{
    [Table("PedidoInstalacion")]
    public class PedidoInstalacion
    {
        [Key]
        [Column("pedido_id")]
        public int PedidoId { get; set; }

        [Required]
        [Column("contrato_id")]
        public int ContratoId { get; set; }
        [ForeignKey(nameof(ContratoId))]
        public Contrato Contrato { get; set; }

        [Required]
        [Column("empleado_id")]
        public int EmpleadoId { get; set; }
        [ForeignKey(nameof(EmpleadoId))]
        public Empleado Empleado { get; set; }

        [Column("fecha_instalacion")]
        public DateTime? FechaInstalacion { get; set; }

        [Column("estado_instalacion")]
        [StringLength(20)]
        public string EstadoInstalacion { get; set; } = "pendiente";

        [Column("observaciones")]
        [StringLength(255)]
        public string Observaciones { get; set; }
    }
}
}
