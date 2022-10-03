using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Farmacias.Models
{
  
        [Table("farmaceutico")]
        public class farmaceutico
        {
            [Key]
            public int ci { get; set; }
            [Required]
            public string usuario { get; set; }
            [Required]
            public string nombreFarm { get; set; }
            [Required]
            public string apellidoFarm { get; set; }
            [Required]
            public string contrasena { get; set; }
            [Required]

            public string cargo { get; set; }

           // public virtual Estudiante estudiante { get; set; }
        }
    
}
