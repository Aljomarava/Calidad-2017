using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
namespace Repository
{
    public interface IPaisRepository
    {
        
        IEnumerable<Pais> GetPaises(string criterio);
        IEnumerable<Pais> GetPaises();
        Pais GetPaisById(Int32? idPais);
        
        void AddPais(Pais pais);
        void EditarPais(Pais pais);

        void EliminarPais(Int32 idPais);

      
    }
}
