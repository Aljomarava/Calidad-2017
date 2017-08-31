using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Repository;
namespace Service
{

    public class UbigeoService : IUbigeoService
    {
        private IUbigeoRepository _ubigeoRepository;

        public UbigeoService()
        {
            if (_ubigeoRepository==null)
            {
                _ubigeoRepository = new UbigeoRepository();
            }
        }
        public void AddUbigeo(Ubigeo ubigeo)
        {
            _ubigeoRepository.AddUbigeo(ubigeo);
        }

        public void EditarUbigeo(Ubigeo ubigeo)
        {
            _ubigeoRepository.EditarUbigeo(ubigeo);
        }

        public void EliminarUbigeo(int idUbigeo)
        {
            _ubigeoRepository.EliminarUbigeo(idUbigeo);
        }

        public Ubigeo GetUbigeoByCodigo(string codigo)
        {
            return _ubigeoRepository.GetUbigeoByCodigo(codigo);
        }

        public Ubigeo GetUbigeoById(int? idUbigeo)
        {
            return _ubigeoRepository.GetUbigeoById(idUbigeo);
        }

        public IEnumerable<Ubigeo> GetUbigeos()
        {
            return _ubigeoRepository.GetUbigeos();
        }

        public IEnumerable<Ubigeo> GetUbigeos(string criterio)
        {
            return _ubigeoRepository.GetUbigeos(criterio);
        }

        public IEnumerable<Ubigeo> GetUbigeos(string criterio, int? idPais)
        {
            return _ubigeoRepository.GetUbigeos(criterio, idPais);
        }
    }
}
