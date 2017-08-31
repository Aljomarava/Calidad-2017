using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
   public interface IUbigeoService
    {
        IEnumerable<Ubigeo> GetUbigeos(string criterio, Int32? idPais);
        IEnumerable<Ubigeo> GetUbigeos(string criterio);
        IEnumerable<Ubigeo> GetUbigeos();
        Ubigeo GetUbigeoById(Int32? idUbigeo);

        void AddUbigeo(Ubigeo ubigeo);
        void EditarUbigeo(Ubigeo ubigeo);

        void EliminarUbigeo(Int32 idUbigeo);

        Ubigeo GetUbigeoByCodigo(string codigo);
    }
}
