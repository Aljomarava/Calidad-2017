using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IParentescoService
    {
        IEnumerable<Parentesco> GetParentescos(string criterio);
        IEnumerable<Parentesco> GetParentescos();
        Parentesco GetParentescoById(Int32? idParentesco);

        void AddParentesco(Parentesco parentesco);
        void EditarParentescos(Parentesco parentesco);

        void EliminarParentesco(Int32 idParentesco);
    }
}
