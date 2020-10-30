using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Clases.Repositorio
{
    class VuelosRepositorio
    {
        public List<Vuelo> Obtenervuelos()
        {
            List<Vuelo> vuelos = new List<Vuelo>();
            var sentenciaSql = "SELECT * FROM Vuelo";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tabla.Rows)
            {
                var vuelo = new Vuelo();
                vuelo.NroVuelo = Convert.ToInt32(fila["NroVuelo"].ToString());
                vuelo.FechaHoraSalida = Convert.ToDateTime(fila["FechaHoraSalida"].ToString());
                vuelo.FechaHoraLlegada = Convert.ToDateTime(fila["FechaHoraLlegada"].ToString());
                vuelo.NroAvion = Convert.ToInt32(fila["NroAvion"].ToString());
                vuelo.IdTipoAvion = fila["IdTipoAvion"].ToString();
                //vuelo.IdTipoAvion = Convert.ToInt32(fila["IdtipoAvion"].ToString());
                vuelo.IdAeropuerto = Convert.ToInt32(fila["IdAeropuerto"].ToString());
                vuelo.IdAeropuertoDestino = Convert.ToInt32(fila["IdAeropuertoDestino"].ToString());
                vuelo.Estado = Convert.ToInt32(fila["Estado"].ToString());

                vuelos.Add(vuelo);
            }
            return vuelos;

        }

    }
}
