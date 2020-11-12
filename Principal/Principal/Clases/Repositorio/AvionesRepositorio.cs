using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.Data;
using System.Windows.Forms;

namespace Principal.Clases
{
    public class AvionesRepositorio
    {
        public List<Avion> ObtenerAviones()
        {
            List<Avion> aviones = new List<Avion>();
            var sentenciaSql = "SELECT * FROM Avion";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tabla.Rows)
            {
                Avion avion = ObtenerAvion(fila);
                aviones.Add(avion);
            }
            return aviones;
        }

        public List<Avion> ObtenerAvionesActivos()
        {
            List<Avion> aviones = new List<Avion>();
            var sentenciaSql = "SELECT * FROM Avion WHERE Estado = 'S'";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tabla.Rows)
            {
                Avion avion = ObtenerAvion(fila);
                aviones.Add(avion);
            }
            return aviones;
        }


        private Avion ObtenerAvion(DataRow fila)
        {
            var avion = new Avion();
            avion.numero = Convert.ToInt32(fila["NroAvion"].ToString());
            avion.idTipo = Convert.ToInt32(fila["IdTipoAvion"].ToString());
            avion.descripcion = fila["descripcion"].ToString();

            string estado = fila["Estado"].ToString();
            if (estado == "S") { avion.estado = true; }
            else { avion.estado = false; }

            return avion;
        }

        public void AltaAvion(Avion avion)
        {
            try
            {
                var sentenciaSql = $"INSERT INTO Avion (NroAvion, IdTipoAvion, Descripcion) " +
                                  $"VALUES ({avion.numero}, {avion.idTipo}, '{avion.descripcion}')";
                DBHelper.GetDBHelper().ComandoSQL(sentenciaSql);
                MessageBox.Show("Alta Exitosa");
            }
            catch (Exception ex)
            {
                if (ex.HResult.ToString() == "-2146232060") { MessageBox.Show($"Error, ya existe un avion con este nro y tipo de avion."); }
                else { MessageBox.Show($"Error: {ex.HResult} = {ex.Message}"); }
            }
        }

        public void BajaAvion(Avion avion)
        {
            try
            {
                string estado = "";
                if (avion.estado) { estado = "S"; }
                else { estado = "N"; }
                var sentenciaSql = $"UPDATE Avion SET Estado = '{estado}' WHERE NroAvion = '{avion.numero}' AND IdTipoAvion = '{avion.idTipo}'";
                DBHelper.GetDBHelper().ComandoSQL(sentenciaSql);
                MessageBox.Show("Estado actualizado con exito");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.HResult} = {ex.Message}");
            }
        }

        public void ModificacionAvion(Avion avion)
        {
            try
            {
                var sentenciaSql = $"Update Avion set IdTipoAvion = '{avion.idTipo}', Descripcion = '{avion.descripcion}' where NroAvion = '{avion.numero}'";
                DBHelper.GetDBHelper().ComandoSQL(sentenciaSql);
                MessageBox.Show("Modificacion Exitosa");
            }
            catch (Exception ex)
            {
                if (ex.HResult.ToString() == "-2146232060") { MessageBox.Show($"Error, no se puede modificar la categoria mientras el avion este asignado a un vuelo."); }
                else { MessageBox.Show($"Error: {ex.HResult} = {ex.Message}"); }
            }
        }



    }
}

