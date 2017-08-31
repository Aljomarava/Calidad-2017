using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
   public  interface IDocumentoService
    {
        //IEnumerable<Documentos> GetDocumentos(string criterio, Int32? idAlumno);
        IEnumerable<Documentos> GetDocumentos(string criterio);
        IEnumerable<Documentos> GetDocumentos();
        Documentos GetAlumnooById(Int32? idDocumento);

        void AddDocumento(Documentos documento);
        void EditarDocumento(Documentos documento);

        void EliminarDocumento(Int32 idDocumento);
    }
}
