using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Table("Parentesco")]
    public  class Parentesco
    {
        [Key]
        public int ParentescoId { get; set; }
        [Required]
        [MaxLength(50)]
        [Display(Name = "Tipo")]
        public String tipo { get; set; }

        public List<Matricula> Matriculas { get; set; }
    }
}
