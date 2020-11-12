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

        public List<Avion> ObtenerAviones(int categoria)
        {
            List<Avion> aviones = new List<Avion>();
            var sentenciaSql = "SELECT * FROM Avion";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tabla.Rows)
            {
                if (Convert.ToInt32(fila["IdTipoAvion"].ToString()) == categoria)
                {
                    Avion avion = ObtenerAvion(fila);
                    aviones.Add(avion);
                }               
            }
            return aviones;
        }

        public List<Avion> ObtenerAviones(int categoria, int numero)
        {
            List<Avion> aviones = new List<Avion>();
            var sentenciaSql = "SELECT * FROM Avion";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tabla.Rows)
            {
                if (Convert.ToInt32(fila["IdTipoAvion"].ToString()) == categoria && Convert.ToInt32(fila["NroAvion"].ToString()) == numero)
                {
                    Avion avion = ObtenerAvion(fila);
                    aviones.Add(avion);
                }
            }
            return aviones;
        }
        private Avion ObtenerAvion(DataRow fila) 
        {
            var avion = new Avion();
            avion.numero = Convert.ToInt32(fila["NroAvion"].ToString());
            avion.idTipo = Convert.ToInt32(fila["IdTipoAvion"].ToString());
            avion.descripcion = fila["descripcion"].ToString();
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
            catch(Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        public void BajaAvion(Avion avion)
        {
            try
            {
                var sentenciaSql = $"Delete from avion where NroAvion = '{avion.numero}'";
                DBHelper.GetDBHelper().ComandoSQL(sentenciaSql);
                MessageBox.Show("Baja Exitosa");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
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
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
                
    }
}