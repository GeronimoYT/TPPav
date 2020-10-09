using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Clases
{
    class Vuelo
    {
        public int NroVuelo { get; set; }
        public string FechaHoraSalida { get; set; }
        public string FechaHoraLlegada { get; set; }
        public int NroAvion { get; set; }
        public string IdTipoAvion { get; set; }
        public string IdAeropuerto { get; set; }
        public string IdDestino { get; set; }
        public string Estado { get; set; }
    }

}

