using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.Data;

namespace Principal.Clases.Repositorio
{
    class TipoEquipajeRepositorio
    {
        public List<TipoEquipaje> ObtenerTipos()
        {
            List<TipoEquipaje> tiposEquipaje = new List<TipoEquipaje>();
            var sentenciaSql = "SELECT * FROM TipoEquipaje";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tabla.Rows)
            {
                var tipo = new TipoEquipaje();
                tipo.id = Convert.ToInt32(fila["IdTipoEquipaje"].ToString());
                tipo.pesoMinimo = Convert.ToInt32(fila["PesoMinimo"].ToString());
                tipo.pesoMaximo = Convert.ToInt32(fila["PesoMaximo"].ToString());
                tipo.SetCategoria();

                tiposEquipaje.Add(tipo);
            }
            return tiposEquipaje;
        }

        public TipoEquipaje ObtenerTipo(int id)
        {
            TipoEquipaje tipoEquipaje = new TipoEquipaje();
            var sentenciaSql = $"SELECT * FROM TipoEquipaje WHERE IdTipoEquipaje = {id}";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tabla.Rows)
            {
                tipoEquipaje.id = Convert.ToInt32(fila["IdTipoEquipaje"].ToString());
                tipoEquipaje.pesoMinimo = Convert.ToInt32(fila["PesoMinimo"].ToString());
                tipoEquipaje.pesoMaximo = Convert.ToInt32(fila["PesoMaximo"].ToString());
                tipoEquipaje.SetCategoria();
            }
            return tipoEquipaje;
        }
    }
}
