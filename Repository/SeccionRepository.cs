using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using System.Data.Entity;

namespace Repository
{
    public class SeccionRepository : MasterRepository, ISeccionRepository
    {
        public void AddSeccion(Seccion Seccion)
        {
            Context.secciones.Add(Seccion);
            Context.SaveChanges();
        }

        public void EditarSeccion(Seccion Seccion)
        {
            Context.Entry(Seccion).State = EntityState.Modified;
            Context.SaveChanges();
        }

        public void EliminarSeccion(int idSeccion)
        {
            var sec = Context.secciones.Find(idSeccion);
            if (sec != null)
            {
                Context.secciones.Remove(sec);
                Context.SaveChanges();
            }
        }

        public IEnumerable<Seccion> GetSeccion()
        {
            return Context.secciones;
        }

        public IEnumerable<Seccion> GetSeccion(string criterio)
        {
            var query = from p in Context.secciones
                        select p;
            if (!string.IsNullOrEmpty(criterio))
            {
                query = from p in query
                        where p.Nombre.ToUpper().Contains(criterio.ToUpper())

                        select p;
            }

            return query;
        }

        public IEnumerable<Seccion> GetSeccion(string criterio, int? idGrado, int? idNivel)
        {
            var query = from p in Context.secciones
                        select p;

            if (!string.IsNullOrEmpty(criterio))
            {
                query = from p in query
                        where p.Nombre.ToUpper().Contains(criterio.ToUpper())

                        select p;
            }

            if (idGrado.HasValue)
            {
                query = query.Where(p => p.GradoId.Equals(idGrado.Value));

            }
            if (idNivel.HasValue)
            {
                query = query.Where(p => p.Grado.Nivel.Equals(idNivel.Value));

            }

            return query;
        }

        public Seccion GetSeccionById(int? idSeccion)
        {
            return Context.secciones.Find(idSeccion);
        }
    }
}
