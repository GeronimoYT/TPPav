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


            var sentenciaSql = "SELECT pa.NroPasaje,pa.MotivoViaje,p.*, tp.*" +
                "FROM Pasajero p join TipoDocumento td on p.TipoDNI=td.TipoDNI," +
                " Pasaje pa join TipoPasaje tp on tp.IdTipoPasaje = pa.TipoPasaje " +
                "where(pa.NroDNI = p.NroDNI and pa.TipoDNI = p.TipoDNI) and NroPasaje like '%%' ";
            if (f.TipoDocumento != "Seleccionar") { sentenciaSql += $" and p.TipoDNI like '{f.TipoDocumento}%'"; }
            if (f.TipoPasajeId != 0) { sentenciaSql += $" AND pa.TipoPasaje = {f.TipoPasajeId}"; }
            if (!string.IsNullOrEmpty(f.NroDocumento)) { sentenciaSql += $" and p.NroDNI like '%{f.NroDocumento}%'"; }

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
                    sql += $") VALUES({p.IdTipoPasaje.Id}, '{p.TipoDocumento.Id}', '{p.NroDocumento.NroDocumento}'";
                    if (p.TienePrecio())
                        sql += $", {p.Precio}";
                    if (p.TieneMotivo())
                        sql += $", {p.Motivo}";
                    sql += ")";
                    p.Id = DBHelper.GetDBHelper().EjecutarTransaccionSQL(sql);
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

            var sentenciaSql = "SELECT pa.NroPasaje,pa.MotivoViaje,p.*, tp.*" +
                "FROM Pasajero p join TipoDocumento td on p.TipoDNI=td.TipoDNI," +
                " Pasaje pa join TipoPasaje tp on tp.IdTipoPasaje = pa.TipoPasaje " +
                "where(pa.NroDNI = p.NroDNI and pa.TipoDNI = p.TipoDNI)" +
                $" and pa.NroPasaje = {f.Id}  and pa.TipoDNI = '{f.TipoDocumento}' and pa.NroDNI = '{f.NroDocumento}'";
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
                return pasajeBD;
            }
            return pasajeResultado;
        }

        public void ActualizarPasaje(Pasaje p)
        {
            /*var sentenciaSql = $"UPDATE Pasajero SET apellido='{_pasajero.Apellido}',nombre='{_pasajero.Nombre}',telefono='{_pasajero.Telefono}'," +
                $" email='{_pasajero.Email}' WHERE tipoDocumento='{_pasajero.TipoDocumento.Id}'" +
                $" and nroDocumento='{_pasajero.NroDocumento}' and fechaNacimiento='{_pasajero.FechaNacimiento}'";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            return filasAfectadas;*/
            using (var tx = DBHelper.GetDBHelper().IniciarTransaccion())
            {
                try
                {
                    var sql = $"UPDATE Pasaje SET TipoDNI = '{p.TipoDocumento.Id}', NroDNI = '{p.NroDocumento.NroDocumento}'," +
                        $" TipoPasaje = {p.IdTipoPasaje.Id} where NroPasaje = {p.Id}";

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
    }
}
