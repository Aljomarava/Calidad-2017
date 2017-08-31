using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Table("AnioAcademico")]
    public class AnioAcademico
    {
        [Key]
        public int AnioAcademicoId { get; set; }
        public bool Activo { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime FechaApertura { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime FechaClausura { get; set; }

        public List<Horario> Horarios { get; set; }
        public List<Matricula> Matricula { get; set; }
    }
}
