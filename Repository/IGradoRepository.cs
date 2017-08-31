using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
   public interface IGradoRepository
    {
        IEnumerable<Grado> GetGrado(string criterio, Int32? idNivel);
        IEnumerable<Grado> GetGrado(string criterio);
        IEnumerable<Grado> GetGrados();
        Grado GetGradoById(Int32? idGrado);

        void AddGrado(Grado Grado);
        void EditarGrado(Grado Grado);

        void EliminarGrado(Int32 idGrado);
    }
}
