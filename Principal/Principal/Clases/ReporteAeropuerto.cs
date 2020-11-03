using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Principal.Clases;

namespace Principal.Clases
{
    class ReporteAeropuerto
    {

        public static DataTable ObtenerAeropuertos()
        {
            string consulta = $"SELECT * FROM Aeropuerto";
            var resultado = DBHelper.GetDBHelper().ConsultaSQL(consulta);

            DataTable tabla = new DataTable();
            return tabla;
        }
    }
}
