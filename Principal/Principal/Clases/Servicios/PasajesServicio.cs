using Principal.Clases.Filtros;
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

        public List<Pasaje> ObtenerPasajes(PasajesFiltros filtros)
        {

            return _repositorio.ObtenerPasajes(filtros);

        }
        public void RegistrarPasaje(Pasaje _pasaje)
        {
            _repositorio.Registrar(_pasaje);
        }

        public Pasaje ObtenerPasaje(PasajesFiltros filtros)
        {
            var pasaje = _repositorio.ObtenerPasaje(filtros);
            return pasaje;
        }
        public void ActualizarPasaje(Pasaje _pasaje)
        {
            _repositorio.ActualizarPasaje(_pasaje);
        }

    }
}
