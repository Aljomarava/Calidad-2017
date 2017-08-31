using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Table("Documentos")]
    public class Documentos
    {
        [Key]
        public int DocumentosId { get; set; }
        [Required]
        [MaxLength(50)]
        public String Nombre{ get; set; }
       
        public List<EntregaDocuentos> EntregarDocumentos { get; set; }
    }
}
