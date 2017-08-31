using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Table("Curso")]
    public class Curso
    {
        [Key]
        public int CursoId { get; set; }
        [Required]
        [MaxLength(70)]
        public string Nombre { get; set; }

        public List<Notas> Notas { get; set; }
        public List< Docente> Docentes { get; set; }
        public List<Horario> Horarios { get; set; }
        public int GradoId { get; set; }
        public virtual Grado Grado { get; set; }
        public int SeccionId { get; set; }
        public virtual  Seccion Seccion { get; set; }
    }
}
