using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;
using Domain;
namespace Service
{
    public class PaisService : IPaisService
    {
        private readonly IPaisRepository _paisRepository;
        public PaisService()
        {
            if (_paisRepository == null)
           {
                _paisRepository = new PaisRepository();
           }
        }
        public void AddPais(Pais pais)
        {
            _paisRepository.AddPais(pais);
        }

        public void EditarPais(Pais pais)
        {
            _paisRepository.EditarPais(pais);
        }

        public void EliminarPais(int idPais)
        {
            _paisRepository.EliminarPais(idPais);
        }

        public Pais GetPaisById(int? idPais)
        {
            return _paisRepository.GetPaisById(idPais);
        }

        public IEnumerable<Pais> GetPaises()
        {
            return _paisRepository.GetPaises();
        }

        public IEnumerable<Pais> GetPaises(string criterio)
        {
            return _paisRepository.GetPaises(criterio);
        }
    }
}
