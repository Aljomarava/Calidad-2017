using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using System.Data.Entity;

namespace Repository
{
    public class UbigeoRepository : MasterRepository, IUbigeoRepository
    {
        public void AddUbigeo(Ubigeo ubigeo)
        {
            Context.ubigeos.Add(ubigeo);
            Context.SaveChanges();
        }

        public void EditarUbigeo(Ubigeo ubigeo)
        {
            Context.Entry(ubigeo).State = EntityState.Modified;
            Context.SaveChanges();
        }

        public void EliminarUbigeo(int idUbigeo)
        {
            var ub = Context.ubigeos.Find(idUbigeo);
            if (ub != null)
            {
                Context.ubigeos.Remove(ub);
                Context.SaveChanges();
            }
        }

        public Ubigeo GetUbigeoByCodigo(string codigo)
        {
            return Context.ubigeos.SingleOrDefault(x => x.Codigo.Equals(codigo));
        }

        public Ubigeo GetUbigeoById(int? idUbigeo)
        {
            return Context.ubigeos.Find(idUbigeo);
        }

        public IEnumerable<Ubigeo> GetUbigeos()
        {
            return Context.ubigeos;
        }

        public IEnumerable<Ubigeo> GetUbigeos(string criterio)
        {
            var query = from p in Context.ubigeos
                        select p;
            if (!string.IsNullOrEmpty(criterio))
            {
                query = from p in query
                        where p.Codigo.ToUpper().Contains(criterio.ToUpper()) ||
                              p.Departamento.ToUpper().Contains(criterio.ToUpper())
                        select p;
            }

            return query;
        }

        public IEnumerable<Ubigeo> GetUbigeos(string criterio, int? idPais)
        {
            var query = from p in Context.ubigeos
                        select p;

            if (!string.IsNullOrEmpty(criterio))
            {
                query = from p in query
                        where p.Codigo.ToUpper().Contains(criterio.ToUpper()) 
                             
                        select p;
            }

            if (idPais.HasValue)
            {
                query = query.Where(p => p.PaisId.Equals(idPais.Value));
            }

            return query;
        }
    }
}
