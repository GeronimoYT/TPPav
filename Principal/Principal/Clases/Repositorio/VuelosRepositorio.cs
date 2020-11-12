using Principal.Clases.Filtros;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Clases.Repositorio
{
    class VuelosRepositorio
    {
        /*public List<Vuelo> Obtenervuelos()
        {
            List<Vuelo> vuelos = new List<Vuelo>();
            var sentenciaSql = "SELECT * FROM Vuelo";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tabla.Rows)
            {
                var vuelo = new Vuelo();
                vuelo.NroVuelo = Convert.ToInt32(fila["NroVuelo"].ToString());
                vuelo.FechaHoraSalida = Convert.ToDateTime(fila["FechaHoraSalida"].ToString());
                vuelo.FechaHoraLlegada = Convert.ToDateTime(fila["FechaHoraLlegada"].ToString());
                vuelo.NroAvion = Convert.ToInt32(fila["NroAvion"].ToString());
                vuelo.IdTipoAvion = fila["IdTipoAvion"].ToString();
                vuelo.IdAeropuerto = Convert.ToInt32(fila["IdAeropuerto"].ToString());
                vuelo.IdAeropuertoDestino = Convert.ToInt32(fila["IdAeropuertoDestino"].ToString());
                vuelo.Estado = Convert.ToInt32(fila["Estado"].ToString());

                vuelos.Add(vuelo);
            }
            return vuelos;

        }*/

        public List<Vuelo> Obtener(VuelosFiltros filtros)
        {
            List<Vuelo> vuelos = new List<Vuelo>();
            var sentenciaSql = "SELECT v.*, a.descripcion as avion, ae.domicilio as aeropuerto, " +
                "es.nombreestado as estado" +
                "FROM Vuelo v " + //USA LOS ELEMENTOS EN PLURAL ?
                "LEFT JOIN Avion a ON v.nroavion = a.nroavion " +
                "LEFT JOIN Aeropuerto ae ON v.idaeropuerto = ae.idaeropuerto " +
                "LEFT JOIN AeropuertoDestino aed ON v.idaeropuerto = ae.idaeropuerto " +
                "LEFT JOIN Estado es ON v.idestado = es.idestado " +
                "WHERE v.nrovuelo like '%%'"; /// ????? 
            if (filtros.FechaDesde.HasValue)//EL FORMATO DE LA FECHA ESTA BIEN ???
                sentenciaSql += $" AND v.FechaHoraSalida > '{filtros.FechaDesde.Value.ToString("yyyy-MM-dd")}'";
            if (filtros.FechaHasta.HasValue)
                sentenciaSql += $" AND v.FechaHoraLlegada < '{filtros.FechaHasta.Value.ToString("yyyy-MM-dd")}'";
            if (filtros.NroAvion != 0)
                sentenciaSql += $" AND v.NroVuelo = {filtros.NroAvion}";
            if (filtros.IdAeropuerto != 0)
                sentenciaSql += $" AND v.IdAeropuerto = {filtros.IdAeropuerto}";
            if (filtros.IdAeropuertoDestino != 0)//ESTA BIEN ?
                sentenciaSql += $" AND v.IdAeropuerto = {filtros.IdAeropuertoDestino}";
            if (filtros.IdEstado != 0)
                sentenciaSql += $" AND v.IdEstado = {filtros.IdEstado}";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tabla.Rows)
            {
               var vuelo = Mapear(fila);
                vuelos.Add(vuelo);
            }

            return vuelos;
        }
        
       //BUSQUEDA POR ID
        public Vuelo Obtener(long id)
        {
            var sentenciaSql = "SELECT v.*, a.descripcion as avion, ae.domicilio as aeropuerto, " +
                "es.nombreestado as estado" +
                "FROM Vuelo v " + //USA LOS ELEMENTOS EN PLURAL ?
                "LEFT JOIN Avion a ON v.nroavion = a.nroavion " +
                "LEFT JOIN Aeropuerto ae ON v.idaeropuerto = ae.idaeropuerto " +
                "LEFT JOIN Estado es ON v.idestado = es.idestado " +
                "WHERE v.nroavion =  {id}";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            var vuelo = Mapear(tabla.Rows[0]);
            return vuelo;
        }

        private Vuelo Mapear(DataRow fila)
        {
            var vuelo = new Vuelo();
            vuelo.NroVuelo = Convert.ToInt32(fila["NroVuelo"].ToString());
            vuelo.FechaHoraSalida = Convert.ToDateTime(fila["FechaHoraSalida"].ToString());
            vuelo.FechaHoraLlegada = Convert.ToDateTime(fila["FechaHoraLlegada"].ToString());
            /*vuelo.NroAvion = new Avion
            {
                numero = Convert.ToInt32(fila["nroavion"].ToString())
                descripcion = fila["descripcion"].ToString()
            };
            vuelo.IdTipoAvion = fila["IdTipoAvion"].ToString();
            vuelo.IdAeropuerto = new Aeropuerto
            {
                IdAeropuerto = Convert.ToInt32(fila["idaeropuerto"].ToString())
                domicilio = fila["domicilio"].ToString()

            };
            vuelo.IdAeropuerto = new Aeropuerto
            {
                IdAeropuerto = Convert.ToInt32(fila["idaeropuerto"].ToString())
                nombre = fila["domicilio"].ToString()

            };
            vuelo.Estado = new Estado
                {
                    IdEstado = Convert.ToInt32(fila["idestado"].ToString())
                    NombreEstado = fila["nombreestado"].ToString()
                };*/
             return vuelo;
        }


        /*public void Registrar(Vuelo v)
        {
            using (var tx = DBHelper.GetDBHelper().IniciarTransaccion())
            {
                try
                {
                    string consulta = $"INSERT INTO Vuelo (FechaHoraSalida,FechaHoraLlegada,NroAvion,IdTipoAvion,IdAeropuerto,IdAeropuertoDestino,Estado) " +
                                      $"VALUES ('{v.FechaHoraSalida.ToString("dd-MM-yyyy HH:mm")}','{v.FechaHoraLlegada.ToString("dd-MM-yyyy HH:mm")}'" +
                                      $",{v.Avion.numero},{v.TipoAvion},{v.Aeropuerto.Domicilio},{v.AeropuertoDestino.Domicilio},{v.Estado.NombreEstado})";
                    DBHelper.GetDBHelper().EjecutarTransaccionSQL(consulta);
                    tx.Commit();
                }
                catch (Exception ex)
                {
                    tx.Rollback();
                    throw new ApplicationException("No se pudo registrar el Vuelo.");
                }
                finally
                {
                    DBHelper.GetDBHelper().CloseConnection();
                }
            }
        }*/


    }
}
