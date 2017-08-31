using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using System.Data.Entity;

namespace Repository
{
    public class AlumnoRepository : MasterRepository, IAlumnoRepository
    {
        public void AddAlumno(Alumno alumno)
        {
            Context.alumnos.Add(alumno);
            Context.SaveChanges();
        }

        public void EditarAlumno(Alumno alumno)
        {
            Context.Entry(alumno).State = EntityState.Modified;
            Context.SaveChanges();
        }

        public void EliminarAlumno(int idAlumno)
        {
            var al = Context.alumnos.Find(idAlumno);
            if (al != null)
            {
                Context.alumnos.Remove(al);
                Context.SaveChanges();
            }
        }

        public Alumno GetAlumnooById(int? idAlumnoo)
        {
            return Context.alumnos.Find(idAlumnoo);
        }

        public IEnumerable<Alumno> GetAlumnos()
        {
            return Context.alumnos;
        }

        public IEnumerable<Alumno> GetAlumnos(string criterio)
        {
            var query = from p in Context.alumnos
                        select p;
            if (!string.IsNullOrEmpty(criterio))
            {
                query = from p in query
                        where p.Apellidos.ToUpper().Contains(criterio.ToUpper()) ||
                              p.Dni.ToUpper().Contains(criterio.ToUpper())
                        select p;
            }

            return query;
        }

        public IEnumerable<Alumno> GetAlumnos(string criterio, int? idUbigeo)
        {
            var query = from p in Context.alumnos
                        select p;

            if (!string.IsNullOrEmpty(criterio))
            {
                query = from p in query
                        where p.Dni.ToUpper().Contains(criterio.ToUpper())

                        select p;
            }

            if (idUbigeo.HasValue)
            {
                query = query.Where(p => p.UbigeoId.Equals(idUbigeo.Value));
            }

            return query;
        }
    }
}
