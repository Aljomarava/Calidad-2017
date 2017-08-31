using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Table("Notas")]
    public class Notas
    {
        [Key]
        public int NotasId { get; set; }
        public int BimestreId { get; set; }
        public virtual  Bimestre Bimestre { get; set; }
        public int AlumnoId { get; set; }
        public virtual  Alumno Alumnos { get; set; }
        public int CursoId { get; set; }
        public virtual  Curso Cursos { get; set; }
        public int Nota { get; set; }
        public DateTime fecha { get; set; }
    }
}
