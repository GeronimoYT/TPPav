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
        public TipoDocumento TipoDocumento { get; set; }

        public string Motivo { get; set; }

        public int Precio { get; set; }

        //public EmbarqueV2 Embarque { get; set; }

        public Aeropuerto AeropuertoOrigen { get; set; }
        public Aeropuerto AeropuertoDestino { get; set; }

        public VueloV2 Vuelo { get; set; }


        public bool TienePrecio()
        {
            return Precio != 0;
        }

        public bool TieneMotivo()
        {
            return Motivo != null;
        }
        public void ValidarTipoClase()
        {
            if (IdTipoPasaje == null)
            {
                throw new ApplicationException("Debe seleccionar la Clase");
            }
            if (IdTipoPasaje.Detalle == "Seleccionar")
            {
                throw new ApplicationException("Debe seleccionar la Clase");
            }
        }
        public void ValidarNroDocumento()
        {
            if (NroDocumento == null )
                throw new ApplicationException("Debe seleccionar el Numero de Documento");
            
            if (NroDocumento.NroDocumento == "Seleccionar")
            {
                throw new ApplicationException("Debe seleccionar el Numero de Documento");
            }
        }
        public void ValidarTipoDocumento()
        {
            if (TipoDocumento == null )
            {
                throw new ApplicationException("Indetificacion por Documento Invalido");
            }
            if (TipoDocumento.Id == "Seleccionar")
            {
                throw new ApplicationException("Debe seleccionar el Tipo de Documento");
            }
        }
        public void CalcularPrecio() 
        {
            if(IdTipoPasaje.Id==1)
            {
                Precio = Vuelo.Minutos * 75;
            }
            if(IdTipoPasaje.Id == 2)
            {
                Precio = Vuelo.Minutos * 50;
            }
            
            
        }

    }
}
