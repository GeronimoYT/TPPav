using Principal._PAV_3K2_10_AEROLINEADataSetTableAdapters;
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
        //yo no la utilizo no sé si se utiliza en Embarque o Equipaje
        public List<Pasajero> ObtenerPasajeros()
        {
            List<Pasajero> pasajeros = new List<Pasajero>();
            var sentenciaSql = "SELECT * FROM Pasajero where Estado like 'S'";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tabla.Rows)
            {
                var pasajero = new Pasajero();
                if (fila["tipoDocumento"].GetType() != typeof(DBNull))
                    pasajero.TipoDocumento = new TipoDocumento()
                    {
                        Id = fila["tipoDocumento"].ToString(),
                        //Descripcion = fila["descripcion"].ToString()
                    };
                pasajero.NroDocumento = fila["NroDNI"].ToString();
                pasajero.Nombre = fila["Nombre"].ToString();
                pasajero.Apellido = fila["Apellido"].ToString();
                pasajero.Telefono = fila["Telefono"].ToString();
                pasajero.Email = fila["Mail"].ToString();
                pasajero.FechaNacimiento = Convert.ToDateTime(fila["FechaNacimiento"].ToString());
                
                pasajeros.Add(pasajero);
            }
            return pasajeros;

        }
        //se utliza en el formPasajeros
        public List<Pasajero> ObtenerPasajeros(string tipoDocumento, string nroDocumento, string apellido, string nombre, bool estado)
        {
            List<Pasajero> pasajeros = new List<Pasajero>();
            var sentenciaSql = "SELECT * FROM Pasajero where";
            if (!string.IsNullOrEmpty(tipoDocumento))
            {
                if (tipoDocumento == "Seleccionar") { sentenciaSql += $" TipoDNI like '%'"; }
                else { sentenciaSql += $" TipoDNI like '{tipoDocumento}%'"; }
            }
            else { sentenciaSql += $" TipoDNI like '%'"; }

            if (!string.IsNullOrEmpty(nroDocumento))
            {
                sentenciaSql += $" and NroDNI like '%{nroDocumento}'";
            }
            if (!string.IsNullOrEmpty(apellido))
            {
                sentenciaSql += $" and Apellido like '{apellido}%'";
            }
            if (!string.IsNullOrEmpty(nombre))
            {
                sentenciaSql += $" and Nombre like '{nombre}%'";
            }
            if (!estado)
            { sentenciaSql += $" and Estado like 'S'"; }
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tabla.Rows)
            {
                var pasajero = new Pasajero();
                
                pasajero.NroDocumento = fila["NroDNI"].ToString();
                pasajero.Nombre = fila["Nombre"].ToString();
                pasajero.Apellido = fila["Apellido"].ToString();
                pasajero.Telefono = fila["Telefono"].ToString();
                pasajero.Email = fila["Mail"].ToString();
                pasajero.FechaNacimiento = Convert.ToDateTime(fila["FechaNacimiento"].ToString());
                if (fila["TipoDNI"].GetType() != typeof(DBNull))
                    pasajero.TipoDocumento = new TipoDocumento()
                    {
                        Id = fila["TipoDNI"].ToString(),
                        //Descripcion = fila["Descripcion"].ToString(),
                    };

                pasajeros.Add(pasajero);
            }
            return pasajeros;
        }
        public int RegistrarPasajero(Pasajero pasajero)
        {
            var sentenciaSql = $"INSERT INTO Pasajero (TipoDNI,NroDNI,Apellido,Nombre,Telefono,Mail,Estado,FechaNacimiento)" +
                $" VALUES('{pasajero.TipoDocumento.Id}', '{pasajero.NroDocumento}'," +
                $" '{pasajero.Apellido}', '{pasajero.Nombre}', '{pasajero.Telefono}', '{pasajero.Email}','S','{pasajero.FechaNacimiento}')";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            return filasAfectadas;
        }
        //Se usa en formEditarPasajero y formBajaPasajero
        public Pasajero ObtenerPasajero(string tipoDoc, string nroDoc)
        {
            Pasajero pasajeroResultado = null;
            var sentenciaSql = $"SELECT * FROM Pasajero where NroDNI = '{nroDoc}' and TipoDNI = '{tipoDoc}'";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            if (tabla.Rows.Count == 1)
            {
                var row = tabla.Rows[0];
                var pasajeroBD = new Pasajero();
                var tipoDocumento = row["TipoDNI"];
                var nrDocumento = row["NroDNI"];
                
                pasajeroBD.NroDocumento = nrDocumento.ToString();
                pasajeroBD.Apellido = row["Apellido"].ToString();
                pasajeroBD.Nombre = row["Nombre"].ToString();
                pasajeroBD.Telefono = row["Telefono"].ToString();
                pasajeroBD.Email = row["Mail"].ToString();
                pasajeroBD.FechaNacimiento = Convert.ToDateTime(row["FechaNacimiento"].ToString());
                //pasajeroBD.Estado = Convert.ToBoolean(row["Estado"].ToString());

                var _tipoDocumento = new TipoDocumento();
                _tipoDocumento.Id = tipoDocumento.ToString();
                //_tipoDocumento.Descripcion = row["Descripcion"].ToString();
                pasajeroBD.TipoDocumento = _tipoDocumento;
                return pasajeroBD;
            }
            return pasajeroResultado;
        }
        //se utiliza en el formAltaPasaje
        public List<Pasajero> ObtenerPasajeros(string tipoDoc, bool registro)
        {
            List<Pasajero> pasajeros = new List<Pasajero>();

            var sentenciaSql = $"SELECT * FROM Pasajero p JOIN TipoDocumento tp On p.TipoDNI=tp.TipoDNI" +
                $" where  ";
            if (registro) { sentenciaSql += $"Estado like 'S'"; } else { sentenciaSql += "Estado like '%%'"; }
            if (tipoDoc != "Seleccionar") sentenciaSql += $" and p.TipoDNI = '{tipoDoc}'";
                  

            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tabla.Rows)
            {
                var pasajero = new Pasajero();

                pasajero.NroDocumento = fila["NroDNI"].ToString();
                pasajero.Apellido = fila["Apellido"].ToString();
                pasajero.Nombre = fila["Nombre"].ToString();
                pasajero.Telefono = fila["Telefono"].ToString();
                pasajero.Email = fila["Mail"].ToString();
                pasajero.FechaNacimiento = Convert.ToDateTime(fila["FechaNacimiento"].ToString());
                if (fila["TipoDNI"].GetType() != typeof(DBNull))
                    pasajero.TipoDocumento = new TipoDocumento()
                    {
                        Id = fila["TipoDNI"].ToString(),
                        //Descripcion = fila["descripcion"].ToString()
                    };
                
                pasajeros.Add(pasajero);
            }
            return pasajeros;
        }
        public int ActualizarPasajero(Pasajero _pasajero)
        {
            var sentenciaSql = $"UPDATE Pasajero SET Nombre='{_pasajero.Nombre}', Apellido='{_pasajero.Apellido}', Telefono='{_pasajero.Telefono}'," +
                $" Mail='{_pasajero.Email}' WHERE NroDNI ='{_pasajero.NroDocumento}' and TipoDNI='{_pasajero.TipoDocumento.Id}'";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            return filasAfectadas;
        }
        public int DarBajaPasajero(Pasajero _pasajero)
        {
            var sentenciaSql = $"UPDATE Pasajero SET Estado='{_pasajero.EstadoABD()}' WHERE NroDNI = '{_pasajero.NroDocumento}'" +
                $" and TipoDNI='{_pasajero.TipoDocumento.Id}'";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            return filasAfectadas;
        }
    }
}
