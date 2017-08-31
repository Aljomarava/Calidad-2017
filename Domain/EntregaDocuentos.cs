using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Table("EntregaDocuentos")]
    public class EntregaDocuentos
    {
        public int EntregaDocuentosId { get; set; }
        public int DocumentosId { get; set; }
        public Documentos Documento { get; set; }
        public int AlumnoId { get; set; }
        public virtual Alumno Alumns { get; set; }
        public Boolean Entregado { get; set; }
    }
}
