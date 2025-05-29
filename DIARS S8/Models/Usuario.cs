using DIARS_S8.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DIARS_S8.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("correo")]
        [StringLength(100)]
        public string Correo { get; set; }

        [Required]
        [Column("contrasena")]
        [StringLength(255)]
        public string Contrasena { get; set; }

        [Required]
        [Column("tipo_usuario")]
        [StringLength(20)]
        public string TipoUsuario { get; set; }

        [Column("activo")]
        public bool Activo { get; set; } = true;

        [Column("fecha_creacion")]
        public DateTime FechaCreacion { get; set; } = DateTime.Now;

        public Cliente Cliente { get; set; }
        public Empleado Empleado { get; set; }
    }
}
