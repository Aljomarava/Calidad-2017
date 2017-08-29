using Examen.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Examen.Service
{
   public interface IOpcionService
    {
        IEnumerable<Opcion> GetOpciones(string criterio);
        IEnumerable<Opcion> GetOpciones();

        Opcion GetOpcionById(Int32? idOpcion);
        void AddOpcion(Opcion opcion);
        void EditarOpcion(Opcion opcion);

        void EliminarOpcion(Int32 idOpcion);


    }
}
