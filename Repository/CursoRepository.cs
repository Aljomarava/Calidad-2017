using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using System.Data.Entity;

namespace Repository
{
    public class CursoRepository : MasterRepository, ICursoRepository
    {
        public void AddCurso(Curso curso)
        {
            Context.cursos.Add(curso);
            Context.SaveChanges();
        }

        public void EditarCurso(Curso curso)
        {

            Context.Entry(curso).State = EntityState.Modified;
            Context.SaveChanges();
        }

        public void EliminarCurso(int idCurso)
        {
            var curs = Context.cursos.Find(idCurso);
            if (curs != null)
            {
                Context.cursos.Remove(curs);
                Context.SaveChanges();
            }
        }

        public IEnumerable<Curso> GetCurso(string criterio)
        {
            var query = from p in Context.cursos
                        select p;

            if (!string.IsNullOrEmpty(criterio))
            {
                query = from p in query
                        where
                              p.Nombre.ToUpper().Contains(criterio.ToUpper())
                        select p;
            }
            return query;
        }

        public Curso GetCursoById(int? idCurso)
        {
            return Context.cursos.Find(idCurso);
        }

        public IEnumerable<Curso> GetCursos()
        {

            return Context.cursos;
        }
    }
}
