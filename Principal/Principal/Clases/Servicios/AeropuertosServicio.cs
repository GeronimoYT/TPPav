using Principal.Clases.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Clases.Servicios
{
    class AeropuertosServicio
    {
        private AeropuertosRepositorio _repositorio;

        public AeropuertosServicio()
        {
            _repositorio = new AeropuertosRepositorio();
        }

        public List<Aeropuerto> ObtenerAeropuertos()
        {
            return _repositorio.ObtenerAeropuertos();
        }
    }
}
