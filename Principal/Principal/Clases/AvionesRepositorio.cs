using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.Data;

namespace Principal.Clases
{
    public class AvionesRepositorio
    {
        public List<Avion> ObtenerAviones()
        {
            List<Avion> aviones = new List<Avion>();
            var sentenciaSql = "SELECT * FROM Avion";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tabla.Rows)
            {
                var avion = new Avion();
                avion.numero = Convert.ToInt32(fila["NroAvion"].ToString());
                avion.idTipo = Convert.ToInt32(fila["IdTipoAvion"].ToString());
                avion.descripcion = fila["descripcion"].ToString();
                aviones.Add(avion);
            }
            return aviones;
        }
    }
}