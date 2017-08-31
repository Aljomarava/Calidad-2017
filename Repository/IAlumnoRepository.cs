using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IAlumnoRepository
    {
        IEnumerable<Alumno> GetAlumnos(string criterio, Int32? idUbigeo);
        IEnumerable<Alumno> GetAlumnos(string criterio);
        IEnumerable<Alumno> GetAlumnos();
        Alumno GetAlumnooById(Int32? idAlumnoo);

        void AddAlumno(Alumno alumno);
        void EditarAlumno(Alumno alumno);

        void EliminarAlumno(Int32 idAlumno);
    }
}
