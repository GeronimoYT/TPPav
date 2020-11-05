using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Clases
{
   
        /*public int NroVuelo { get; set; }
        public DateTime FechaHoraSalida { get; set; }
        public DateTime FechaHoraLlegada { get; set; }
        public int NroAvion { get; set; }
        public string IdTipoAvion { get; set; }
        public int IdAeropuerto { get; set; }
        public int IdAeropuertoDestino { get; set; }
        public int Estado { get; set; }*/

        public class Vuelo
        {
            public int NroVuelo { get; set; }
            public DateTime FechaHoraSalida { get; set; }
            public DateTime FechaHoraLlegada { get; set; }
            public Avion Avion { get; set; }
            public string TipoAvion { get; set; } 
            public Aeropuerto Aeropuerto { get; set; }
            public Aeropuerto AeropuertoDestino { get; set; }
            public Estado Estado { get; set; }
        
            public void ValidarFechasyHoras()//
            {
                int res = DateTime.Compare(FechaHoraSalida, FechaHoraLlegada);
                if (res < 0)
                    throw new ApplicationException("La Fecha y Hora de Salida debe ser mayor que la Fecha de Llegada");
                else if (res == 0)
                    throw new ApplicationException("La Fecha y Hora de Salida debe ser mayor que la Fecha de Llegada");

            }

            public void ValidarAvion()
            {
                if (Avion == null || Avion.numero == 0)
                    throw new ApplicationException("El Nro de Avion es Requerido");
            }

            /*public bool TieneAvion()
            {
                return Avion != null;
            }*/

            public void ValidarAeropuertoOrigen()
            {
                if (Aeropuerto == null || Aeropuerto.IdAeropuerto == 0)
                    throw new ApplicationException("El Aeropuerto Origen es requerido");
            }

            /*public bool TieneAeropuerto()
            {
                return Aeropuerto != null;
            }*/

            public void ValidarAeropuertoDestino()
            {
                if (AeropuertoDestino == null || AeropuertoDestino.IdAeropuerto == 0)
                    throw new ApplicationException("El Aeropuerto Destino es requerido");
            }

            public void ValidarAeropuertos()
            { 
                if(Aeropuerto.IdAeropuerto ==AeropuertoDestino.IdAeropuerto)
                    throw new ApplicationException("Aeropuerto Origen puede coincidir con Aeropuerto Destino");
            }

            public void ValidarEstado()
            {
                if (Estado == null || Estado.IdEstado == 0)
                    throw new ApplicationException("El Estado es requerido");
            }
         }
}

