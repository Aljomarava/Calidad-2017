using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using System.Data.Entity;

namespace Repository
{
    public class EntregaDocumentosRepository : MasterRepository, IEntregaDocumentosRepository
    {
        public void AddEntregaDocuentos(EntregaDocuentos entregaDocuentos)
        {
            Context.entregaDocuentos.Add(entregaDocuentos);
            Context.SaveChanges();
        }

        public void EditarEntregaDocuentos(EntregaDocuentos entregaDocuentos)
        {
            Context.Entry(entregaDocuentos).State = EntityState.Modified;
            Context.SaveChanges();
        }

        public void EliminarEntregaDocuentos(int iddoc)
        {
            var Ed = Context.entregaDocuentos.Find(iddoc);
            if (Ed != null)
            {
                Context.entregaDocuentos.Remove(Ed);
                Context.SaveChanges();
            }
        }

        public IEnumerable<EntregaDocuentos> GetEntregaDocuentos()
        {
            return Context.entregaDocuentos;
        }

        public EntregaDocuentos GetEntregaDocuentosById(int? iddoc)
        {
            return Context.entregaDocuentos.Find(iddoc);
        }
    }
}
