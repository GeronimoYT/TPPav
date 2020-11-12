using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Clases
{
    class EmbarqueV2
    {
        

        public EmbarqueV2()
        {

        }
        public EmbarqueV2(DateTime fechaHoraEmbarque, int puertaEmbarque)
        {
            this.PuertaEmbarque = puertaEmbarque;
            this.FechaHoraEmbarque = fechaHoraEmbarque;
        }


        public VueloV2 Vuelo
        {
            get; set;
        }

        public DateTime FechaHoraEmbarque
        {
            get;set;
        }

        public Aeropuerto Aeropuerto
        {
            get;set;
        }    
        public int PuertaEmbarque
        {
            get; set;
        }

        public Estado Estado
        {
            get; set;
        }
    }
}
