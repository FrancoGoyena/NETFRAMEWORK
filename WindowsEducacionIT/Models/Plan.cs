using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindowsEducacionIT.Models
{
    [Table("Plan")]
    public class Plan
    {
        [Key]
        public int IDPlan { get; set; }

        public int IDCarrera { get; set; }
        [ForeignKey("IDCarrera")]
        public Carrera Carrera { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]
        public string Nombre { get; set; }

    }
}
