using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Repository;
namespace Service
{
    public class NivelService : INivelService
    {
        private INivelRepository _nivelRepository;
        public NivelService()
        {
            if (_nivelRepository==null)
            {
                _nivelRepository = new NivelRepository();
            }
        }
        public void AddNivel(Nivel nivel)
        {
            _nivelRepository.AddNivel(nivel);
        }

        public void EditarNivel(Nivel nivel)
        {
            _nivelRepository.EditarNivel(nivel);
        }

        public void EliminarNivel(int idNivel)
        {
            _nivelRepository.EliminarNivel(idNivel);
        }

        public Nivel GetNivelById(int? idNivel)
        {
            return _nivelRepository.GetNivelById(idNivel);
        }

        public IEnumerable<Nivel> GetNiveles()
        {
            return _nivelRepository.GetNiveles();
        }

        public IEnumerable<Nivel> GetNiveles(string criterio)
        {
            return _nivelRepository.GetNiveles(criterio);
        }
    }
}
