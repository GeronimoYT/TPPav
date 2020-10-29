using Principal.Clases.Filtros;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Clases.Repositorio
{
    class PasajesRepositorio
    {
        public List<Pasaje> ObtenerPasajes(PasajesFiltros f)
        {
            List<Pasaje> pasajes = new List<Pasaje>();


            var sentenciaSql = "SELECT * FROM Pasaje pa join TipoPasaje tp on tp.IdTipoPasaje = pa.TipoPasaje, " +
                "Pasajero p join pa on p.NroDNI = pa.NroDNI" +
                "where(p.TipoDNI = pa.TipoDNI) and NroPasaje like '%%' ";
            if (f.TipoDocumento != "Seleccionar") { sentenciaSql += $" and p.tipoDocumento like '{f.TipoDocumento}%'"; }
            if (f.TipoPasajeId != 0) { sentenciaSql += $" AND pa.TipoPasaje = {f.TipoPasajeId}"; }
            if (!string.IsNullOrEmpty(f.NroDocumento)) { sentenciaSql += $" and p.nroDocumento like '%{f.NroDocumento}%'"; }

            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tabla.Rows)
            {
                var pasaje = Listar(fila);
                pasajes.Add(pasaje);

            }
            return pasajes;
        }

        private Pasaje Listar(DataRow fila)
        {
            var pasaje = new Pasaje();
            pasaje.Id = Convert.ToInt32(fila["NroPasaje"].ToString());
            pasaje.Motivo = fila["MotivoViaje"].ToString();
            //pasaje.Precio = Convert.ToInt32(fila["Precio"].ToString());
            pasaje.NroDocumento = new Pasajero()
            {
                TipoDocumento = fila["TipoDNI"].ToString(),
                NroDocumento = fila["NroDNI"].ToString(),
                Nombre = fila["Nombre"].ToString(),
                Apellido = fila["Apellido"].ToString(),
                Telefono = fila["Telefono"].ToString(),
                Email = fila["Mail"].ToString(),
                FechaNacimiento = Convert.ToDateTime(fila["FechaNacimiento"].ToString()),
            /*TipoDocumento = new TipoDocumento()
            {
                Id = fila["tipoDocumento"].ToString(),
                Descripcion = fila["descripcion"].ToString()
            }*/
        };
            //pasaje.TipoDocumento = pasaje.NroDocumento.TipoDocumento;
            pasaje.IdTipoPasaje = new TipoPasaje()
            {
                Id = Convert.ToInt32(fila["IdTipoPasaje"].ToString()),
                Detalle = fila["Desripcion"].ToString()
            };
            return pasaje;
        }
    }
}
