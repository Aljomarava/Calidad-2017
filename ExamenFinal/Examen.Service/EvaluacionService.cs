using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Examen.Repository;
using Examen.Domain;


namespace Examen.Service
{
    public class EvaluacionService : IEvaluacionService
    {
        private IEvaluacionRepository _evaluacionRepository;

        public EvaluacionService()
        {
            //_evaluacionRepository = evaluacionRepository;
            if(_evaluacionRepository == null)
            {
                _evaluacionRepository = new EvaluacionRepository();
            }


        }
        public void AddEvaluacion(Evaluacion evaluacion)
        {
            _evaluacionRepository.AddEvaluacion(evaluacion);
        }

        public void EditarEvaluacion(Evaluacion evaluacion)
        {
            _evaluacionRepository.EditarEvaluacion(evaluacion);
        }

        public void EliminarEvaluacion(int idEvaluacion)
        {
            _evaluacionRepository.EliminarEvaluacion(idEvaluacion);
        }

        public Evaluacion GetEvaluacionById(int? idEvaluacion)
        {
            return _evaluacionRepository.GetEvaluacionById(idEvaluacion);
        }

        public IEnumerable<Evaluacion> GetEvaluaciones()
        {
            return _evaluacionRepository.GetEvaluaciones();
        }

        public IEnumerable<Evaluacion> GetEvaluaciones(string criterio)
        {
            return _evaluacionRepository.GetEvaluaciones(criterio);
        }

        
    }
}
