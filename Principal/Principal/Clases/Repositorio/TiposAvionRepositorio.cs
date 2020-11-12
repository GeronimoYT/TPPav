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
    class TiposAvionRepositorio
    {
        public List<TipoAvion> ObtenerTipos()
        {
            List<TipoAvion> tiposAvion = new List<TipoAvion>();
            var sentenciaSql = "SELECT * FROM TipoAvion";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tabla.Rows)
            {
                tiposAvion.Add(ObtenerTipo(fila));
            }
            return tiposAvion;
        }

        public List<TipoAvion> ObtenerTiposActivos()
        {
            List<TipoAvion> tiposAvion = new List<TipoAvion>();
            var sentenciaSql = "SELECT * FROM TipoAvion WHERE Estado = 'S'";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tabla.Rows)
            {
                tiposAvion.Add(ObtenerTipo(fila));
            }
            return tiposAvion;
        }

        private TipoAvion ObtenerTipo(DataRow fila)
        {
            var tipo = new TipoAvion();
            tipo.id = Convert.ToInt32(fila["IdTipoAvion"].ToString());
            tipo.descripcion = fila["DescripcionTipo"].ToString();
            tipo.capacidadEquipaje = Convert.ToInt32(fila["CapacidadKgEquip"].ToString());
            tipo.pasajerosClase1 = Convert.ToInt32(fila["CantidadPasajerosClase1"].ToString());
            tipo.pasajerosClase2 = Convert.ToInt32(fila["CantidadPasajerosClase2"].ToString());
            tipo.salidasEmergencia = Convert.ToInt32(fila["CantidadSalidasEmergencia"].ToString());
            tipo.longitud = Convert.ToSingle(fila["Longitud"].ToString());
            tipo.alcance = Convert.ToInt32(fila["AlcanceVuelo"].ToString());
            tipo.estado = fila["Estado"].ToString();

            return tipo;
        }
        public void AltaTipo(TipoAvion tipo)
        {
            try
            {
                var sentenciaSql = $"INSERT INTO TipoAvion (DescripcionTipo, Longitud, AlcanceVuelo, CantidadPasajerosClase1," +
                                    $" CantidadPasajerosClase2, CapacidadKgEquip, CantidadSalidasEmergencia) " +
                                    $"VALUES ('{tipo.descripcion}', {tipo.longitud}, {tipo.alcance}, {tipo.pasajerosClase1}," +
                                    $" {tipo.pasajerosClase2}, {tipo.capacidadEquipaje}, {tipo.salidasEmergencia})";

                DBHelper.GetDBHelper().ComandoSQL(sentenciaSql);
                MessageBox.Show("Alta Exitosa");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        public void BajaTipo(TipoAvion tipo)
        {
            try
            {
                if (AvionesxTipo(tipo))
                {
                    var sentenciaSql = $"UPDATE TipoAvion SET Estado = '{tipo.estado}' WHERE IdTipoAvion = {tipo.id}";
                    DBHelper.GetDBHelper().ComandoSQL(sentenciaSql);
                    MessageBox.Show("Baja Exitosa");
                }
                else { MessageBox.Show("No se puede realizar la operacion, existen aviones activos de este tipo;"); }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        public void ModificacionTipo(TipoAvion tipo)
        {
            try
            {
                var sentenciaSql = $"Update TipoAvion " +
                                    $"Set DescripcionTipo = '{tipo.descripcion}', Longitud = {tipo.longitud}, AlcanceVuelo = {tipo.alcance}, " +
                                    $"CantidadPasajerosClase1 = {tipo.pasajerosClase1}, CantidadPasajerosClase2 = {tipo.pasajerosClase2}, " +
                                    $"CapacidadKgEquip = {tipo.capacidadEquipaje}, CantidadSalidasEmergencia = {tipo.salidasEmergencia} " +
                                    $"where IdTipoAvion = {tipo.id}";
                DBHelper.GetDBHelper().ComandoSQL(sentenciaSql);
                MessageBox.Show("Modificacion Exitosa");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }
        public bool AvionesxTipo(TipoAvion tipo)
        {
            var sentenciaSql = $"SELECT COUNT(NroAvion) AS Cantidad FROM Avion WHERE IdTipoAvion = {tipo.id} AND Estado = 'S'";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            string celda = "";
            foreach (DataRow fila in tabla.Rows)
            {
                celda = fila["Cantidad"].ToString();
            }
            if (celda == "0") { return true; }
            else { return false; }
        }
            
    }
}