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
        
        public Equipaje(int numero, int tipo, string descripcion, string tipoDNI, string DNI) 
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
        public string tipoDNI { get; set; }
        public string DNI { get; set; }

        public override string ToString()
        {
            string cadena = $"Datos Equipaje\n" +
                            $"Pertenece a: {tipoDNI} {DNI}\n" +
                            $"Numero = {numero}\n" +
                            $"Descripcion = {descripcion}";
                
            return cadena;
        }
    }
}
