using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Repository;
namespace Service
{
    public class AlumnoService : IAlumnoService
    {
        private IAlumnoRepository _alumnoRepository;
        public AlumnoService()
        {
            if (_alumnoRepository==null)
            {
                _alumnoRepository = new AlumnoRepository();
            }
        }
        public void AddAlumno(Alumno alumno)
        {
            _alumnoRepository.AddAlumno(alumno);
        }

        public void EditarAlumno(Alumno alumno)
        {
            _alumnoRepository.EditarAlumno(alumno);
        }

        public void EliminarAlumno(int idAlumno)
        {
            _alumnoRepository.EliminarAlumno(idAlumno);
        }

        public Alumno GetAlumnooById(int? idAlumnoo)
        {
            return _alumnoRepository.GetAlumnooById(idAlumnoo);
        }

        public IEnumerable<Alumno> GetAlumnos()
        {
            return _alumnoRepository.GetAlumnos();
        }

        public IEnumerable<Alumno> GetAlumnos(string criterio)
        {
             return _alumnoRepository.GetAlumnos(criterio);
        }
    

        public IEnumerable<Alumno> GetAlumnos(string criterio, int? idUbigeo)
        {
            return _alumnoRepository.GetAlumnos(criterio,idUbigeo);
        }
    }
}
