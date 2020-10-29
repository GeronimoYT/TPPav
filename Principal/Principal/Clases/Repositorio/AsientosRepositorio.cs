using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.Data;
using System.Windows.Forms;

namespace Principal.Clases.Repositorio
{
    class AsientosRepositorio
    {
        public List<Asiento> ObtenerAsientos(Avion avion)
        {
            List<Asiento> asientos = new List<Asiento>();
            var sentenciaSql = $"SELECT * FROM Asientos WHERE NroAvion = {avion.numero} AND TipoAvion = {avion.idTipo}";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tabla.Rows)
            {
                var asiento = new Asiento();
                asiento.numero = Convert.ToInt32(fila["Numero"].ToString());
                asiento.nroAvion = Convert.ToInt32(fila["NroAvion"].ToString());
                asiento.tipoAvion = Convert.ToInt32(fila["TipoAvion"].ToString());
                asiento.fila = Convert.ToInt32(fila["Fila"].ToString());
                asiento.columna = Convert.ToInt32(fila["Columna"].ToString());
                asiento.ubicacion = Convert.ToChar(fila["Ubicacion"].ToString());
                asiento.estado = Convert.ToChar(fila["Estado"].ToString());
                asiento.clase = Convert.ToInt32(fila["Clase"].ToString());
                asientos.Add(asiento);
            }
            return asientos;
        }

        public void AltaAsiento(Asiento asiento)
        {
            try
            {
                var sentenciaSql = $"INSERT INTO Asientos (Numero, NroAvion, TipoAvion, Fila, Columna, Ubicacion, Estado, Clase)" +
                               $"VALUES ({asiento.numero}, {asiento.nroAvion}, {asiento.tipoAvion}, {asiento.fila}," +
                               $"{asiento.columna}, '{asiento.ubicacion}', '{asiento.estado}', {asiento.clase})";
                DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
                MessageBox.Show("Creacion Exitosa");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        public void BajaAsiento(Asiento asiento)
        {
            try
            {
                var sentenciaSql = $"DELETE FROM Asientos" +
                                   $"WHERE Numero = {asiento.numero} AND NroAvion = {asiento.nroAvion} AND {asiento.tipoAvion}";
               DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
                MessageBox.Show("Eliminicion Exitosa");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        public void ModificacionAsiento(Asiento asiento)
        {
            try
            {
                var sentenciaSql = $"UPDATE Asientos SET Estado = {asiento.estado}" +
                                   $"WHERE Numero = {asiento.numero} AND NroAvion = {asiento.nroAvion} AND {asiento.tipoAvion}";
                DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
                MessageBox.Show("Actualizacion Exitosa");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
