using DIARS_S8.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static DIARS_S8.Models.Usuario;

namespace DIARS_S8.Models
{
    [Table("Empleado")]
    public class Empleado
    {
        [Key]
        public int EmpleadoId { get; set; }

        [ForeignKey("Cargo")]
        public int CargoId { get; set; }
        public Cargo Cargo { get; set; }

        [Required, StringLength(100)]
        public string Nombres { get; set; }

        [Required, StringLength(15)]
        public string Dni { get; set; }

        [StringLength(20)]
        public string Telefono { get; set; }

        [StringLength(20)]
        public string Correo { get; set; }

        [Required, StringLength(50)]
        public string CargoNombre { get; set; } // Nombre del cargo (redundante)

        [Required, StringLength(16)]
        public string Password { get; set; }

        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
    }
}