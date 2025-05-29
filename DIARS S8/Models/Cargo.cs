using DIARS_S8.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DIARS_S8.Models
{
    [Table("Cargo")]
    public class Usuario
    {
        public class Cargo
        {
            [Key]
            public int CargoId { get; set; }

            [Required, StringLength(100)]
            public string TituloCargo { get; set; }
        }
    }
}

