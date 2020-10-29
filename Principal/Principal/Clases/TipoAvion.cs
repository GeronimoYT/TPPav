using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Clases
{
   public class TipoAvion
    {
        public TipoAvion()
        {
        }

        public TipoAvion(int id, string descripcion, int equipaje, int pasajeros1, int pasajeros2, int emergencia, int longitud,int alcance)
        {
            this.id = id;
            this.descripcion = descripcion;
            this.capacidadEquipaje = equipaje;
            this.pasajerosClase1 = pasajeros1;
            this.pasajerosClase2 = pasajeros2;
            this.salidasEmergencia = emergencia;
            this.longitud = longitud;
            this.alcance = alcance;
        }

        public int id { get; set; }
        public string descripcion { get; set; }
        public int capacidadEquipaje { get; set; }
        public int pasajerosClase1 { get; set; }
        public int pasajerosClase2 { get; set; }
        public int salidasEmergencia { get; set; }
        public float longitud { get; set; }
        public int alcance { get; set; }
    }
}
