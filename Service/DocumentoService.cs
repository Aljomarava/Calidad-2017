using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Repository;
namespace Service
{
    public class DocumentoService : IDocumentoService
    {
        private IDocuementosrRepository _documentoService;
        public DocumentoService()
        {
            if (_documentoService==null)
            {
                _documentoService = new DocuementosrRepository();
            }
        }
        public void AddDocumento(Documentos documento)
        {
            _documentoService.AddDocumento(documento);
        }

        public void EditarDocumento(Documentos documento)
        {
            _documentoService.EditarDocumento(documento);
        }

        public void EliminarDocumento(int idDocumento)
        {
            _documentoService.EliminarDocumento(idDocumento);
        }

        public Documentos GetAlumnooById(int? idDocumento)
        {
            return _documentoService.GetAlumnooById(idDocumento);
        }

        public IEnumerable<Documentos> GetDocumentos()
        {
            return _documentoService.GetDocumentos();
        }

        public IEnumerable<Documentos> GetDocumentos(string criterio)
        {
            return _documentoService.GetDocumentos(criterio);
        }

        //public IEnumerable<Documentos> GetDocumentos(string criterio, int? idAlumno)
        //{
        //    return _documentoService.GetDocumentos(criterio,idAlumno);
        //}
    }
}
