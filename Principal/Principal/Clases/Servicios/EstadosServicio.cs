using Principal.Clases.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Clases.Servicios
{
    class EstadosServicio
    {
        private EstadosRepositorio _repositorio;

        public EstadosServicio()
        {
            _repositorio = new EstadosRepositorio();
        }

        public List<Estado> ObtenerEstados()
        {
            return _repositorio.ObtenerEstados();
        }
    }
}
