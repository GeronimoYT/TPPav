using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Clases.Filtros
{
    public class PasajesFiltros
    {

        public int Id { get; set; }
        public string NroDocumento { get; set; }

        public string TipoDocumento { get; set; }

        public int TipoPasajeId { get; set; }

        public int IdAeropuertoOrigen { get; set; }
        public int IdAeropuertoDestino { get; set; }
        
        //cuidado cambie Orifen y Destino de tipo int a  string
        public string Origen { get; set; }
        public string Destino { get; set; }

        public int PuertaEmbarque { get; set; }

    }
}
