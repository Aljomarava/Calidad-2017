using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface ICursoRepository
    {
        IEnumerable<Curso> GetCurso(string criterio);
        IEnumerable<Curso> GetCursos();
        Curso GetCursoById(Int32? idCurso);

        void AddCurso(Curso curso);
        void EditarCurso(Curso curso);

        void EliminarCurso(Int32 idCurso);
    }
}
