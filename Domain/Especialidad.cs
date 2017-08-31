using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Table("Especialidad")]
    public  class Especialidad
    {
        [Key]
        public int EspecialidadId { get; set; }
        [Required]
        [MaxLength(50)]
        public String Nombre { get; set; }
        public List<Docente> Docentes { get; set; }
    }
}
