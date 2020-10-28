using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal.Clases
{
    class Equipaje
    {
        public Equipaje() { }
        
        public Equipaje(int numero, int tipo, string descripcion, int tipoDNI, int DNI) 
        {
            this.numero = numero;
            this.tipo = tipo;
            this.descripcion = descripcion;
            this.tipoDNI = tipoDNI;
            this.DNI = DNI;
        }

        public int numero { get; set; }
        public int tipo { get; set; }
        public string descripcion { get; set; }
        public int tipoDNI { get; set; }
        public int DNI { get; set; }
    }
}
