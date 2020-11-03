using Principal.Clases.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Clases.Servicios
{
    class TipoDocumentosServicio
    {
        private TipoDocumentosRepositorio _repositorio;

        public TipoDocumentosServicio()
        {
            _repositorio = new TipoDocumentosRepositorio();
        }

        public List<TipoDocumento> ObtenerTipoDocumentos()
        {
            return _repositorio.ObtenerTipoDocumentos();
        }
    }
}
