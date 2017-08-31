using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using System.Data.Entity;

namespace Repository
{
    public class EspecialidadRepository : MasterRepository, IEspecialidadRepository
    {
        public void AddEspecialidad(Especialidad especialidad)
        {
            Context.Especialidades.Add(especialidad);
            Context.SaveChanges();
        }

        public void EditarEspecialidad(Especialidad especialidad)
        {
            Context.Entry(especialidad).State = EntityState.Modified;
            Context.SaveChanges();
        }

        public void EliminarEspecialidad(int idEspecialidad)
        {
            var es = Context.Especialidades.Find(idEspecialidad);
            if (es != null)
            {
                Context.Especialidades.Remove(es);
                Context.SaveChanges();
            }
        }

        public Especialidad GetEspecialidadById(int? idEspecialidad)
        {
            return Context.Especialidades.Find(idEspecialidad);
        }

        public IEnumerable<Especialidad> GetEspecialidades()
        {
            return Context.Especialidades;
        }

        public IEnumerable<Especialidad> GetEspecialidades(string criterio)
        {
            var query = from p in Context.Especialidades
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
