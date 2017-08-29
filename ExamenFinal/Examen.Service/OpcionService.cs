using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Examen.Domain;
using Examen.Repository;

namespace Examen.Service
{
    public class OpcionService : IOpcionService
    {
        private IOpcionRepository _opcionRepository;

        public OpcionService()
        {
           if(_opcionRepository == null)
            {
                _opcionRepository = new OpcionRepository();
            }
        }

        public void AddOpcion(Opcion opcion)
        {
            _opcionRepository.AddOpcion(opcion);
        }

        public void EditarOpcion(Opcion opcion)
        {
            _opcionRepository.EditarOpcion(opcion);
        }

        public void EliminarOpcion(int idOpcion)
        {
            _opcionRepository.EliminarOpcion(idOpcion);
        }

        public Opcion GetOpcionById(int? idOpcion)
        {
            return _opcionRepository.GetOpcionById(idOpcion);
        }

        public IEnumerable<Opcion> GetOpciones()
        {
            return _opcionRepository.GetOpciones();
        }

        public IEnumerable<Opcion> GetOpciones(string criterio)
        {
            return _opcionRepository.GetOpciones(criterio);
        }
    }
}
