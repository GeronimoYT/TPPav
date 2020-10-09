using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Clases
{
    public class Avion
    {
        public Avion()
        {
        }
        public Avion(int nro, int idTipo, string descripcion) 
        {
            this.numero = nro;
            this.idTipo = idTipo;
            this.descripcion = descripcion;

        }
        public int numero { get; set; }
        public int idTipo { get; set; }
        public string descripcion  { get; set; }
    }
}
