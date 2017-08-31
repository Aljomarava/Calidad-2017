using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Table("Grado")]
    public class Grado
    {
        [Key]
        public int GradoId { get; set; }
        [Required]
        [MaxLength(50)]
        public String Nombre { get; set; }
        public int NivelId { get; set; }
        public virtual Nivel Nivel { get; set; }
        public List<Seccion> Secciones { get; set; }
        public List<Curso> cursos { get; set; }

    }
}
