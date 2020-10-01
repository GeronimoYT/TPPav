using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Clases
{
    public class Aeropuerto
    {
        private int idAeropuerto;
        private string domicilio;
        private long telefono;
        private string descripcion;
        private int cantPuertasEmbarque;
        private int cantMangasVuelo;

        public Aeropuerto()
        {

        }
        public Aeropuerto(int idAeropuerto,string domicilio,long telefono,string descripcion, int cantPuertasEmbarque, int cantMangasVuelo)
        {
            this.idAeropuerto = idAeropuerto;
            this.domicilio = domicilio;
            this.telefono = telefono;
            this.descripcion = descripcion;
            this.cantPuertasEmbarque = cantPuertasEmbarque;
            this.cantMangasVuelo = cantMangasVuelo;
        }

        public int IdAeropuerto
        {
            get => idAeropuerto;
            set => idAeropuerto = value;
        }

        public string Domicilio
        {
            get => domicilio;
            set => domicilio = value;
        }
        public long Telefono
        {
            get => telefono;
            set => telefono = value;
        }
        public string Descripcion
        {
            get => descripcion;
            set => descripcion = value;
        }
        public int CantPuertasEmbarque
        {
            get => cantPuertasEmbarque;
            set => cantPuertasEmbarque = value;
        }
        public int CantMangasVuelo
        {
            get => cantMangasVuelo;
            set => cantMangasVuelo = value;
        }


    }
}
