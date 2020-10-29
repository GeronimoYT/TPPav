using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Clases
{
    class Pasaje
    {
        public Pasaje()
        {

        }
        public int Id { get; set; }
        public TipoPasaje IdTipoPasaje { get; set; }

        public Pasajero NroDocumento { get; set; }
        public string TipoDocumento { get; set; }

        public string Motivo { get; set; }

        public int Precio { get; set; }


        public bool TienePrecio()
        {
            return Precio != 0;
        }

        public bool TieneMotivo()
        {
            return Motivo != null;
        }

    }
}
