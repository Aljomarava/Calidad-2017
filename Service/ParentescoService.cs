using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Repository;
namespace Service
{
   public class ParentescoService : IParentescoService
    {
        private readonly IParentescoRepository _parentescoRepository;
        public ParentescoService()
        {
            if (_parentescoRepository==null)
            {
                _parentescoRepository = new ParentescoRepository();
            }
        }
        public void AddParentesco(Parentesco parentesco)
        {
            _parentescoRepository.AddParentesco(parentesco);
        }

        public void EditarParentescos(Parentesco parentesco)
        {
            _parentescoRepository.EditarParentescos(parentesco);
        }

        public void EliminarParentesco(int idParentesco)
        {
            _parentescoRepository.EliminarParentesco(idParentesco);
        }

        public Parentesco GetParentescoById(int? idParentesco)
        {
            return _parentescoRepository.GetParentescoById(idParentesco);
        }

        public IEnumerable<Parentesco> GetParentescos()
        {
            return _parentescoRepository.GetParentescos();
        }

        public IEnumerable<Parentesco> GetParentescos(string criterio)
        {
            return _parentescoRepository.GetParentescos(criterio);
        }
    }
}
