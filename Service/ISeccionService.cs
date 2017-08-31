using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface ISeccionService
    {
        IEnumerable<Seccion> GetSeccion(string criterio, Int32? idGrado, Int32? idNivel);
        IEnumerable<Seccion> GetSeccion(string criterio);
        IEnumerable<Seccion> GetSeccion();
        Seccion GetSeccionById(Int32? idSeccion);

        void AddSeccion(Seccion Seccion);
        void EditarSeccion(Seccion Seccion);

        void EliminarSeccion(Int32 idSeccion);
    }
}
