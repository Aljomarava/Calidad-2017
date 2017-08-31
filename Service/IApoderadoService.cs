using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IApoderadoService
    {
        IEnumerable<Apoderado> GetApoderados(string criterio, Int32? idUbigeo);
        IEnumerable<Apoderado> GetApoderados(string criterio);
        IEnumerable<Apoderado> GetApoderados();
        Apoderado GetApoderadoById(Int32? idApoderado);

        void AddApoderado(Apoderado apoderado);
        void EditarApoderado(Apoderado apoderado);

        void EliminarApoderado(Int32 idApoderado);
    }
}
