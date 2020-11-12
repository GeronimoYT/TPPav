using Principal.Clases.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Clases.Servicios
{
    class EmbarquesServicio
    {
        private EmbarquesRepositorio _repositorio;

        public EmbarquesServicio()
        {
            _repositorio = new EmbarquesRepositorio();
        }

        public List<Embarque> ObtenerEmbarques()
        {
            return _repositorio.ObtenerEmbarques();
        }
        public List<EmbarqueV2> ObtenerEmbarques(string Origen, string Destino)
        {
            return _repositorio.ObtenerEmbarquesV2(Origen,Destino);
        }
    }
}
