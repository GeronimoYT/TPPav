﻿using System;
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
                pasajero.Nombre = fila["Nombre"].ToString();
                pasajero.Apellido = fila["Apellido"].ToString();
                pasajero.Telefono = fila["Telefono"].ToString();
                pasajero.Email = fila["Mail"].ToString();
                pasajero.FechaNacimiento = Convert.ToDateTime(fila["FechaNacimiento"].ToString());

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
                if (tipoDocumento == "Seleccionar") { sentenciaSql += $" TipoDNI like '%'"; }
                else { sentenciaSql += $" TipoDNI like '{tipoDocumento}%'"; }
            }
            else { sentenciaSql += $" TipoDNI like '%'"; }

            if (!string.IsNullOrEmpty(nroDocumento))
            {
                sentenciaSql += $" NroDNI like '{nroDocumento}%'";
            }
            else { sentenciaSql += $" NroDNI like '%'"; }
            if (!string.IsNullOrEmpty(apellido))
            {
                sentenciaSql += $" and Apellido like '{apellido}%'";
            }
            else { sentenciaSql += $" and Apellido like '%'"; }
            if (!string.IsNullOrEmpty(nombre))
            {
                sentenciaSql += $" and Nombre like '{nombre}%'";
            }
            else { sentenciaSql += $" and Nombre like '%'"; }
            if (!estado)
            { sentenciaSql += $" and Estado like 'S'"; }
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tabla.Rows)
            {
                var pasajero = new Pasajero();
                pasajero.TipoDocumento = fila["TipoDNI"].ToString();
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
        public int RegistrarPasajero(Pasajero pasajero)
        {
            var sentenciaSql = $"INSERT INTO Pasajero (TipoDNI,NroDNI,Apellido,Nombre,Telefono,Mail,Estado,FechaNacimiento)" +
                $" VALUES('{pasajero.TipoDocumento}', '{pasajero.NroDocumento}'," +
                $" '{pasajero.Apellido}', '{pasajero.Nombre}', '{pasajero.Telefono}', '{pasajero.Email}','S','{pasajero.FechaNacimiento}')";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            return filasAfectadas;
        }

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
                pasajeroBD.TipoDocumento = tipoDocumento.ToString();
                pasajeroBD.NroDocumento = nrDocumento.ToString();
                pasajeroBD.Apellido = row["Apellido"].ToString();
                pasajeroBD.Nombre = row["Nombre"].ToString();
                pasajeroBD.Telefono = row["Telefono"].ToString();
                pasajeroBD.Email = row["Mail"].ToString();
                pasajeroBD.FechaNacimiento = Convert.ToDateTime(row["FechaNacimiento"].ToString());
                return pasajeroBD;
            }
            return pasajeroResultado;
        }
        public int ActualizarPasajero(Pasajero _pasajero)
        {
            var sentenciaSql = $"UPDATE Pasajero SET Apellido='{_pasajero.Apellido}', Telefono='{_pasajero.Telefono}'," +
                $" Mail='{_pasajero.Email}' WHERE NroDNI ='{_pasajero.NroDocumento}' and TipoDNI='{_pasajero.TipoDocumento}'";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            return filasAfectadas;
        }
        public int DarBajaPasajero(Pasajero _pasajero)
        {
            var sentenciaSql = $"UPDATE Pasajero SET Estado='{_pasajero.EstadoABD()}' WHERE TipoDNI='{_pasajero.TipoDocumento}'" +
                $" and NroDNI = '{_pasajero.NroDocumento}'";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            return filasAfectadas;
        }
    }
}
