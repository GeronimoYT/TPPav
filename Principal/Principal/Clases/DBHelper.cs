using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Principal.Clases
{
    public class DBHelper
    {
        private string cadenaDeConexion;
        private static DBHelper instancia = new DBHelper();

        private DBHelper()
        {
            cadenaDeConexion = "Data Source=200.69.137.167,11333;Initial Catalog=PAV-3K2-10-AEROLINEA;User ID=PAV-3K2-10-USER;Password=77edc00a99fe";
        }

        public static DBHelper GetDBHelper()
        {
            if (instancia == null)
                instancia = new DBHelper();
            return instancia;
        }

        public DataTable ConsultaSQL(string strSql)
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            DataTable tabla = new DataTable();
            conn.ConnectionString = cadenaDeConexion;
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = strSql;
            tabla.Load(cmd.ExecuteReader());
            this.CloseConnection(conn);
            return tabla;
        }

        private void CloseConnection(SqlConnection conn)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
                conn.Dispose();
            }
        }
        /// Resumen:
        ///     Se utiliza para sentencias SQL del tipo “Insert/Update/Delete”. Recibe por valor una sentencia sql como string
        /// Devuelve:
        ///      un valor entero con el número de filas afectadas por la sentencia ejecutada
        public int EjecutarSQL(string strSql)
        {
            int afectadas = 0;
            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            cnn.ConnectionString = cadenaDeConexion;
            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = strSql;
            afectadas = cmd.ExecuteNonQuery();
            this.CloseConnection(cnn);
            return afectadas;
        }
    }
}
