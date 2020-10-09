using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Clases
{
    class Pasaje
    {
        public int Id { get; set; }
        public TipoPasaje TipoPasaje { get; set; }
        public string Descripcion { get; set; }
        public int Precio { get; set; }
    }
}
