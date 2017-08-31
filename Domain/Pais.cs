using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Table("Pais")]
    public class Pais
    {
        [Key]
        public int PaisId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; }
        public List<Ubigeo> Ubigeos { get; set; }
    }
}
