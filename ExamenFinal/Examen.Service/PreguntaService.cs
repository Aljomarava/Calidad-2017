using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Examen.Domain;
using Examen.Repository;

namespace Examen.Service
{
    public class PreguntaService : IPreguntaService
    {

        private IPreguntaRepository _preguntaRepository;


        public PreguntaService()
        {
            if(_preguntaRepository == null)
            {
                _preguntaRepository = new PreguntaRepository();
            }
        }

        public void AddPregunta(Pregunta pregunta)
        {
            _preguntaRepository.AddPregunta(pregunta);
        }

        public void EditarPregunta(Pregunta pregunta)
        {
            _preguntaRepository.EditarPregunta(pregunta);
        }

        public void EliminarPregunta(int idPregunta)
        {
            _preguntaRepository.EliminarPregunta(idPregunta);
        }

        public Pregunta GetPreguntaById(int? idPregunta)
        {
            return _preguntaRepository.GetPreguntaById(idPregunta);
        }

        public IEnumerable<Pregunta> GetPreguntas()
        {
            return _preguntaRepository.GetPreguntas();
        }

        public IEnumerable<Pregunta> GetPreguntas(string criterio)
        {
            return _preguntaRepository.GetPreguntas(criterio);
        }
    }
}
