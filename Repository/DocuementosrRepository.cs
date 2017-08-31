using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using System.Data.Entity;

namespace Repository
{
    public class DocuementosrRepository : MasterRepository, IDocuementosrRepository
    {
        public void AddDocumento(Documentos documento)
        {
            Context.documentos.Add(documento);
            Context.SaveChanges();
        }

        public void EditarDocumento(Documentos documento)
        {
            Context.Entry(documento).State= EntityState.Modified;
            Context.SaveChanges();
        }

        public void EliminarDocumento(int idDocumento)
        {
            var doc = Context.documentos.Find(idDocumento);
            if (doc!=null)
            {
                Context.documentos.Remove(doc);
                Context.SaveChanges();
            }
        }

        public Documentos GetAlumnooById(int? idDocumento)
        {
            return Context.documentos.Find(idDocumento);
        }

        public IEnumerable<Documentos> GetDocumentos()
        {
            return Context.documentos;
        }

        public IEnumerable<Documentos> GetDocumentos(string criterio)
        {
            var query = from p in Context.documentos
                        select p;
            if (!string.IsNullOrEmpty(criterio))
            {
                query = from p in query
                        where p.Nombre.ToUpper().Contains(criterio.ToUpper()) 
                              
                        select p;
            }

            return query;
        }

        //public IEnumerable<Documentos> GetDocumentos(string criterio, int? idAlumno)
        //{
        //    var query = from p in Context.documentos
        //                select p;

        //    if (!string.IsNullOrEmpty(criterio))
        //    {
        //        query = from p in query
        //                where p.Nombre.ToUpper().Contains(criterio.ToUpper())

        //                select p;
        //    }

        //    if (idAlumno.HasValue)
        //    {
        //        query = query.Where(p => p.AlumnoId.Equals(idAlumno.Value));
        //    }

        //    return query;
        //}
    }
}
