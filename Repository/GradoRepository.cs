using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using System.Data.Entity;

namespace Repository
{
    public class GradoRepository : MasterRepository, IGradoRepository
    {
        public void AddGrado(Grado Grado)
        {
            Context.grados.Add(Grado);
            Context.SaveChanges();
        }

        public void EditarGrado(Grado Grado)
        {
            Context.Entry(Grado).State = EntityState.Modified;
            Context.SaveChanges();
        }

        public void EliminarGrado(int idGrado)
        {
            var gr = Context.grados.Find(idGrado);
            if (gr != null)
            {
                Context.grados.Remove(gr);
                Context.SaveChanges();
            }
        }

        public IEnumerable<Grado> GetGrado(string criterio)
        {
            var query = from p in Context.grados
                        select p;
            if (!string.IsNullOrEmpty(criterio))
            {
                query = from p in query
                        where p.Nombre.ToUpper().Contains(criterio.ToUpper()) 
                             
                        select p;
            }

            return query;
        }

        public IEnumerable<Grado> GetGrado(string criterio, int? idNivel)
        {
            var query = from p in Context.grados
                        select p;

            if (!string.IsNullOrEmpty(criterio))
            {
                query = from p in query
                        where p.Nombre.ToUpper().Contains(criterio.ToUpper())

                        select p;
            }

            if (idNivel.HasValue)
            {
                query = query.Where(p => p.NivelId.Equals(idNivel.Value));
            }

            return query;
        }

        public Grado GetGradoById(int? idGrado)
        {
            return Context.grados.Find(idGrado);
        }

        public IEnumerable<Grado> GetGrados()
        {
            return Context.grados;
        }
    }
}
