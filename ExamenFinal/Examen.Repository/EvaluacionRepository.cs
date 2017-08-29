using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;
using Examen.Domain;

namespace Examen.Repository
{
    public class EvaluacionRepository : MasterRepository,IEvaluacionRepository
    {
        public void AddEvaluacion(Evaluacion evaluacion)
        {
            Context.Evaluaciones.Add(evaluacion);
            Context.SaveChanges();
        }
        
        public void EditarEvaluacion(Evaluacion evaluacion)
        {
            Context.Entry(evaluacion).State = EntityState.Modified;
            Context.SaveChanges();
        }

        public void EliminarEvaluacion(int idEvaluacion)
        {
            var evaluacion = Context.Evaluaciones.Find(idEvaluacion);

            if(evaluacion != null)
            {
                Context.Evaluaciones.Remove(evaluacion);
                Context.SaveChanges();
            }
        }

        public IEnumerable<Evaluacion> GetEvaluaciones()
        {
            return Context.Evaluaciones;
        }

        public IEnumerable<Evaluacion> GetEvaluaciones(string criterio)
        {
            var query = from p in Context.Evaluaciones
                        select p;

            if(!string.IsNullOrEmpty(criterio))
            {
                query = from p in query
                        where p.Descripcion.ToUpper().Contains(criterio.ToUpper()) 
                          //p.Descripccion.ToUpper().Contains(criterio.ToUpper())
                        select p;
            }
            return query;
        }

        public Evaluacion GetEvaluacionById(int? idEvaluacion)
        {
            return Context.Evaluaciones.Find(idEvaluacion);
        }

        
    }
}
