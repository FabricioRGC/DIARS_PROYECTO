using DIARS_S8.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DIARS_S8.Models
{
    [Table("Equipo")]
    public class Equipo
    {
        [Key]
        [Column("equipo_id")]
        public int EquipoId { get; set; }

        [Required]
        [Column("nombre_equipo")]
        [StringLength(100)]
        public string NombreEquipo { get; set; }

        [Column("descripcion")]
        [StringLength(255)]
        public string Descripcion { get; set; }

        [Column("cantidad_stock")]
        public int CantidadStock { get; set; }

        [Column("estado")]
        [StringLength(20)]
        public string Estado { get; set; } = "activo";

        // Iníciala para que nunca sea null  
        public ICollection<ContratoEquipo> ContratoEquipos { get; set; }
            = new List<ContratoEquipo>();
    }
}
