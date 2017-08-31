using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using System.Data.Entity;

namespace Repository
{
    public class ApoderadoRepository : MasterRepository, IApoderadoRepository
    {
        public void AddApoderado(Apoderado apoderado)
        {
            Context.apoderados.Add(apoderado);
            Context.SaveChanges();
        }

        public void EditarApoderado(Apoderado apoderado)
        {
            Context.Entry(apoderado).State = EntityState.Modified;
            Context.SaveChanges();
        }

        public void EliminarApoderado(int idApoderado)
        {
            var ap = Context.apoderados.Find(idApoderado);
            if (ap!= null)
            {
                Context.apoderados.Remove(ap);
                Context.SaveChanges();
            }
        }

        public Apoderado GetApoderadoById(int? idApoderado)
        {
            return Context.apoderados.Find(idApoderado);
        }

        public IEnumerable<Apoderado> GetApoderados(string criterio)
        {
            var query = from p in Context.apoderados
                        select p;
            if (!string.IsNullOrEmpty(criterio))
            {
                query = from p in query
                        where p.Apellidos.ToUpper().Contains(criterio.ToUpper()) ||
                              p.Dni.ToUpper().Contains(criterio.ToUpper())
                        select p;
            }

            return query;
        }

        public IEnumerable<Apoderado> GetApoderados()
        {
            return Context.apoderados;
        }

        public IEnumerable<Apoderado> GetApoderados(string criterio, int? idUbigeo)
        {
            var query = from p in Context.apoderados
                        select p;

            if (!string.IsNullOrEmpty(criterio))
            {
                query = from p in query
                        where p.Dni.ToUpper().Contains(criterio.ToUpper())

                        select p;
            }

            if (idUbigeo.HasValue)
            {
                query = query.Where(p => p.UbigeoId.Equals(idUbigeo.Value));
            }

            return query;
        }
    }
}
