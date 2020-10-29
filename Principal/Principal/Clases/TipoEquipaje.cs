using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Clases
{
    class TipoEquipaje
    {
        public TipoEquipaje(int id, int peso)
        {
            this.id = id;
            this.peso = peso;
        }

        public int id { get; set; }
        public int peso { get; set; }
    }
}
