using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.Data;

namespace Principal.Clases
{
    class TiposAvionRepositorio
    {
        public List<TipoAvion> ObtenerTipos()
        {
            List<TipoAvion> tiposAvion = new List<TipoAvion>();
            var sentenciaSql = "SELECT * FROM TipoAvion";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tabla.Rows)
            {
                var tipo = new TipoAvion();
                tipo.id = Convert.ToInt32(fila["IdTipoAvion"].ToString());
                tipo.descripcion = fila["DescripcionTipo"].ToString();
                tipo.capacidadEquipaje = Convert.ToInt32(fila["CapacidadKgEquip"].ToString());
                tipo.pasajerosClase1 = Convert.ToInt32(fila["CantidadPasajerosClase1"].ToString());
                tipo.pasajerosClase2 = Convert.ToInt32(fila["CantidadPasajerosClase2"].ToString());
                tipo.salidasEmergencia = Convert.ToInt32(fila["CantidadSalidasEmergencia"].ToString());
                tipo.longitud = Convert.ToInt32(fila["CapacidadKgEquip"].ToString());
                tipo.alcance = Convert.ToInt32(fila["AlcanceVuelo"].ToString());
                tiposAvion.Add(tipo);
            }
            return tiposAvion;
        }

    }
}