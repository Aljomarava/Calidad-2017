using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Repository;

namespace Service
{
    public class DocenteService : IDocenteService
    {
        private readonly IDocenteRepository _docenteRepository;
        public DocenteService()
        {
            if (_docenteRepository ==null)
            {
                _docenteRepository = new DocenteRepository();
            }
        }
        public void AddDocente(Docente docente)
        {
            _docenteRepository.AddDocente(docente);
        }

        public void EditarDocente(Docente docente)
        {
            _docenteRepository.EditarDocente(docente);
        }

        public void EliminarDocente(int idDocente)
        {
            _docenteRepository.EliminarDocente(idDocente);
        }

        public Docente GetDocenteById(int? idDocente)
        {
            return _docenteRepository.GetDocenteById(idDocente);
        }

        public IEnumerable<Docente> GetDocentes()
        {
            return _docenteRepository.GetDocentes();
        }

        public IEnumerable<Docente> GetDocentes(string criterio)
        {
            return _docenteRepository.GetDocentes(criterio);
        }

        //public IEnumerable<Docente> GetDocentes(string criterio, int? idUbigeo)
        //{
        //    return _docenteRepository.GetDocentes(criterio, idUbigeo);
        //}
    }
}
