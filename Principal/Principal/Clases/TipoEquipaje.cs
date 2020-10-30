using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Clases
{
    class TipoEquipaje
    {
        public TipoEquipaje() { }
        public TipoEquipaje(int id, int minimo, int maximo)
        {
            this.id = id;
            this.pesoMinimo = minimo;
            this.pesoMaximo = maximo;
            this.categoria = $"{this.pesoMinimo.ToString()}kg a {this.pesoMaximo.ToString()}kg";
        }

        public int id { get; set; }
        public int pesoMinimo { get; set; }
        public int pesoMaximo { get; set; }
        public string categoria { get; set; }
    }
}
