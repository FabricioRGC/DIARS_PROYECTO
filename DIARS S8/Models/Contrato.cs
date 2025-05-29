using DIARS_S8.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DIARS_S8.Models
{
    [Table("Contrato")]
    public class Contrato
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("cliente_id")]
        public int ClienteId { get; set; }
        [ForeignKey(nameof(ClienteId))]
        public Cliente Cliente { get; set; }

        [Required]
        [Column("plan_id")]
        public int PlanId { get; set; }
        [ForeignKey(nameof(PlanId))]
        public PlanServicio PlanServicio { get; set; }

        [Required]
        [Column("empleado_id")]
        public int EmpleadoId { get; set; }
        [ForeignKey(nameof(EmpleadoId))]
        public Empleado Empleado { get; set; }

        [Column("fecha_contrato")]
        public DateTime FechaContrato { get; set; } = DateTime.Now;

        [Column("fecha_inicio")]
        public DateTime FechaInicio { get; set; }

        [Column("fecha_fin")]
        public DateTime FechaFin { get; set; }

        [Column("estado")]
        [StringLength(20)]
        public string Estado { get; set; } = "activo";

        public ICollection<ContratoEquipo> ContratoEquipos { get; set; } = new List<ContratoEquipo>();
    }
}
