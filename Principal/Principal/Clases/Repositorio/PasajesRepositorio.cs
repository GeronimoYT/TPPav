using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Clases.Repositorio
{
    class PasajesRepositorio
    {
        public List<Pasaje> ObtenerPasajes()
        {
            List<Pasaje> pasajes = new List<Pasaje>();
            var sentenciaSql = "SELECT * FROM Pasaje";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tabla.Rows)
            {
                var pasaje = new Pasaje();
                pasaje.Id = Convert.ToInt32(fila["NroPasaje"].ToString());
                pasaje.Precio = Convert.ToInt32(fila["Precio"].ToString());
                pasaje.Descripcion = fila["NroPasaje"].ToString();

                pasajes.Add(pasaje);
            }
            return pasajes;
        }
    }
}
