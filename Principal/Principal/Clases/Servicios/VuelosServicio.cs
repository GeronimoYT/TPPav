using Principal.Clases.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Clases.Servicios
{
    class VuelosServicio
    {
        private VuelosRepositorio _repositorio;

        public VuelosServicio()
        {
            _repositorio = new VuelosRepositorio();
        }

        public List<VueloV2> ObtenerVuelos(int idAeropuertoOrigen,int idAeropuertoDestino)
        {
            return _repositorio.ObtenerVuelos(idAeropuertoOrigen, idAeropuertoDestino);
        }
        public List<VueloV2> ObtenerVuelos(string Origen, string Destino, DateTime FechaSalida, DateTime FechaLlegada)
        {
            return _repositorio.ObtenerVuelos(Origen, Destino,  FechaSalida, FechaLlegada);
        }
    }
}
