using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using System.Data.Entity;

namespace Repository
{
    public class BimestreRepository : MasterRepository, IBimestreRepository
    {
        public void AddBimestre(Bimestre Bimestre)
        {
            Context.bimestres.Add(Bimestre);
            Context.SaveChanges();
        }

        public void EditarBimestre(Bimestre Bimestre)
        {
            Context.Entry(Bimestre).State = EntityState.Modified;
            Context.SaveChanges();
        }

        public void EliminarBimestre(int idBimestre)
        {
            var bi = Context.bimestres.Find(idBimestre);
            if (bi != null)
            {
                Context.bimestres.Remove(bi);
                Context.SaveChanges();
            }
        }

        public Bimestre GetBimestreById(int? idBimestre)
        {
            return Context.bimestres.Find(idBimestre);
        }

        public IEnumerable<Bimestre> GetBimestres()
        {
            return Context.bimestres;
        }

        public IEnumerable<Bimestre> GetBimestres(string criterio)
        {
            var query = from p in Context.bimestres
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
