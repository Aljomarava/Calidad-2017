using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Examen.Domain;

namespace Examen.Service
{
    public interface IEvaluacionService
    {
        IEnumerable<Evaluacion> GetEvaluaciones(string criterio);
        IEnumerable<Evaluacion> GetEvaluaciones();
        Evaluacion GetEvaluacionById(Int32? idEvaluacion);

        void AddEvaluacion(Evaluacion evaluacion);
        void EditarEvaluacion(Evaluacion evaluacion);

        void EliminarEvaluacion(Int32 idEvaluacion);


    }
}
