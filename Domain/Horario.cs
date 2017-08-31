using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Table("Horario")]
    public class Horario
    {
        [Key]
        public int HorarioId { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }
        [Required]
        [DataType(DataType.Time)]
        public DateTime HoraInicio { get; set; }
        [Required]
        [DataType(DataType.Time)]
        public DateTime Horafin { get; set; }
        public int CursoId { get; set; }
        public virtual Curso curso { get; set; }
        public int AnioAcademicoId { get; set; }
        public virtual  AnioAcademico AnioAcademico { get; set; }

    }
}
