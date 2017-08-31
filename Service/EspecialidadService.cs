using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Repository;
namespace Service
{
    public class EspecialidadService : IEspecialidadService
    {
        private readonly IEspecialidadRepository  _especialidadRepository;

        public EspecialidadService()
        {
            if (_especialidadRepository==null)
            {
                _especialidadRepository = new EspecialidadRepository();
            }
        }
        public void AddEspecialidad(Especialidad especialidad)
        {
            _especialidadRepository.AddEspecialidad(especialidad);
        }

        public void EditarEspecialidad(Especialidad especialidad)
        {
            _especialidadRepository.EditarEspecialidad(especialidad);
        }

        public void EliminarEspecialidad(int idEspecialidad)
        {
            _especialidadRepository.EliminarEspecialidad(idEspecialidad);
        }

        public Especialidad GetEspecialidadById(int? idEspecialidad)
        {
            return _especialidadRepository.GetEspecialidadById(idEspecialidad);
        }

        public IEnumerable<Especialidad> GetEspecialidades()
        {
            return _especialidadRepository.GetEspecialidades();
        }

        public IEnumerable<Especialidad> GetEspecialidades(string criterio)
        {
            return _especialidadRepository.GetEspecialidades(criterio);
        }
    }
}
