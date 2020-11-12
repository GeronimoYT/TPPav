using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Clases.Repositorio
{
    class AeropuertosRepositorio
    {
        public List<Aeropuerto> ObtenerAeropuertos()
        {
            List<Aeropuerto> Aeropuertos = new List<Aeropuerto>();
            var sentenciaSql = "SELECT DISTINCT a.IdAeropuerto,a.Nombre,a.Domicilio FROM Aeropuerto a";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tabla.Rows)
            {
                var Aeropuerto = new Aeropuerto();
                Aeropuerto.IdAeropuerto = Convert.ToInt32(fila["IdAeropuerto"].ToString());
                Aeropuerto.Nombre = fila["Nombre"].ToString();
                Aeropuerto.Domicilio = fila["Domicilio"].ToString();

                Aeropuertos.Add(Aeropuerto);
            }
            return Aeropuertos;
        }
    }
}
