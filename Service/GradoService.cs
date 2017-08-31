using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Repository;
namespace Service
{
    public class GradoService : IGradoService
    {
        private IGradoRepository _gradoRepository;
        public GradoService()
        {
            if (_gradoRepository==null)
            {
                _gradoRepository = new GradoRepository();
            }
        }
        public void AddGrado(Grado Grado)
        {
            _gradoRepository.AddGrado(Grado);
        }

        public void EditarGrado(Grado Grado)
        {
            _gradoRepository.EditarGrado(Grado);
        }

        public void EliminarGrado(int idGrado)
        {
            _gradoRepository.EliminarGrado(idGrado);
        }

        public IEnumerable<Grado> GetGrado(string criterio)
        {
            return _gradoRepository.GetGrado(criterio);
        }

        public IEnumerable<Grado> GetGrado(string criterio, int? idNivel)
        {
            return _gradoRepository.GetGrado(criterio, idNivel);
        }

        public Grado GetGradoById(int? idGrado)
        {
            return _gradoRepository.GetGradoById(idGrado);
        }

        public IEnumerable<Grado> GetGrados()
        {
            return _gradoRepository.GetGrados();
        }
    }
}
