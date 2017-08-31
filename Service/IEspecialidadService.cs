using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IEspecialidadService
    {
        IEnumerable<Especialidad> GetEspecialidades(string criterio);
        IEnumerable<Especialidad> GetEspecialidades();
        Especialidad GetEspecialidadById(Int32? idEspecialidad);

        void AddEspecialidad(Especialidad especialidad);
        void EditarEspecialidad(Especialidad especialidad);

        void EliminarEspecialidad(Int32 idEspecialidad);
    }
}
