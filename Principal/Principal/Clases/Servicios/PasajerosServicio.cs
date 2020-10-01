using Principal.Clases.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Clases.Servicios
{
    class PasajerosServicio
    {
        private PasajerosRepositorio _repositorio;

        public PasajerosServicio()
        {
            _repositorio = new PasajerosRepositorio();
        }

        public List<Pasajero> ObtenerPasajeros()
        {
            return _repositorio.ObtenerPasajeros();
        }
    }
}
