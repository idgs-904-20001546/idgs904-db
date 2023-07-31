using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IDGS904_BD.Models
{
    public class Alumno
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]

        public string Name { get; set; }
        [Required]
        [StringLength(100)]
        public string Lastname { get; set; }
        [StringLength(50)]

        public string Run { get; set; }
    }
}