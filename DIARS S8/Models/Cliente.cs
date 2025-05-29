using System;
using DIARS_S8.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DIARS_S8.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Key]
        public int ClienteId { get; set; }

        [Required, StringLength(100)]
        public string Nombres { get; set; }

        [Required, StringLength(15)]
        public string Dni { get; set; }

        [StringLength(255)]
        public string Direccion { get; set; }

        [Required, EmailAddress, StringLength(255)]
        public string Correo { get; set; }

        [StringLength(20)]
        public string Telefono { get; set; }

        [Required, StringLength(16)]
        public string Password { get; set; }

        public DateTime FechaRegistro { get; set; } = DateTime.Now;
    }
}