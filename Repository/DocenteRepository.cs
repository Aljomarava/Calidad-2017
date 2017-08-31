using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using System.Data.Entity;

namespace Repository
{
    public class DocenteRepository : MasterRepository, IDocenteRepository
    {
        public void AddDocente(Docente docente)
        {

            Context.docentes.Add(docente);
            Context.SaveChanges();
        }

        public void EditarDocente(Docente docente)
        {
            Context.Entry(docente).State = EntityState.Modified;
            Context.SaveChanges();
        }

        public void EliminarDocente(int idDocente)
        {
            var doc = Context.docentes.Find(idDocente);
            if (doc != null)
            {
                Context.docentes.Remove(doc);
                Context.SaveChanges();
            }
        }

        public Docente GetDocenteById(int? idDocente)
        {
            return Context.docentes.Find(idDocente);
        }

        public IEnumerable<Docente> GetDocentes()
        {
            return Context.docentes;
        }

        public IEnumerable<Docente> GetDocentes(string criterio)
        {
            var query = from p in Context.docentes
                        select p;
            if (!string.IsNullOrEmpty(criterio))
            {
                query = from p in query
                        where p.Apellidos.ToUpper().Contains(criterio.ToUpper())||
                        p.Nombres.ToUpper().Contains(criterio.ToUpper())

                        select p;
            }

            return query;
        }

    //    public IEnumerable<Docente> GetDocentes(string criterio, int? idUbigeo, int? idGurso)
    //    {
    //        var query = from p in Context.docentes
    //                    select p;

    //        if (!string.IsNullOrEmpty(criterio))
    //        {
    //            query = from p in query
    //                    where p.Apellidos.ToUpper().Contains(criterio.ToUpper())||
    //                   p.Nombres.ToUpper().Contains(criterio.ToUpper())

    //                    select p;
    //        }

    //        if (idUbigeo.HasValue)
    //        {
    //            query = query.Where(p => p.UbigeoId.Equals(idUbigeo.Value));
    //        }
    //        if (idGurso.HasValue)
    //        {
    //            query = query.Where(p => p.CursoId.Equals(idGurso.Value));
    //        }

    //        return query;
    //    }
    }
}
