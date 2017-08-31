using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Table("Docente")]
    public class Docente
    {
    
        [Key]
        public int DocenteId { get; set; }
        [Required]
        [MaxLength(50)]
        public String Nombres { get; set; }
        [Required]
        [MaxLength(80)]
        public String Apellidos { get; set; }
        [Required]
        [MaxLength(8)]
        public String correo { get; set; }
        public Boolean masculino { get; set; }
        public Boolean Femenino { get; set; }
        [Required]
        [MaxLength(9)]
        public String Celular { get; set; }
        [Required]
        [MaxLength(40)]
        public String Direccion { get; set; }

        public int EspecialidadId { get; set; }
        public virtual Especialidad Especialidad { get; set; }
        public int CursoId { get; set; }
        public virtual Curso Curso { get; set; }
        public int UbigeoId { get; set; }
        public virtual Ubigeo Ubigeo { get; set; }

    }
}
