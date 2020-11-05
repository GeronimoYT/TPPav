using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Clases.Filtros
{
    public class VuelosFiltros //5 filtros 5 combobox
    {
        public DateTime? FechaDesde { get; set; }
        public DateTime? FechaHasta { get; set; }
        public long NroAvion { get; set; }
        public long IdAeropuerto { get; set; }
        public long IdAeropuertoDestino { get; set; }
        public long IdEstado { get; set; }
        
    }
}
