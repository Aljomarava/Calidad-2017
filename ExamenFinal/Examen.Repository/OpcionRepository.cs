using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen.Domain;
using System.Data.Entity;

namespace Examen.Repository
{
    public class OpcionRepository : MasterRepository, IOpcionRepository
    {
        public void AddOpcion(Opcion opcion)
        {
            Context.Opciones.Add(opcion);
            Context.SaveChanges();
        }

        public void EditarOpcion(Opcion opcion)
        {
            Context.Entry(opcion).State = EntityState.Modified;
            Context.SaveChanges();
        }

        public void EliminarOpcion(int idOpcion)
        {
            var opcion = Context.Opciones.Find(idOpcion);

            if (opcion != null)
            {
                Context.Opciones.Remove(opcion);
                Context.SaveChanges(); 
            }
        }

        public Opcion GetOpcionById(int? idOpcion)
        {
            return Context.Opciones.Find(idOpcion);
        }

        public IEnumerable<Opcion> GetOpciones()
        {
            return Context.Opciones;
        }

        public IEnumerable<Opcion> GetOpciones(string criterio)
        {
            var query = from p in Context.Opciones
                        select p;

            if (!string.IsNullOrEmpty(criterio))
            {
                query = from p in query
                        where p.Texto.ToUpper().Contains(criterio.ToUpper())
                        select p;
            }

            return query;
        }
    }
}
