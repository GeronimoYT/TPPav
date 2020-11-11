using Principal.Clases.Filtros;
using Principal.Clases.Repositorio;
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

        public VuelosServicio()
        {
            _vuelosRepositorio = new VuelosRepositorio();
        }

        public List<Vuelo> Obtener(VuelosFiltros filtros) // VERIFICAR QUE SEA MAYOR A 2010 ???
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

        /*public Vuelo Validar(Vuelo v)
        {
            v.ValidarFechaSalida();
            v.ValidarFechaLlegada();
            v.ValidarAvion();
            v.ValidarAeropuerto();
            v.ValidarAeropuertoDestino();
            //v.FechaAlta = DateTime.Today;//??????????????
            v.Estado = new Estado()
            {
                IdEstado = (long)EstadosVueloDisponibles.Nuevo ???
            };
            v.UsuarioResponsable = UsuarioServicio.UsuarioLogueado;//????????? AEROPUERTOS ??
            return v;
        }*/

    
       
        public void Registrar(Vuelo v)
        {
            _vuelosRepositorio.Registrar(v);
        }

        public Vuelo Obtener(long id)
        {
            return _vuelosRepositorio.Obtener(id);
        }

        

        /*public void PasarATesting(long id)
        {

            var bug = Obtener(id);
            if (UsuarioServicio.UsuarioLogueado.Perfil.Id != 3)
                throw new ApplicationException($"Sin permisos para realizar esta acción sobre el bug {bug.Titulo}");
            if ((EstadosBugDisponibles)bug.Estado.Id != EstadosBugDisponibles.Asignado)
                throw new ApplicationException($"El bug {bug.Titulo} no se encuentra en estado asignado");
            if (bug.UsuarioAsignado.Id != UsuarioServicio.UsuarioLogueado.Id)
                throw new ApplicationException($"El bug {bug.Titulo} no se encuentra en asignado a Ud."); // no es dueño
            bug.Estado = new Estado() { Id = (int)EstadosBugDisponibles.EnTesting };
            bug.UsuarioResponsable = UsuarioServicio.UsuarioLogueado;
            _bugsRespositorio.PasarATesting(bug);
         }*/
    }
}
