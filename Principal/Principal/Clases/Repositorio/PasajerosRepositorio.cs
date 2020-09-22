using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Clases.Repositorio
{
    class PasajerosRepositorio
    {
        public List<Pasajero> ObtenerPasajeros()
        {
            List<Pasajero> pasajeros = new List<Pasajero>();
            var sentenciaSql = "SELECT * FROM Pasajero";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tabla.Rows)
            {
                var pasajero = new Pasajero();
                pasajero.TipoDocumento = fila["TipoDNI"].ToString();
                pasajero.NroDocumento = fila["NroDNI"].ToString();
                pasajero.NroTelefono = fila["Telefono"].ToString();
                pasajero.Mail = fila["Mail"].ToString();

                pasajeros.Add(pasajero);
            }
            return pasajeros;

        }
    }
}
