using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Clases.Repositorio
{
    class EstadosRepositorio
    {
        public List<Estado> ObtenerEstados()
        {
            List<Estado> estados = new List<Estado>();
            var sentenciaSql = "SELECT * FROM Estado";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tabla.Rows)
            {
                var estado = new Estado();
                

                estados.Add(estado);
            }
            return estados;
        }
    }
}
