using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Examen.Domain;

namespace Examen.Repository
{
    public interface IPreguntaRepository
    {
        IEnumerable<Pregunta> GetPreguntas(string criterio);
        IEnumerable<Pregunta> GetPreguntas();

        Pregunta GetPreguntaById(Int32? idPregunta);
        void AddPregunta(Pregunta pregunta);
        void EditarPregunta(Pregunta pregunta);

        void EliminarPregunta(Int32 idPregunta);
    }
}
