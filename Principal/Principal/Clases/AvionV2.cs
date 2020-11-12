using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Clases
{
    public class AvionV2
    {
        public AvionV2()
        {
        }
        
        public int NroAvion { get; set; }
        public TipoAvion TipoAvion { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }

        
    }
}
