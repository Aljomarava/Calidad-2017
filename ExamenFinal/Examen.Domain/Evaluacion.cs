using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Domain
{
    public class Evaluacion
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string Descripcion { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }

        public virtual List<Pregunta> Preguntas { get; set; }

    }
}
