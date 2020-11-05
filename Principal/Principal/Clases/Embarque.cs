using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Clases
{
    class Embarque
    {

        private int nroVuelo;
        private DateTime fechaHoraEmbarque;
        private int idAeropuerto;
        private string tipoDniPasajero;
        private string nroDniPasajero;
        private int puertaEmbarque;
        private int idEstado;

        public Embarque()
        {

        }
        public Embarque(int nroVuelo, DateTime fechaHoraEmbarque, int idAeropuerto, string tipoDniPasajero, string nroDniPasajero, int puertaEmbarque, int idEstado)
        {
            this.nroVuelo = nroVuelo;
            this.fechaHoraEmbarque = fechaHoraEmbarque;
            this.idAeropuerto = idAeropuerto;
            this.tipoDniPasajero = tipoDniPasajero;
            this.nroDniPasajero = nroDniPasajero;
            this.puertaEmbarque = puertaEmbarque;
            this.idEstado = idEstado;
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

        public int Aeropuerto
        {
            get => idAeropuerto;
            set => idAeropuerto = value;
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

        public int Estado
        {
            get => idEstado;
            set => idEstado = value;
        }
    }
}
