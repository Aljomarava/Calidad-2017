using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Table("Bimestre")]
    public class Bimestre
    {
        [Key]
        public int BimestreId { get; set; }
        [Required]
        [MaxLength(30)]
        public String Nombre { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = " Inicio")]
        public DateTime FechaInicio { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Finaliza")]
        public DateTime FechaFin { get; set; }
        public List<Notas> Notas { get; set; }
    }
}
