using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Clases.Repositorio
{
    class TipoDocumentosRepositorio
    {
        public List<TipoDocumento> ObtenerTipoDocumentos()
        {
            List<TipoDocumento> tipoDocumentos = new List<TipoDocumento>();
            var sentenciaSql = "SELECT * FROM TipoDocumento";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tabla.Rows)
            {
                var tipoDocumento = new TipoDocumento();
                tipoDocumento.Id = fila["TipoDNI"].ToString();
                tipoDocumento.Descripcion = fila["Descripcion"].ToString();
                tipoDocumentos.Add(tipoDocumento);
            }
            return tipoDocumentos;
        }
    }
}
