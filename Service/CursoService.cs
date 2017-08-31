using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Repository;
namespace Service
{
    public class CursoService : ICursoService
    {
        private ICursoRepository _cursoRepository;
        public CursoService()
        {
            if (_cursoRepository==null)
            {
                _cursoRepository = new CursoRepository();
            }
        }
        public void AddCurso(Curso curso)
        {
            _cursoRepository.AddCurso(curso);
        }

        public void EditarCurso(Curso curso)
        {
            _cursoRepository.EditarCurso(curso);
        }

        public void EliminarCurso(int idCurso)
        {
            _cursoRepository.EliminarCurso(idCurso);
        }

        public IEnumerable<Curso> GetCurso(string criterio)
        {
           return _cursoRepository.GetCurso(criterio);
        }

        public Curso GetCursoById(int? idCurso)
        {
            return _cursoRepository.GetCursoById(idCurso);
        }

        public IEnumerable<Curso> GetCursos()
        {
            return _cursoRepository.GetCursos();
        }
    }
}
