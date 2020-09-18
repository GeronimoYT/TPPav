using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Clases
{
    class Aeropuerto
    {
        private int idAeropuerto;
        private string nombre;
        private string domicilio;
        private int telefono;
        private string descripcion;
        private int cantPuertasEmbarque;
        private int cantMangasVuelo;


        public Aeropuerto(int idAeropuerto, string nombre,string domicilio,int telefono,string descripcion, int cantPuertasEmbarque, int cantMangasVuelo)
        {
            this.idAeropuerto = idAeropuerto;
            this.nombre = nombre;
            this.domicilio = domicilio;
            this.telefono = telefono;
            this.descripcion = descripcion;
            this.cantPuertasEmbarque = cantPuertasEmbarque;
            this.cantMangasVuelo = cantMangasVuelo;
        }

        public int IdAeropuerto
        {
            get => idAeropuerto;
        }

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }
        public string Domicilio
        {
            get => domicilio;
            set => domicilio = value;
        }
        public int Telefono
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
