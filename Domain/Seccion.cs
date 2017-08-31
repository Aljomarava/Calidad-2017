using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Table("Seccion")]
    public class Seccion
    {
        [Key]
        public int SeccionId { get; set; }
        [Required]
        [MaxLength(50)]
        public String Nombre { get; set; }
        public int Capacidad { get; set; }
        public int GradoId { get; set; }
        public virtual Grado Grado { get; set; }
        public List<Curso> Cursos { get; set; }
        public List<Matricula> Matriculas { get; set; }
    }
}
