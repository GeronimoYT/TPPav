using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Clases
{
    class Asiento
    {
        public Asiento() { }

        public Asiento(int numero, int nroAvion, int tipoAvion, int fila, int columna, char ubicacion, char estado, int clase)
        {
            this.numero = numero;
            this.nroAvion = nroAvion;
            this.tipoAvion = tipoAvion;
            this.fila = fila;
            this.columna = columna;
            this.ubicacion = ubicacion;
            this.estado = estado;
            this.clase = clase;
        }

        public int numero { get; set; }
        public int nroAvion { get; set; }
        public int tipoAvion { get; set; }
        public int fila { get; set; }
        public int columna { get; set; }
        public char ubicacion { get; set; }
        public char estado { get; set; }
        public int clase { get; set; }
        
    }
}
