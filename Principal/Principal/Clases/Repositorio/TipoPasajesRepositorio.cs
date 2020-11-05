using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Clases.Repositorio
{
    class TipoPasajesRepositorio
    {
        public List<TipoPasaje> ObtenerTipoPasajes()
        {
            List<TipoPasaje> tipoPasajes = new List<TipoPasaje>();
            var sentenciaSql = "SELECT * FROM TipoPasaje";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tabla.Rows)
            {
                var tipoPasaje = new TipoPasaje();
                tipoPasaje.Id = Convert.ToInt32(fila["IdTipoPasaje"].ToString());
                tipoPasaje.Detalle = fila["Descripcion"].ToString();

                tipoPasajes.Add(tipoPasaje);

            }
            return tipoPasajes;
        }
    }
}
