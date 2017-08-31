using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Table("Matricula")]
    public  class Matricula
    {
        public int MatriculaId { get; set; }
        public int AlumnoId { get; set; }
        public virtual  Alumno Alumno { get; set; }
        public int ApoderadoId { get; set; }
        public virtual  Apoderado Apoderado { get; set; }
        public int AnioAcademicoId { get; set; }
        public virtual AnioAcademico AnioAcademico { get; set; }
        public int SeccionId { get; set; }
        public virtual  Seccion Seccion { get; set; }
        public int ParentescoId { get; set; }
        public virtual  Parentesco Parentesco { get; set; }

    }
}
