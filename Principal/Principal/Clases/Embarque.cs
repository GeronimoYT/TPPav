using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Clases
{
    class Embarque
    {
        public string NroVuelo { get; set; }
        public DateTime FechaHoraSalida { get; set; }
        public DateTime FechaHoraLlegada { get; set; }
        public int NroAvion { get; set; }
        public int IdAeropuerto { get; set; }
        public Pasajero Pasajero { get; set; }
        public int PuertaEmbarque { get; set; }
    }
}
