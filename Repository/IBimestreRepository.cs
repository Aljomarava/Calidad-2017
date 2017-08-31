using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IBimestreRepository
    {

        IEnumerable<Bimestre> GetBimestres(string criterio);
        IEnumerable<Bimestre> GetBimestres();
        Bimestre GetBimestreById(Int32? idBimestre);

        void AddBimestre(Bimestre Bimestre);
        void EditarBimestre(Bimestre Bimestre);

        void EliminarBimestre(Int32 idBimestre);
    }
}
