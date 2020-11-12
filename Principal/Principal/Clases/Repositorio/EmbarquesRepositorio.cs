using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Clases.Repositorio
{
    class EmbarquesRepositorio
    {
        public List<Embarque> ObtenerEmbarques()
        {
            List<Embarque> embarques = new List<Embarque>();
            var sentenciaSql = "SELECT DISTINCT PuertaEmbarque FROM Embarque";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tabla.Rows)
            {
                var embarque = new Embarque();
                embarque.PuertaEmbarque = Convert.ToInt32(fila["PuertaEmbarque"].ToString());

                embarques.Add(embarque);
            }
            return embarques;
        }
        public List<EmbarqueV2> ObtenerEmbarquesV2(string Origen, string Destino)
        {
            List<EmbarqueV2> embarques = new List<EmbarqueV2>();
            var sentenciaSql = "Select em.FechaHoraEmbarque,em.PuertaEmbarque," +
                " em.IdEstado as IdEstadoEmbarque, eem.NombreEstado as EstadoEmbarque," +
                "v.NroVuelo,v.FechaHoraSalida,v.FechaHoraLlegada," +
                "datediff(MINUTE, v.FechaHoraSalida, v.FechaHoraLlegada) / 60 as DuracionHorasVuelo," +
                "ao.Nombre as AeropuertoOrigen,ao.Domicilio as Origen,ao.IdAeropuerto as IdAeropuertoOrigen," +
                "ad.Nombre as AeropuertoDestino,ad.Domicilio as Destino,ad.IdAeropuerto as IdAeropuertoDestino," +
                "ev.IdEstado as IdEstadoVuelo, ev.NombreEstado as EstadoVuelo , v.NroAvion,v.IdTipoAvion " +
                "from Vuelo v join Embarque em on (em.NroVuelo=v.NroVuelo) " +
                "join Estado ev on (v.Estado=ev.IdEstado) " +
                "join Estado eem on (em.IdEstado = eem.IdEstado) " +
                "join Ambito am on ev.Ambito=am.IdAmbito " +
                "join Aeropuerto ao on (v.IdAeropuerto=ao.IdAeropuerto) " +
                "join Aeropuerto ad on (v.IdAeropuertoDestino=ad.IdAeropuerto) " +
                "join Avion av on (v.IdTipoAvion=av.IdTipoAvion and v.NroAvion=av.NroAvion) " +
                "join TipoAvion ta on (av.IdTipoAvion=ta.IdTipoAvion) " +
                "where em.TipoDNIPasajero like '%%' ";
            if (Origen != "Seleccionar") { sentenciaSql += $"and ao.Domicilio like '{Origen}' "; }
            if (Destino != "Seleccionar") { sentenciaSql += $"and ad.Domicilio like '{Destino}'"; }
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tabla.Rows)
            {
                var embarque = new EmbarqueV2();
                embarque.PuertaEmbarque = Convert.ToInt32(fila["PuertaEmbarque"].ToString());
                
                embarque.FechaHoraEmbarque = Convert.ToDateTime(fila["FechaHoraEmbarque"].ToString());
                embarque.Vuelo = new VueloV2();
                embarque.Vuelo.NroVuelo = Convert.ToInt32(fila["NroVuelo"].ToString());
                embarque.Vuelo.FechaHoraSalida = Convert.ToDateTime(fila["FechaHoraSalida"].ToString());
                embarque.Vuelo.FechaHoraLlegada = Convert.ToDateTime(fila["FechaHoraLlegada"].ToString());
                embarque.Vuelo.IdAeropuerto = new Aeropuerto();
                embarque.Vuelo.IdAeropuerto.IdAeropuerto = Convert.ToInt32(fila["IdAeropuertoOrigen"].ToString());
                embarque.Vuelo.IdAeropuerto.Nombre = fila["AeropuertoOrigen"].ToString();
                embarque.Vuelo.IdAeropuerto.Domicilio = fila["Origen"].ToString();
                embarque.Vuelo.IdAeropuertoDestino = new Aeropuerto();
                embarque.Vuelo.IdAeropuertoDestino.IdAeropuerto = Convert.ToInt32(fila["IdAeropuertoDestino"].ToString());
                embarque.Vuelo.IdAeropuertoDestino.Nombre = fila["AeropuertoDestino"].ToString();
                embarque.Vuelo.IdAeropuertoDestino.Domicilio = fila["Destino"].ToString();
                embarque.Vuelo.Estado = new Estado();
                embarque.Vuelo.Estado.IdEstado = Convert.ToInt32(fila["IdEstadoVuelo"].ToString());
                embarque.Vuelo.Estado.NombreEstado = fila["EstadoVuelo"].ToString();
                embarque.Vuelo.NroAvion = Convert.ToInt32(fila["NroAvion"].ToString());
                embarque.Vuelo.IdTipoAvion = Convert.ToInt32(fila["IdTipoAvion"].ToString());

                embarque.Estado = new Estado();
                embarque.Estado.IdEstado = Convert.ToInt32(fila["IdEstadoEmbarque"].ToString());
                embarque.Estado.NombreEstado = fila["EstadoEmbarque"].ToString();
                embarques.Add(embarque);
            }
            return embarques;
        }

    }
}
