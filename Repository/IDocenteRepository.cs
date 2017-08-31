using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IDocenteRepository
    {
        //IEnumerable<Docente> GetDocentes(string criterio, Int32? idUbigeo);
        IEnumerable<Docente> GetDocentes(string criterio);
        IEnumerable<Docente> GetDocentes();
        Docente GetDocenteById(Int32? idDocente);

        void AddDocente(Docente docente);
        void EditarDocente(Docente docente);

        void EliminarDocente(Int32 idDocente);

    }
}
