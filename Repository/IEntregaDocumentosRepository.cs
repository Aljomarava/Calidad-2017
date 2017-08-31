using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
   public  interface IEntregaDocumentosRepository
    {
        IEnumerable<EntregaDocuentos> GetEntregaDocuentos();
        EntregaDocuentos GetEntregaDocuentosById(Int32? iddoc);

        void AddEntregaDocuentos(EntregaDocuentos entregaDocuentos);
        void EditarEntregaDocuentos(EntregaDocuentos entregaDocuentos);

        void EliminarEntregaDocuentos(Int32 iddoc);
    }
}
