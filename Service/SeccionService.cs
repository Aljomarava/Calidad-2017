using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Repository;
namespace Service
{
    public class SeccionService : ISeccionService
    {
        private ISeccionRepository _seccionRepository;
        public SeccionService()
        {
            if(_seccionRepository==null)
            {
                _seccionRepository = new SeccionRepository();
            }
        }
                
        public void AddSeccion(Seccion Seccion)
        {
            _seccionRepository.AddSeccion(Seccion);
        }

        public void EditarSeccion(Seccion Seccion)
        {
            _seccionRepository.EditarSeccion(Seccion);
        }

        public void EliminarSeccion(int idSeccion)
        {
            _seccionRepository.EliminarSeccion(idSeccion);
        }

        public IEnumerable<Seccion> GetSeccion()
        {
            return _seccionRepository.GetSeccion();
        }

        public IEnumerable<Seccion> GetSeccion(string criterio)
        {
            return _seccionRepository.GetSeccion(criterio);
        }

        public IEnumerable<Seccion> GetSeccion(string criterio, int? idGrado, int? idNivel)
        {
            return _seccionRepository.GetSeccion(criterio,idGrado,idNivel);
        }

        public Seccion GetSeccionById(int? idSeccion)
        {
            return _seccionRepository.GetSeccionById(idSeccion);
        }
    }
}
