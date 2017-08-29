using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data.Entity;
using Examen.Domain;


namespace Examen.Repository 
{
    public class PreguntaRepository : MasterRepository, IPreguntaRepository
    {
        public void AddPregunta(Pregunta pregunta)
        {
            Context.Preguntas.Add(pregunta);
            Context.SaveChanges();
        }

        public void EditarPregunta(Pregunta pregunta)
        {
            Context.Entry(pregunta).State = EntityState.Modified;
            Context.SaveChanges();
        }

        public void EliminarPregunta(int idPregunta)
        {
            var pregunta = Context.Preguntas.Find(idPregunta);
            if (pregunta != null)
            {
                Context.Preguntas.Remove(pregunta);
                Context.SaveChanges();
            }
        }

        public Pregunta GetPreguntaById(int? idPregunta)
        {
            return Context.Preguntas.Find(idPregunta);
        }

        public IEnumerable<Pregunta> GetPreguntas()
        {
            return Context.Preguntas;
        }

        public IEnumerable<Pregunta> GetPreguntas(string criterio)
        {
            var query = from p in Context.Preguntas
                        select p;

            if(!string.IsNullOrEmpty(criterio))
            {
                query = from p in query
                        where p.Texto.ToUpper().Contains(criterio.ToUpper())
                        select p;
            }
            return query;
        }
    }
}
