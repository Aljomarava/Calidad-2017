using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Repository;
namespace Service
{
    public class ApoderadosService : IApoderadoService
    {
        private IApoderadoRepository _apoderadoRepository;
        public ApoderadosService()
        {
            if (_apoderadoRepository==null)
            {
                _apoderadoRepository = new ApoderadoRepository();
            }
        }
        public void AddApoderado(Apoderado apoderado)
        {
            _apoderadoRepository.AddApoderado(apoderado);
        }

        public void EditarApoderado(Apoderado apoderado)
        {
            _apoderadoRepository.EditarApoderado(apoderado);
        }

        public void EliminarApoderado(int idApoderado)
        {
            _apoderadoRepository.EliminarApoderado(idApoderado);
        }

        public Apoderado GetApoderadoById(int? idApoderado)
        {
            return _apoderadoRepository.GetApoderadoById(idApoderado);
        }

        public IEnumerable<Apoderado> GetApoderados(string criterio)
        {
            return _apoderadoRepository.GetApoderados(criterio);
        }

        public IEnumerable<Apoderado> GetApoderados()
        {
            return _apoderadoRepository.GetApoderados();
        }

        public IEnumerable<Apoderado> GetApoderados(string criterio, int? idUbigeo)
        {
            return _apoderadoRepository.GetApoderados(criterio, idUbigeo);
        }
    }
}
