using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using System.Data.Entity;

namespace Repository
{
    public class PaisRepository : MasterRepository, IPaisRepository
    {
        public void AddPais(Pais pais)
        {
            Context.paises.Add(pais);
            Context.SaveChanges();
        }

        public void EditarPais(Pais pais)
        {
            Context.Entry(pais).State = EntityState.Modified;
            Context.SaveChanges();
        }

        public void EliminarPais(int idPais)
        {
            var ps = Context.paises.Find(idPais);
            if (ps != null)
            {
                Context.paises.Remove(ps);
                Context.SaveChanges();
            }
        }

        public Pais GetPaisById(int? idPais)
        {
            return Context.paises.Find(idPais);
        }

        public IEnumerable<Pais> GetPaises()
        {
            return Context.paises;
        }

        public IEnumerable<Pais> GetPaises(string criterio)
        {
            var query = from p in Context.paises
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
