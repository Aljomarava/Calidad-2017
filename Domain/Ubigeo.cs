using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Table("Ubigeo")]
    public class Ubigeo
    {
        [Key]
        public int UbigeoId { get; set; }

        [Required]
        [MaxLength(80)]
        public String Codigo { get; set; }
        
                [Required]
                [MaxLength(80)]

                public String Departamento { get; set; }
                [Required]
                [MaxLength(80)]
                public String Provincia { get; set; }
                [Required]
                [MaxLength(80)]
                public String Distrito { get; set; }
        public int PaisId { get; set; }
        public virtual Pais Pais { get; set; }

        public List<Alumno> Alumnos { get; set; }
        public List<Apoderado> Apoderados { get; set; }
        public List<Docente> Docentes { get; set; }
    }
}
