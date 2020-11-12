using Principal.Clases;
using Principal.Clases.Filtros;
using Principal.Clases.Servicios;
using Principal.Utils;
using Principal.Ventanas.Vuelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal.Ventanas
{
    public partial class formVuelo : Form
    {

        private VuelosServicio _vuelosServicio;
        public formVuelo()
        {
            InitializeComponent();
        }

        private void Vuelo_Load(object sender, EventArgs e)
        {
            
            filtroFS.Value = DateTime.Today;
            filtroFL.Value = DateTime.Today;
            CargoFiltros();
            CargaGrilla();
        }

        public void CargoFiltros()
        {
            try
            {
                string consulta = "SELECT * FROM Aeropuerto";
                string consulta1 = "SELECT * FROM Avion";
                string consulta2 = "SELECT * FROM Estado WHERE IDESTADO !=12 AND AMBITO = 1";

                var comboAO = DBHelper.GetDBHelper().ConsultaSQL(consulta);
                var comboAD = DBHelper.GetDBHelper().ConsultaSQL(consulta);
                var combo1 = DBHelper.GetDBHelper().ConsultaSQL(consulta1);
                var combo2 = DBHelper.GetDBHelper().ConsultaSQL(consulta2);

                cmbAO.DataSource = comboAO;
                cmbAD.DataSource = comboAD;
                cmbNA.DataSource = combo1;
                cmbE.DataSource = combo2;

                cmbAO.DisplayMember = "domicilio";
                cmbAO.ValueMember = "idAeropuerto";
                cmbAO.SelectedIndex = -1;

                cmbAD.DisplayMember = "domicilio";
                cmbAD.ValueMember = "idAeropuerto";
                cmbAD.SelectedIndex = -1;

                cmbNA.DisplayMember = "nroavion";
                cmbNA.ValueMember = "nroavion";
                cmbNA.SelectedIndex = -1;

                cmbE.DisplayMember = "nombreestado";
                cmbE.ValueMember = "idestado";
                cmbE.SelectedIndex = -1;

            }
            catch (SqlException ex)
            {
                MessageBox.Show("La consulta ejecutada es incorrecta, por favor revise nuevamente");
            }
        }

        private void CargaGrilla()
        {
           // if (dgvVuelos.DataSource != null)
            //{
                try
                {
                    string consulta = $"select v.NroVuelo,v.FechaHoraSalida,v.FechaHoraLlegada,a.Descripcion as NroAvion," +
                    "ta.DescripcionTipo as IdTipoAvion,ao.Domicilio as IdAeropuerto,ad.Domicilio as IdAeropuertoDestino,e.NombreEstado as Estado" +
                    " from vuelo v" +
                    " join avion a on v.NroAvion = a.NroAvion" +
                    " join tipoavion ta on v.idtipoavion = ta.IdTipoAvion" +
                    " join aeropuerto ao on v.IdAeropuerto = ao.IdAeropuerto" +
                    " join aeropuerto ad on v.IdAeropuertoDestino = ad.IdAeropuerto" +
                    " join estado e on v.Estado = e.IdEstado" +
                    " where e.ambito = 1";
                    var grilla = DBHelper.GetDBHelper().ConsultaSQL(consulta);
                    dgvVuelos.DataSource = grilla;
                    dgvVuelos.ClearSelection();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("La consulta ejecutada es incorrecta, por favor revise nuevamente ");
                }
           // }
        }

        //select*
        //from avion a join TipoAvion ta on a.IdTipoAvion = ta.IdTipoAvion
        //where a.NroAvion like '1'
        //select v.NroVuelo, v.FechaHoraSalida, v.FechaHoraLlegada, a.Descripcion,
        //ta.DescripcionTipo, ao.Domicilio, ad.Domicilio, e.NombreEstado
        //from vuelo v
        //join avion a on v.NroAvion = a.NroAvion
        //join tipoavion ta on v.idtipoavion = ta.IdTipoAvion
        //join aeropuerto ao on v.IdAeropuerto = ao.IdAeropuerto
        //join aeropuerto ad on v.IdAeropuertoDestino = ad.IdAeropuerto
        //join estado e on v.Estado = e.IdEstado

        

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult resultado = MessageBox.Show("Está seguro que desea realizar esta operación?", "Eliminar Vuelo", buttons);
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    string consulta = $"UPDATE Vuelo SET ESTADO '12' WHERE NroVuelo LIKE '{dgvVuelos.CurrentRow.Cells["NroVuelo"].Value.ToString()}'";
                    var eliminar = DBHelper.GetDBHelper().ConsultaSQL(consulta);
                    MessageBox.Show("Vuelo eliminado");
                    CargaGrilla();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se ha podido realizar la operación");
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            formAltaVuelo _formAltaVuelo = new formAltaVuelo();
            _formAltaVuelo.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string E = dgvVuelos.CurrentRow.Cells[7].Value.ToString();
            if (E != "Finalizado")
            {
                formModificarVuelo modificar = new formModificarVuelo(cargarVuelo());
                modificar.Show();
            }
            else
            {
                MessageBox.Show("No se puede Modificar datos de un Vuelo ya finalizado");
            }
        }

        private Vuelo cargarVuelo()
        {
            Vuelo v = new Vuelo();
            v.NroAvion = Int32.Parse(dgvVuelos.CurrentRow.Cells[0].Value.ToString());
            v.FechaHoraSalida = Convert.ToDateTime(dgvVuelos.CurrentRow.Cells[1].ToString()); ;
            v.FechaHoraLlegada = Convert.ToDateTime(dgvVuelos.CurrentRow.Cells[2].ToString());
            v.NroAvion = Int32.Parse(dgvVuelos.CurrentRow.Cells[3].Value.ToString());
            v.IdTipoAvion = dgvVuelos.CurrentRow.Cells[4].Value.ToString();
            v.IdAeropuerto = Int32.Parse(dgvVuelos.CurrentRow.Cells[5].Value.ToString());
            v.IdAeropuertoDestino = Int32.Parse(dgvVuelos.CurrentRow.Cells[6].Value.ToString());
            v.Estado= Int32.Parse(dgvVuelos.CurrentRow.Cells[7].Value.ToString());
            return v;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (filtroFS.Value <= filtroFL.Value)
            {
                if (validarAeropuertos() == false)
                {
                    try
                    {
                        var sentenciaSql = "SELECT v.NroVuelo,v.FechaHoraSalida, v.FechaHoraLlegada, a.descripcion as Avion, tp.descripcionTipo as TipoAvion," +
                        " aeo.domicilio as AeropuertoOrigen, aed.domicilio as AeropuertoDestino, es.nombreestado as Estado " +
                        "FROM Vuelo v " +
                        "LEFT JOIN Avion a ON v.nroavion = a.nroavion " +
                        "LEFT JOIN TipoAvion tp ON v.idtipoavion = tp.idtipoavion " +
                        "LEFT JOIN Aeropuerto aeo ON v.idaeropuerto = aeo.idaeropuerto " +
                        "LEFT JOIN Aeropuerto aed ON v.idaeropuertodestino = aed.idaeropuerto " +
                        "LEFT JOIN Estado es ON v.estado = es.idestado " +
                        "WHERE v.nrovuelo like '%%'";
                        if (filtroFS.Enabled && filtroFS.Value <= filtroFL.Value)
                            sentenciaSql += $" AND CONVERT(DATE,v.FechaHoraSalida) = '{filtroFS.Value.Date.ToString("yyyy-MM-dd")}'";
                        if (filtroFL.Enabled && filtroFL.Value >= filtroFS.Value)
                            sentenciaSql += $" AND CONVERT(DATE,v.FechaHoraLlegada) = '{filtroFL.Value.Date.ToString("yyyy-MM-dd")}'";
                        if (cmbNA.SelectedIndex != -1)
                            sentenciaSql += $" AND v.NroAvion = {cmbNA.SelectedValue}";
                        if (cmbAO.SelectedIndex != -1)
                            sentenciaSql += $" AND v.IdAeropuerto = {cmbAO.SelectedValue}";
                        if (cmbAD.SelectedIndex != -1)
                            sentenciaSql += $" AND v.IdAeropuertoDestino = {cmbAD.SelectedValue}";
                        if (cmbE.SelectedIndex != -1)
                            sentenciaSql += $" AND v.Estado = {cmbE.SelectedValue}";
                        var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
                        dgvVuelos.DataSource = tabla;
                        if (dgvVuelos.Rows.Count != 0)
                        {
                            dgvVuelos.ClearSelection();
                        }
                        else
                        {
                            dgvVuelos.DataSource = null;
                            MessageBox.Show("No se encontro ningun Vuelo");
                        }

                    }
                    catch (ApplicationException aex)
                    {
                        MessageBox.Show(aex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ha ocurrido un problema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Aeropuerto Origen y Aeropuerto Destino no pueden ser iguales");
                }
            }
            else
            {
                MessageBox.Show("Fecha de Salida no puede ser MAYOR a Fecha de Llegada");
            }
        }
                      
        public bool validarAeropuertos()
        {
            bool ae = false;
            
                if (cmbAO.Text.ToString() == cmbAD.Text.ToString())
                {
                    if (cmbAO.Text.ToString() == "" && cmbAD.Text.ToString() == "")
                        { }
                    else
                    {
                        ae = true;
                    }
                }
            return ae;
        }

        /*public void Consultar(VuelosFiltros filtros)
        {
            var vuelos = _vuelosServicio.Obtener(filtros);
            CargarGrilla(vuelos);
        }*/

        /*private void CargarGrilla(List<Vuelo> vuelos)
        {
            dgvVuelos.Rows.Clear();
            foreach (var v in vuelos)
            {
                var fila = new string[] {
                    //v.NroVuelo.ToString(),//NO HACE FALTA
                    v.FechaHoraSalida.ToString("dd/MM/yyyy HH:mm"),//ACA LE DOY FORMATO
                    v.FechaHoraLlegada.ToString("dd/MM/yyyy HH:mm"),
                    v.Avion?.descripcion,
                    v.TipoAvion.ToString(),
                    v.Aeropuerto?.Domicilio,
                    v.AeropuertoDestino?.Domicilio,
                    v.Estado?.NombreEstado
                };
                dgvVuelos.Rows.Add(fila);
            }
        }*/

        private void dgvVuelos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnModificar.Enabled = true;
                btnBorrar.Enabled = true;
            }
        }

        private void cbFS_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFS.Checked = true)
            {
                filtroFS.Enabled = true;
            }
            else
            {
                filtroFS.Enabled = false;
            }
        }

        private void cbFL_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFL.Checked = true)
            {
                filtroFL.Enabled = true;
            }
            else
            {
                filtroFL.Enabled = false;
            }
        }
    }

}
