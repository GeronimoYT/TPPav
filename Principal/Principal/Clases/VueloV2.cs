using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Clases
{
    public class VueloV2
    {
        public VueloV2()
        {

        }
        public VueloV2(int nroVuelo, DateTime fechaHoraSalida, DateTime fechaHoraLlegada, int minutos, int nroAvion)
        {
            this.NroVuelo = nroVuelo;
            this.FechaHoraLlegada = fechaHoraLlegada;
            this.FechaHoraSalida = fechaHoraSalida;
            this.Minutos = minutos;
            this.NroAvion = nroAvion;
        }
        public int NroVuelo { get; set; }
        public DateTime FechaHoraSalida { get; set; }
        public DateTime FechaHoraLlegada { get; set; }

        public AvionV2 Avion{ get; set; }
        public int NroAvion { get; set; }
        public int IdTipoAvion { get; set; }
        public Aeropuerto IdAeropuerto { get; set; }
        public Aeropuerto IdAeropuertoDestino { get; set; }
        public Estado Estado { get; set; }
        public int Minutos { get; set; }
    }
}
