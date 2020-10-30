using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.Windows.Forms;
using System.Data;

namespace Principal.Clases.Repositorio
{
    class EquipajeRepositorio
    {
        public List<Equipaje> ObtenerEquipajes()
        {
            List<Equipaje> equipajes = new List<Equipaje>();
            var sentenciaSql = "SELECT * FROM Equipaje";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tabla.Rows)
            {
                var equipaje = new Equipaje();
                equipaje.numero = Convert.ToInt32(fila["NroEquipaje"].ToString());
                equipaje.descripcion = fila["DescripcionTipo"].ToString();
                equipaje.tipo = Convert.ToInt32(fila["TipoEquipaje"].ToString());
                equipaje.tipoDNI = fila["TipoDNIPasajero"].ToString();
                equipaje.DNI = fila["NroDNIPasajero"].ToString();
                equipajes.Add(equipaje);
            }
            return equipajes;
        }

        public List<Equipaje> ObtenerEquipajesPasajero(Pasajero pasajero)
        {
            List<Equipaje> equipajes = new List<Equipaje>();
            var sentenciaSql =  $"SELECT * FROM Equipaje" +
                                $"WHERE TipoDNIPasajero = {pasajero.TipoDocumento}" +
                                $"AND NroDNIPasajero = {pasajero.NroDocumento}";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tabla.Rows)
            {
                var equipaje = new Equipaje();
                equipaje.numero = Convert.ToInt32(fila["NroEquipaje"].ToString());
                equipaje.descripcion = fila["DescripcionTipo"].ToString();
                equipaje.tipo = Convert.ToInt32(fila["TipoEquipaje"].ToString());
                equipaje.tipoDNI = fila["TipoDNIPasajero"].ToString();
                equipaje.DNI = fila["NroDNIPasajero"].ToString();
                equipajes.Add(equipaje);
            }
            return equipajes;
        }

        public void Altaequipaje(Equipaje equipaje)
        {
            try
            {
                var sentenciaSql = $"INSERT INTO Equipaje (NroEquipaje, TipoEquipaje, Descripcion, TipoDNIPasajero, NroDNIPasajero) " +
                                  $"VALUES ({equipaje.numero}, {equipaje.tipo}, '{equipaje.descripcion}', {equipaje.tipoDNI}, {equipaje.DNI} )";
                DBHelper.GetDBHelper().ComandoSQL(sentenciaSql);
                MessageBox.Show("Registro Exitoso");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        public void BajaEquipaje(Equipaje equipaje)
        {
            try
            {
                var sentenciaSql = $"DELETE FROM Equipaje WHERE NroEquipaje = {equipaje.numero}";
                DBHelper.GetDBHelper().ComandoSQL(sentenciaSql);
                MessageBox.Show("Eliminacion Exitosa");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        public void ModificacionEquipaje(Equipaje equipaje)
        {
            try
            {
                var sentenciaSql =  $"Update Avion set TipoEquipaje = {equipaje.tipo}, Descripcion = '{equipaje.descripcion}', " +
                                    $"TipoDNIPasajero = {equipaje.tipoDNI}, NroDNIPasajero = {equipaje.DNI}" +
                                    $"WHERE NroAvion = '{equipaje.numero}'";
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
