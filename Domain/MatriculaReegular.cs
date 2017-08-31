using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
   public class MatriculaReegular: Matricula
    {
        public int RegularId { get; set; }

        public int CursoId { get; set; }
        public virtual  Curso curso { get; set; }
        public int NotasId { get; set; }
        public virtual  Notas nota { get; set; }

    }
}
