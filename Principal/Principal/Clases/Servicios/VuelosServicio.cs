
﻿using Principal.Clases.Filtros;
using Principal.Clases.Repositorio;

﻿using Principal.Clases.Repositorio;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Clases.Servicios
{

    public class VuelosServicio
    {
        private VuelosRepositorio _vuelosRepositorio;
        private VuelosRepositorio _repositorio;

        public List<Vuelo> Obtener(VuelosFiltros filtros)
        {
            if (filtros.FechaDesde.HasValue)
                filtros.FechaDesde = new DateTime(filtros.FechaDesde.Value.Year,
                                                  filtros.FechaDesde.Value.Month,
                                                  filtros.FechaDesde.Value.Day);
            if (filtros.FechaHasta.HasValue)
                filtros.FechaHasta = new DateTime(filtros.FechaHasta.Value.Year,
                                                  filtros.FechaHasta.Value.Month,
                                                  filtros.FechaHasta.Value.Day);
            if (filtros.FechaDesde.HasValue && filtros.FechaHasta.HasValue &&
                filtros.FechaDesde > filtros.FechaHasta)
                throw new ApplicationException("Fecha Desde no puede ser mayor a Fecha Hasta");
            return _vuelosRepositorio.Obtener(filtros);
        }



        public Vuelo Obtener(long id)
        {
            return _vuelosRepositorio.Obtener(id);
        }

        public VuelosServicio()
        {
            _repositorio = new VuelosRepositorio();
        }

        public List<VueloV2> ObtenerVuelos(string Origen, string Destino, DateTime FechaSalida, DateTime FechaLlegada)
        {
            return _repositorio.ObtenerVuelos(Origen, Destino,  FechaSalida, FechaLlegada);
        }
    }
}
