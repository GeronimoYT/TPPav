﻿using Principal.Clases;
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
            iniciarCalendarios();
            CargoFiltros();
            CargaGrilla();
        }

        public void iniciarCalendarios()
        {
            filtroFS.Value = DateTime.Today;
            filtroFL.Value = DateTime.Today;
        }

        public void CargoFiltros()
        {
            try
            {
                string consulta = "SELECT * FROM Aeropuerto";
                string consulta1 = "SELECT * FROM Avion";
                string consulta2 = "SELECT * FROM Estado WHERE AMBITO = 1";

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
            //dgvVuelos.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            //dgvVuelos.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            try
            {
                string consulta = $"select v.NroVuelo,v.FechaHoraSalida,v.FechaHoraLlegada,a.Descripcion as NroAvion,"+
                "ta.DescripcionTipo as IdTipoAvion,ao.Domicilio as IdAeropuerto,ad.Domicilio as IdAeropuertoDestino,e.NombreEstado as Estado"+
                " from vuelo v"+
                " join avion a on v.NroAvion = a.NroAvion"+
                " join tipoavion ta on v.idtipoavion = ta.IdTipoAvion"+
                " join aeropuerto ao on v.IdAeropuerto = ao.IdAeropuerto"+
                " join aeropuerto ad on v.IdAeropuertoDestino = ad.IdAeropuerto"+
                " join estado e on v.Estado = e.IdEstado";
                var grilla = DBHelper.GetDBHelper().ConsultaSQL(consulta);
                dgvVuelos.DataSource = grilla;
                dgvVuelos.ClearSelection();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("La consulta ejecutada es incorrecta, por favor revise nuevamente ");
            }
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
                    string consulta = $"DELETE FROM Vuelo WHERE NroVuelo LIKE '{dgvVuelos.CurrentRow.Cells["NroVuelo"].Value.ToString()}'";
                    var eliminar = DBHelper.GetDBHelper().ConsultaSQL(consulta);
                    MessageBox.Show("Se eliminó el Vuelo exitosamente");
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
            formModificarVuelo modificar = new formModificarVuelo(cargarVuelo());
            modificar.Show();
        }

        private Vuelo cargarVuelo()
        {
            Vuelo v = new Vuelo();
            v.Avion.numero = Int32.Parse(dgvVuelos.CurrentRow.Cells[3].Value.ToString());
            v.Avion.idTipo = Int32.Parse(dgvVuelos.CurrentRow.Cells[4].Value.ToString());
            v.Aeropuerto.IdAeropuerto = Int32.Parse(dgvVuelos.CurrentRow.Cells[5].Value.ToString());
            v.AeropuertoDestino.IdAeropuerto = Int32.Parse(dgvVuelos.CurrentRow.Cells[6].Value.ToString());
            v.Estado.IdEstado = Int32.Parse(dgvVuelos.CurrentRow.Cells[7].Value.ToString()); ;
            return v;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                var filtros = new VuelosFiltros
                {
                    FechaDesde = filtroFS.Value,
                    FechaHasta = filtroFL.Value,
                    //IdAeropuerto = ((Aeropuerto)cmbAO.SelectedItem).IdAeropuerto,
                    //IdAeropuertoDestino = ((Aeropuerto)cmbAD.SelectedItem).IdAeropuerto,
                    //NroAvion = ((Avion)cmbNA.SelectedItem).numero,
                    //IdEstado = ((Estado)cmbE.SelectedItem).IdEstado
                };
                Consultar(filtros);
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

        public void Consultar(VuelosFiltros filtros)
        {
            var vuelos = _vuelosServicio.Obtener(filtros);
            CargarGrilla(vuelos);
        }

        private void CargarGrilla(List<Vuelo> vuelos)
        {
            dgvVuelos.Rows.Clear();
            foreach (var v in vuelos)
            {
                var fila = new string[] {
                    v.NroVuelo.ToString(),
                    v.FechaHoraSalida.ToString("dd/MM/yyyy HH:mm"),
                    v.FechaHoraLlegada.ToString("dd/MM/yyyy HH:mm"),
                    v.Avion?.descripcion,
                    v.TipoAvion.ToString(),
                    v.Aeropuerto?.Domicilio,
                    v.AeropuertoDestino?.Domicilio,
                    v.Estado?.NombreEstado
                };
                dgvVuelos.Rows.Add(fila);
            }
        }

        /*private void busquedaVuelo()
        {

            try
            {
                string consulta = $"SELECT * FROM Vuelo WHERE NroAvion LIKE '%{cmbNA.Text}%'";
                if (cmbE.SelectedIndex != -1 )
                   consulta +=$" AND Estado LIKE '%{cmbE.SelectedValue}%'" ;
                var grilla = DBHelper.GetDBHelper().ConsultaSQL(consulta);
                if (grilla.Rows.Count > 0)
                {
                    dgvVuelos.DataSource = grilla;
                    dgvVuelos.ClearSelection();
                }
                else
                {
                    MessageBox.Show("No se ha encontrado ningún Vuelo" + cmbNA.Text);
                    dgvVuelos.DataSource = null ;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("La consulta ejecutada es incorrecta");
            }
        }

        private void busquedaPrueba()
        {
            try
            {
                string consulta = $"SELECT * FROM Vuelo WHERE FechaHoraSalida >= '{filtroFS.Value.Date.ToShortDateString()}%' AND FechaHoraLlegada " +
                    $"<= '{filtroFL.Value.Date.ToShortDateString()}%'";
                var grilla = DBHelper.GetDBHelper().ConsultaSQL(consulta);
                if (grilla.Rows.Count > 0)
                {
                    dgvVuelos.DataSource = grilla;
                }
                else
                {
                    MessageBox.Show("No se ha encontrado ningún Vuelo" + cmbNA.Text);
                    dgvVuelos.DataSource = null;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("La consulta ejecutada es incorrecta");
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
    }

}