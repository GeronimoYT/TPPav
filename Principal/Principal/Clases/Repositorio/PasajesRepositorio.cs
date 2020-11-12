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


            
            var sentenciaSql = "select DISTINCT pa.NroPasaje,pa.MotivoViaje,pa.Precio,tp.*,p.*," +
               "v.NroVuelo,ao.Domicilio Origen,ao.Nombre as AeropuertoOrigen,ao.IdAeropuerto as IdAeropuertoOrigen," +
               "ad.Domicilio as Destino,ad.Nombre as AeropuertoDestino,ad.IdAeropuerto as IdAeropuertoDestino," +
               "av.Descripcion as NombreAvion, ta.DescripcionTipo " +
               "from Pasaje pa join Pasajero p on (pa.NroDNI=p.NroDNI and pa.TipoDNI=p.TipoDNI) " +
               "join TipoDocumento td on p.TipoDNI=td.TipoDNI " +
               "join TipoPasaje tp on tp.IdTipoPasaje=pa.TipoPasaje " +
               "join Vuelo v on (pa.NroVuelo=v.NroVuelo) " +
               "join Aeropuerto ao on (v.IdAeropuerto=ao.IdAeropuerto) " +
               "join Aeropuerto ad on (v.IdAeropuertoDestino=ad.IdAeropuerto)  " +
               "join Avion av on (v.IdTipoAvion=av.IdTipoAvion and v.NroAvion=av.NroAvion) " +
               "join TipoAvion ta on (av.IdTipoAvion=ta.IdTipoAvion) " +
               "where NroPasaje like '%%'";
            
            if (f.TipoDocumento != "Seleccionar") { sentenciaSql += $" and pa.TipoDNI like '{f.TipoDocumento}%'"; }
            if (f.TipoPasajeId != 0) { sentenciaSql += $" AND pa.TipoPasaje = {f.TipoPasajeId}"; }
            if (!string.IsNullOrEmpty(f.NroDocumento)) { sentenciaSql += $" and pa.NroDNI like '%{f.NroDocumento}%'"; }
            if(f.IdAeropuertoOrigen != 0) { sentenciaSql += $" and ao.IdAeropuerto like '%{f.IdAeropuertoOrigen}%'"; }
            if (f.IdAeropuertoDestino != 0) { sentenciaSql += $" and ad.IdAeropuerto like '%{f.IdAeropuertoDestino}%'"; }
            if (f.Origen != "Seleccionar") { sentenciaSql += $" and ao.Domicilio like '%{f.Origen}%'"; }
            if (f.Destino != "Seleccionar") { sentenciaSql += $" and ad.Domicilio like '%{f.Destino}%'"; }
            //if (f.PuertaEmbarque!=0) { sentenciaSql += $" and e.PuertaEmbarque like '%{f.PuertaEmbarque}%'"; }
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
            if(fila["Precio"].ToString() != null)
            {
                pasaje.Precio = Convert.ToInt32(fila["Precio"].ToString());
            }
            pasaje.NroDocumento = new Pasajero()
            {
                NroDocumento = fila["NroDNI"].ToString(),
                Apellido = fila["Apellido"].ToString(),
                Nombre = fila["Nombre"].ToString(),
                Telefono = fila["Telefono"].ToString(),
                Email = fila["Mail"].ToString(),
                FechaNacimiento = Convert.ToDateTime(fila["FechaNacimiento"].ToString()),
                TipoDocumento = new TipoDocumento()
                {
                    Id = fila["TipoDNI"].ToString(),
                    //Descripcion = fila["Descripcion"].ToString()
                }
            };
            pasaje.TipoDocumento = pasaje.NroDocumento.TipoDocumento;
            pasaje.IdTipoPasaje = new TipoPasaje()
            {
                Id = Convert.ToInt32(fila["IdTipoPasaje"].ToString()),
                Detalle = fila["Descripcion"].ToString()
            };
            pasaje.AeropuertoOrigen = new Aeropuerto();
            pasaje.AeropuertoOrigen.IdAeropuerto = Convert.ToInt32(fila["IdAeropuertoOrigen"].ToString());
            pasaje.AeropuertoOrigen.Nombre = fila["AeropuertoOrigen"].ToString();
            pasaje.AeropuertoOrigen.Domicilio = fila["Origen"].ToString();
            pasaje.AeropuertoDestino = new Aeropuerto();
            pasaje.AeropuertoDestino.IdAeropuerto = Convert.ToInt32(fila["IdAeropuertoDestino"].ToString());
            pasaje.AeropuertoDestino.Nombre = fila["AeropuertoDestino"].ToString();
            pasaje.AeropuertoDestino.Domicilio = fila["Destino"].ToString();
            /*pasaje.Vuelo = new VueloV2();
            pasaje.Vuelo.Estado = new Estado();
            pasaje.Vuelo.Estado.IdEstado = Convert.ToInt32(fila["Estado"].ToString());*/
            /*pasaje.Embarque = new EmbarqueV2();
            pasaje.Embarque.PuertaEmbarque = Convert.ToInt32(fila["PuertaEmbarque"].ToString());*/
            return pasaje;
        }
       
        public void Registrar(Pasaje p)
        {
            using (var tx = DBHelper.GetDBHelper().IniciarTransaccion())
            {
                try
                {
                    var sql = $"INSERT INTO Pasaje (TipoPasaje, TipoDNI, NroDNI";
                    if (p.TienePrecio())
                        sql += ", Precio";
                    if (p.TieneMotivo())
                        sql += ", MotivoViaje";
                    sql += $",NroVuelo,FechaHoraSalida,FechaHoraLlegada,IdAeropuertoSalida) " +
                        $"VALUES({p.IdTipoPasaje.Id}, '{p.TipoDocumento.Id}', '{p.NroDocumento.NroDocumento}'";
                    if (p.TienePrecio())
                        sql += $", {p.Precio}";
                    if (p.TieneMotivo())
                        sql += $", '{p.Motivo}'";
                    sql += $",{p.Vuelo.NroVuelo},'{p.Vuelo.FechaHoraSalida}','{p.Vuelo.FechaHoraLlegada}',{p.AeropuertoOrigen.IdAeropuerto})";
                    p.Id = DBHelper.GetDBHelper().EjecutarTransaccionSQL(sql);
                    
                    

                    
                    tx.Commit();
                }
                catch (Exception ex)
                {
                    //el Rollback lo que me haria es que, cuando yo quiero hacer 2 o + sentencias que cada una depende de la anterior y si falla una
                    //de ellas las anteriores se borraran no se ejecutaran
                    tx.Rollback();
                    throw new ApplicationException("No se pudo registrar el pasaje.");
                }
                finally
                {
                    DBHelper.GetDBHelper().CloseConnection();
                }
            }
        }
        public Pasaje ObtenerPasaje(PasajesFiltros f)
        {
            Pasaje pasajeResultado = null;
            var sentenciaSql = " Select pa.NroPasaje,pa.MotivoViaje,pa.precio,tp.*,p.*, " +
                "v.NroVuelo,v.FechaHoraSalida,v.FechaHoraLlegada," +
                "datediff(MINUTE, v.FechaHoraSalida, v.FechaHoraLlegada) as CantidadMinutos," +
                "ao.Nombre as AeropuertoOrigen,ao.Domicilio as Origen,ao.IdAeropuerto as IdAeropuertoOrigen ," +
                "ad.Nombre as AeropuertoDestino,ad.Domicilio as Destino,ad.IdAeropuerto as IdAeropuertoDestino," +
                "ev.IdEstado as IdEstadoVuelo, ev.NombreEstado as EstadoVuelo , v.NroAvion,v.IdTipoAvion " +
                "from Pasaje pa join Pasajero p on (pa.NroDNI=p.NroDNI and pa.TipoDNI=p.TipoDNI) " +
                "join TipoDocumento td on p.TipoDNI=td.TipoDNI " +
                "join TipoPasaje tp on tp.IdTipoPasaje=pa.TipoPasaje " +
                "join Vuelo v on (v.NroVuelo=pa.NroVuelo) " +
                "join Estado ev on (v.Estado=ev.IdEstado) " +
                "join Ambito am on ev.Ambito=am.IdAmbito " +
                "join Aeropuerto ao on (v.IdAeropuerto=ao.IdAeropuerto) " +
                "join Aeropuerto ad on (v.IdAeropuertoDestino=ad.IdAeropuerto) " +
                "join Avion av on (v.IdTipoAvion=av.IdTipoAvion and v.NroAvion=av.NroAvion) " +
                "join TipoAvion ta on (av.IdTipoAvion=ta.IdTipoAvion) " +
                $" where pa.NroPasaje = {f.Id}  and pa.TipoDNI = '{f.TipoDocumento}' and pa.NroDNI = '{f.NroDocumento}'";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            if (tabla.Rows.Count == 1)
            {
                var row = tabla.Rows[0];
                var pasajeBD = new Pasaje();
                var nroPasaje = row["NroPasaje"];
                var tipoDocumento = row["TipoDNI"];
                var nrDocumento = row["NroDNI"];
                pasajeBD.Id = Convert.ToInt32(nroPasaje.ToString());
                pasajeBD.Motivo = row["MotivoViaje"].ToString();
                pasajeBD.NroDocumento = new Pasajero()
                {
                    NroDocumento = nrDocumento.ToString(),
                    Apellido = row["Apellido"].ToString(),
                    Nombre = row["Nombre"].ToString(),
                    Telefono = row["Telefono"].ToString(),
                    Email = row["Mail"].ToString(),
                    FechaNacimiento = Convert.ToDateTime(row["FechaNacimiento"].ToString()),
                    TipoDocumento = new TipoDocumento()
                    {
                        Id = tipoDocumento.ToString(),
                        //Descripcion = row["descripcion"].ToString()
                    }
                };
                pasajeBD.TipoDocumento = pasajeBD.NroDocumento.TipoDocumento;
                pasajeBD.IdTipoPasaje = new TipoPasaje()
                {
                    Id = Convert.ToInt32(row["IdTipoPasaje"].ToString()),
                    Detalle = row["Descripcion"].ToString()
                };
                pasajeBD.AeropuertoOrigen = new Aeropuerto();
                pasajeBD.AeropuertoOrigen.IdAeropuerto = Convert.ToInt32(row["IdAeropuertoOrigen"].ToString());
                pasajeBD.AeropuertoOrigen.Nombre = row["AeropuertoOrigen"].ToString();
                pasajeBD.AeropuertoOrigen.Domicilio = row["Origen"].ToString();
                pasajeBD.AeropuertoDestino= new Aeropuerto();
                pasajeBD.AeropuertoDestino.IdAeropuerto = Convert.ToInt32(row["IdAeropuertoDestino"].ToString());
                pasajeBD.AeropuertoDestino.Nombre = row["AeropuertoDestino"].ToString();
                pasajeBD.AeropuertoDestino.Domicilio = row["Destino"].ToString();
                pasajeBD.Vuelo = new VueloV2();
                pasajeBD.Vuelo.Estado = new Estado();
                pasajeBD.Vuelo.Estado.IdEstado = Convert.ToInt32(row["IdEstadoVuelo"].ToString());


                return pasajeBD;
            }
            return pasajeResultado;
        }

        public void ActualizarPasaje(Pasaje p)
        {
            
            using (var tx = DBHelper.GetDBHelper().IniciarTransaccion())
            {
                try
                {
                    var sql = $"UPDATE Pasaje SET TipoDNI = '{p.TipoDocumento.Id}', NroDNI = '{p.NroDocumento.NroDocumento}'," +
                        $" TipoPasaje = {p.IdTipoPasaje.Id},NroVuelo = {p.Vuelo.NroVuelo}, FechaHoraSalida = '{p.Vuelo.FechaHoraSalida}'" +
                        $",FechaHoraLlegada ='{p.Vuelo.FechaHoraLlegada}',IdAeropuertoSalida = {p.AeropuertoOrigen.IdAeropuerto} ";
                    if (p.TieneMotivo())
                        sql += $", MotivoViaje ='{p.Motivo}'";
                    if (p.TienePrecio())
                        sql += $", Precio={p.Precio}"; 
                    sql += $" where NroPasaje = {p.Id}";
                    DBHelper.GetDBHelper().EjecutarUpdateTransaccionSQL(sql);
                    
                    /*
                    sql = $"INSERT INTO BugsHistorico (fecha_historico, titulo, descripcion, id_bug, id_usuario_responsable, id_producto, id_estado";
                    if (b.TienePrioridad())
                        sql += ", id_prioridad";
                    if (b.TieneCriticidad())
                        sql += ", id_criticidad";
                    sql += $") VALUES('{DateTime.Today.ToString("yyyy-MM-dd")}', '{b.Titulo}', '{b.Descripcion}', {b.Id}, " +
                       $"{b.UsuarioResponsable.Id}, {b.Producto.Id},  {b.Estado.Id}";
                    if (b.TienePrioridad())
                        sql += $", {b.Prioridad.Id}";
                    if (b.TieneCriticidad())
                        sql += $", {b.Criticidad.Id}";
                    sql += ")";
                    DBHelper.GetDBHelper().EjecutarTransaccionSQL(sql);*/
                    tx.Commit();
                }
                catch (Exception ex)
                {
                    //el Rollback lo que me haria es que, cuando yo quiero hacer 2 o + sentencias que cada una depende de la anterior y si falla una
                    //de ellas las anteriores se borraran no se ejecutaran
                    tx.Rollback();
                    throw new ApplicationException("No se pudo editar el pasaje.");
                }
                finally
                {
                    DBHelper.GetDBHelper().CloseConnection();
                }
            }

        }

        /*public void ConsultarPasaje(PasajesFiltros f)
        {
            Pasaje pasajeResultado = null;
            var sentenciaSql = " Select pa.NroPasaje,pa.MotivoViaje,pa.precio,tp.*,p.*, " +
                "v.NroVuelo,v.FechaHoraSalida,v.FechaHoraLlegada," +
                "datediff(MINUTE, v.FechaHoraSalida, v.FechaHoraLlegada) as CantidadMinutos," +
                "ao.Nombre as AeropuertoOrigen,ao.Domicilio as Origen,ao.IdAeropuerto as IdAeropuertoOrigen ," +
                "ad.Nombre as AeropuertoDestino,ad.Domicilio as Destino,ad.IdAeropuerto as IdAeropuertoDestino," +
                "ev.IdEstado as IdEstadoVuelo, ev.NombreEstado as EstadoVuelo , v.NroAvion,v.IdTipoAvion " +
                "from Pasaje pa join Pasajero p on (pa.NroDNI=p.NroDNI and pa.TipoDNI=p.TipoDNI) " +
                "join TipoDocumento td on p.TipoDNI=td.TipoDNI " +
                "join TipoPasaje tp on tp.IdTipoPasaje=pa.TipoPasaje " +
                "join Vuelo v on (v.NroVuelo=pa.NroVuelo) " +
                "join Estado ev on (v.Estado=ev.IdEstado) " +
                "join Ambito am on ev.Ambito=am.IdAmbito " +
                "join Aeropuerto ao on (v.IdAeropuerto=ao.IdAeropuerto) " +
                "join Aeropuerto ad on (v.IdAeropuertoDestino=ad.IdAeropuerto) " +
                "join Avion av on (v.IdTipoAvion=av.IdTipoAvion and v.NroAvion=av.NroAvion) " +
                "join TipoAvion ta on (av.IdTipoAvion=ta.IdTipoAvion) ";
            sentenciaSql += $"where pa.NroPasaje={f.Id} and pa.TipoDNI='{f.TipoDocumento}' and pa.NroDNI='{f.NroDocumento}" +
                $"and ev.IdEstado !=11'";

        }*/
    }
}
