using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Clases.Repositorio
{
    class EmbarquesRepositorio
    {
        public List<Embarque> ObtenerEmbarques()
        {
            List<Embarque> embarbarques = new List<Embarque>();
            var sentenciaSql = "SELECT * FROM Embarque";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tabla.Rows)
            {
                var embarbarque = new Embarque();
                embarbarque.NroVuelo = fila["NroVuelo"].ToString();
                embarbarque.FechaHoraSalida = Convert.ToDateTime(fila["FechaHoraSalida "].ToString());
                embarbarque.FechaHoraLlegada = Convert.ToDateTime(fila["FechaHoraLlegada"].ToString());
                embarbarque.NroAvion = Convert.ToInt32(fila["NroAvion"].ToString());
                embarbarque.IdAeropuerto = Convert.ToInt32(fila["IdAeropuerto"].ToString());
                embarbarque.PuertaEmbarque = Convert.ToInt32(fila["PuertaEmbarque"].ToString());

                embarbarques.Add(embarbarque);
            }
            return embarbarques;

        }
    }
}
