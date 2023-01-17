using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindowsEducacionIT.Models
{
    [Table("Curso")]
    public class Curso
    {
        [Key]
        public int IDCurso { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]
        public string Nombre { get; set; }

        public List<Planilla> Planillas { get; set; }

    }
}
