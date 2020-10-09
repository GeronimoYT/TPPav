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
                pasajero.Telefono = fila["Telefono"].ToString();
                pasajero.Email = fila["Mail"].ToString();

                pasajeros.Add(pasajero);
            }
            return pasajeros;

        }
        public List<Pasajero> ObtenerPasajeros(string tipoDocumento, string nroDocumento, string apellido, string nombre, bool estado)
        {
            List<Pasajero> pasajeros = new List<Pasajero>();
            var sentenciaSql = "SELECT * FROM Pasajero where";
            if (!string.IsNullOrEmpty(tipoDocumento))
            {
                sentenciaSql += $" tipoDocumento like '{tipoDocumento}%'";
            }
            else { sentenciaSql += $" tipoDocumento like '%'"; }
            if (!string.IsNullOrEmpty(nroDocumento))
            {
                sentenciaSql += $" and nroDocumento like '{nroDocumento}%'";
            }
            else { sentenciaSql += $" and nroDocumento like '%'"; }
            if (!string.IsNullOrEmpty(apellido))
            {
                sentenciaSql += $" and apellido like '{apellido}%'";
            }
            else { sentenciaSql += $" and apellido like '%'"; }
            if (!string.IsNullOrEmpty(nombre))
            {
                sentenciaSql += $" and nombre like '{nombre}%'";
            }
            else { sentenciaSql += $" and nombre like '%'"; }
            if (!estado)
            { sentenciaSql += $" and estado like 'S'"; }
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tabla.Rows)
            {
                var pasajero = new Pasajero();
                pasajero.TipoDocumento = fila["tipoDocumento"].ToString();
                pasajero.NroDocumento = fila["nroDocumento"].ToString();
                pasajero.Apellido = fila["apellido"].ToString();
                pasajero.Nombre = fila["nombre"].ToString();
                pasajero.Telefono = fila["telefono"].ToString();
                pasajero.Email = fila["email"].ToString();

                pasajeros.Add(pasajero);
            }
            return pasajeros;
        }
        public int RegistrarPasajero(Pasajero pasajero)
        {
            var sentenciaSql = $"INSERT INTO Pasajero (tipoDocumento,nroDocumento ,apellido,nombre,telefono,email,estado)" +
                $" VALUES('{pasajero.TipoDocumento}', '{pasajero.NroDocumento}'," +
                $" '{pasajero.Apellido}', '{pasajero.Nombre}', '{pasajero.Telefono}', '{pasajero.Email}','S')";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            return filasAfectadas;
        }

        public Pasajero ObtenerPasajero(string tipoDoc, string nroDoc)
        {
            Pasajero pasajeroResultado = null;
            var sentenciaSql = $"SELECT * FROM Pasajero where tipoDocumento = '{tipoDoc}' and nroDocumento = '{nroDoc}'";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            if (tabla.Rows.Count == 1)
            {
                var row = tabla.Rows[0];
                var pasajeroBD = new Pasajero();
                var tipoDocumento = row["tipoDocumento"];
                var nrDocumento = row["nroDocumento"];
                pasajeroBD.TipoDocumento = tipoDocumento.ToString();
                pasajeroBD.NroDocumento = nrDocumento.ToString();
                pasajeroBD.Apellido = row["apellido"].ToString();
                pasajeroBD.Nombre = row["nombre"].ToString();
                pasajeroBD.Telefono = row["telefono"].ToString();
                pasajeroBD.Email = row["email"].ToString();
                return pasajeroBD;
            }
            return pasajeroResultado;
        }
        public int ActualizarPasajero(Pasajero _pasajero)
        {
            var sentenciaSql = $"UPDATE Pasajero SET apellido='{_pasajero.Apellido}', telefono='{_pasajero.Telefono}'," +
                $" email='{_pasajero.Email}' WHERE tipoDocumento='{_pasajero.TipoDocumento}'" +
                $" and nroDocumento='{_pasajero.NroDocumento}'";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            return filasAfectadas;
        }
        public int DarBajaPasajero(Pasajero _pasajero)
        {
            var sentenciaSql = $"UPDATE Pasajero SET estado='{_pasajero.EstadoABD()}' WHERE tipoDocumento='{_pasajero.TipoDocumento}'" +
                $" and nroDocumento='{_pasajero.NroDocumento}'";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            return filasAfectadas;
        }
    }
}
