using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Clases
{
   public class Vuelo {
       public int NroVuelo { get; set; }
        public DateTime FechaHoraSalida { get; set; }
        public DateTime FechaHoraLlegada { get; set; }
        public int NroAvion { get; set; }
        public string IdTipoAvion { get; set; }
        public int IdAeropuerto { get; set; }
        public int IdAeropuertoDestino { get; set; }

        public int Estado { get; set; }


        //Cree otros atibutos para poder usarlos en el pasaje en VueloV2

        
    }

}


