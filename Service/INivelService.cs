using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface INivelService
    {
        IEnumerable<Nivel> GetNiveles(string criterio);
        IEnumerable<Nivel> GetNiveles();
        Nivel GetNivelById(Int32? idNivel);

        void AddNivel(Nivel nivel);
        void EditarNivel(Nivel nivel);

        void EliminarNivel(Int32 idNivel);
    }
}
