using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindowsEducacionIT.Models
{
    [Table("Estado")]
    public class Estado
    {
        [Key]
        public int IDEstado { get; set; }
        [Column(TypeName ="varchar")]
        [StringLength(20)]
        [Required]
        public string Nombre { get; set; }
        public List<Detalle> Detalles { get; set; }
    }
}
