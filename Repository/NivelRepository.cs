using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using System.Data.Entity;

namespace Repository
{
    public class NivelRepository : MasterRepository, INivelRepository
    {
        public void AddNivel(Nivel nivel)
        {
            Context.niveles.Add(nivel);
            Context.SaveChanges();
        }

        public void EditarNivel(Nivel nivel)
        {
            Context.Entry(nivel).State = EntityState.Modified;
            Context.SaveChanges();
        }

        public void EliminarNivel(int idNivel)
        {
            var ni = Context.niveles.Find(idNivel);
            if (ni != null)
            {
                Context.niveles.Remove(ni);
                Context.SaveChanges();
            }
        }

        public Nivel GetNivelById(int? idNivel)
        {
            return Context.niveles.Find(idNivel);
        }

        public IEnumerable<Nivel> GetNiveles()
        {
            return Context.niveles;
        }

        public IEnumerable<Nivel> GetNiveles(string criterio)
        {

            var query = from p in Context.niveles
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
    }
}
