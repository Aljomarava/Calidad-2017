using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using System.Data.Entity;

namespace Repository
{
    public class ParentescoRepository : MasterRepository, IParentescoRepository
    {
        public void AddParentesco(Parentesco parentesco)
        {
            Context.parentesco.Add(parentesco);
            Context.SaveChanges();
        }

        public void EditarParentescos(Parentesco parentesco)
        {
            Context.Entry(parentesco).State = EntityState.Modified;
            Context.SaveChanges();
        }

        public void EliminarParentesco(int idParentesco)
        {
            var pa = Context.parentesco.Find(idParentesco);
            if (pa != null)
            {
                Context.parentesco.Remove(pa);
                Context.SaveChanges();
            }
        }

        public Parentesco GetParentescoById(int? idParentesco)
        {
            return Context.parentesco.Find(idParentesco);
        }

        public IEnumerable<Parentesco> GetParentescos()
        {
            return Context.parentesco;
        }

        public IEnumerable<Parentesco> GetParentescos(string criterio)
        {
            var query = from p in Context.parentesco
                        select p;

            if (!string.IsNullOrEmpty(criterio))
            {
                query = from p in query
                        where
                              p.tipo.ToUpper().Contains(criterio.ToUpper())
                        select p;
            }

            return query;
        }
    }
}
