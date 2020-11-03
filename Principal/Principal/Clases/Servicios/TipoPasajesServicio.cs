using Principal.Clases.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Clases.Servicios
{
    class TipoPasajesServicio
    {
        private TipoPasajesRepositorio _repositorio;

        public TipoPasajesServicio()
        {
            _repositorio = new TipoPasajesRepositorio();
        }

        public List<TipoPasaje> ObtenerTipoPasajes()
        {
            return _repositorio.ObtenerTipoPasajes();
        }
    }
}
