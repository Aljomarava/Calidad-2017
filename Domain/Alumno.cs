using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Table("Alumnos")]
    public class Alumno
    {
       
        [Key]
        public int AlumnoId { get; set; }
        [Required]
        [MaxLength(50)]
        public String Nombres { get; set; }
        [Required]
        [MaxLength(80)]
        public String Apellidos { get; set; }
        [Required]
        [MaxLength(8)]
        public string Dni { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha Nacimiento")]
        public DateTime FechaNacimiento { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Correo { get; set; }
        public string  Genero { get; set; }
        [Required]
        [MaxLength(9)]
        public String Celular { get; set; }
        [Required]
        [MaxLength(40)]
        public String Direccion { get; set; }
        public Boolean Estado { get; set; }

        //public int ApoderadoId { get; set; }
        //public virtual Apoderado Apoderados { get; set; }

        public int UbigeoId { get; set; }
        public virtual Ubigeo Ubigeo { get; set; }
        public List<EntregaDocuentos> EntregarDocumentos { get; set; }
        public List<Notas> Notas { get; set; }

        public List<Matricula> Matriculas { get; set; }
    }
}
