using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Clases
{
    class NuevoEmbarque
    {
        private int nroVuelo;
        private DateTime fechaHoraEmbarque;
        private string aeropuerto;
        private string tipoDniPasajero;
        private string nroDniPasajero;
        private int puertaEmbarque;
        private string estado;

        public NuevoEmbarque()
        {

        }
        public NuevoEmbarque(int nroVuelo, DateTime fechaHoraEmbarque, string aeropuerto, string tipoDniPasajero,string nroDniPasajero, int puertaEmbarque, string estado)
        {
            this.nroVuelo = nroVuelo;
            this.fechaHoraEmbarque = fechaHoraEmbarque;
            this.aeropuerto = aeropuerto;
            this.tipoDniPasajero = tipoDniPasajero;
            this.nroDniPasajero = nroDniPasajero;
            this.puertaEmbarque = puertaEmbarque;
            this.estado = estado;            
        }

        public int NroVuelo
        {
            get => nroVuelo;
            set => nroVuelo = value;
        }

        public DateTime FechaHoraEmbarque
        {
            get => fechaHoraEmbarque;
            set => fechaHoraEmbarque = value;
        }

        public string Aeropuerto
        {
            get => aeropuerto;
            set => aeropuerto = value;
        }

        public string TipoDniPasajero
        {
            get => tipoDniPasajero;
            set => tipoDniPasajero = value;
        }
        public string NroDniPasajero
        {
            get => nroDniPasajero;
            set => nroDniPasajero = value;
        }
        
        public int PuertaEmbarque
        {
            get => puertaEmbarque;
            set => puertaEmbarque = value;
        }

        public string Estado
        {
            get => estado;
            set => estado = value;
        }

    }
}
