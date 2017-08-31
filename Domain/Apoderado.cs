using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Table("Apoderado")]
    public class Apoderado
    {
        [Key]
        public int ApoderadoId { get; set; }
        [Required]
        [MaxLength(50)]
        public String Nombres { get; set; }
        [Required]
        [MaxLength(80)]
        public String Apellidos { get; set; }
        [Required]
        [MaxLength(8)]
        public string Dni { get; set; }
        public Boolean masculino { get; set; }
        public Boolean Femenino { get; set; }
        [Required]
        [MaxLength(9)]
        public String Celular { get; set; }
        [Required]
        [MaxLength(40)]
        public String Direccion { get; set; }
      
        //public List<Alumno> Alumnos{ get; set; }
       
        public int UbigeoId { get; set; }
        public virtual Ubigeo Ubigeo { get; set; }
        public List<Matricula> Matriculas { get; set; }
    }
}
