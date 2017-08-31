using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;
namespace Service
{
    public class EntregaDocumentosService : IEntregaDocumentosService
    {
        private IEntregaDocumentosRepository _entregaDocumentosservice;
        public EntregaDocumentosService()
        {
            if (_entregaDocumentosservice==null)
            {
                _entregaDocumentosservice = new EntregaDocumentosRepository();
            }
        }
        public void AddEntregaDocuentos(EntregaDocuentos entregaDocuentos)
        {
            _entregaDocumentosservice.AddEntregaDocuentos(entregaDocuentos);
        }

        public void EditarEntregaDocuentos(EntregaDocuentos entregaDocuentos)
        {
            _entregaDocumentosservice.EditarEntregaDocuentos(entregaDocuentos);
        }

        public void EliminarEntregaDocuentos(int iddoc)
        {
            _entregaDocumentosservice.EliminarEntregaDocuentos(iddoc);
        }

        public IEnumerable<EntregaDocuentos> GetEntregaDocuentos()
        {
            return _entregaDocumentosservice.GetEntregaDocuentos();
        }

        public EntregaDocuentos GetEntregaDocuentosById(int? iddoc)
        {
            return _entregaDocumentosservice.GetEntregaDocuentosById(iddoc);
        }
    }
}
