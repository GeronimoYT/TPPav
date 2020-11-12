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
        public List<Pasajero> ObtenerPasajeros(string tipoDocumento, string nroDocumento, string apellido, string nombre, bool estado)
        {
            return _repositorio.ObtenerPasajeros(tipoDocumento, nroDocumento, apellido, nombre, estado);
        }
        public List<Pasajero> ObtenerPasajeros(string tipoDocumento,bool registro)
        {
            return _repositorio.ObtenerPasajeros(tipoDocumento,registro);

        }

        public void ValidarPasajero(Pasajero _pasajero)
        {
            _pasajero.ValidarNroDocumento();
            _pasajero.ValidarNombre();
            _pasajero.ValidarApellido();
            _pasajero.ValidarTelefono();
            _pasajero.ValidarEmail();
            _pasajero.ValidarTipoDocumento();


        }

        public bool RegistrarPasajero(Pasajero pasajero)
        {
            var filasAfectadas = _repositorio.RegistrarPasajero(pasajero);
            if (filasAfectadas == 1)
                return true;
            return false;
        }
        public Pasajero ObtenerPasajero(string tipoDocumento, string nroDocumento)
        {
            var pasajero = _repositorio.ObtenerPasajero(tipoDocumento, nroDocumento);
            return pasajero;
        }
        public void ActualizarPasajero(Pasajero _pasajero)
        {
            var filasAfectadas = _repositorio.ActualizarPasajero(_pasajero);
            if (filasAfectadas != 1)
                throw new ApplicationException("Hubo un problema al actualizar");
        }
        public void DarBajaPasajero(Pasajero _pasajero)
        {
            var filasAfectadas = _repositorio.DarBajaPasajero(_pasajero);
            if (filasAfectadas != 1)
                throw new ApplicationException("Hubo un problema al actualizar");
        }
    }
}
