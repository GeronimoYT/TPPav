using Principal.Clases.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Clases.Servicios
{
    class PasajesServicio
    {
        private PasajesRepositorio _repositorio;

        public PasajesServicio()
        {
            _repositorio = new PasajesRepositorio();
        }

        public List<Pasaje> ObtenerPasajes()
        {
            return _repositorio.ObtenerPasajes();
        }
    }
}
