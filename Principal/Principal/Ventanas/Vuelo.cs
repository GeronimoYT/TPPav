using Principal.Clases;
using Principal.Utils;
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
    public partial class Vuelo : Form
    {
        public Vuelo()
        {
            InitializeComponent();
        }

        private void Vuelo_Load(object sender, EventArgs e)
        {
            CargaGrilla();
            CargoFiltros();
            //dgvVuelos.ClearSelection();
        }

        private void CargaGrilla()
        {
            try
            {
                string consulta = $"SELECT * FROM Vuelo";
                var grilla = DBHelper.GetDBHelper().ConsultaSQL(consulta);
                dgvVuelos.DataSource = grilla;
                dgvVuelos.ClearSelection();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("La consulta ejecutada es incorrecta, por favor revise nuevamente ");
            }

            //select DescripcionTipo
            //from avion a join TipoAvion ta on a.NroAvion = ta.IdTipoAvion

        }

        public void CargoFiltros()
        {
            try
            {
                string consulta1 = "SELECT * FROM Avion";
                string consulta2 = "SELECT * FROM Estado";
                var combo1 = DBHelper.GetDBHelper().ConsultaSQL(consulta1);
                var combo2 = DBHelper.GetDBHelper().ConsultaSQL(consulta2);
                cmbNA.DataSource = combo1;
                cmbE.DataSource = combo2;

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
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //formAltaVuelo editar = new formAltaVuelo();
            //editar.Show();
            //this.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            busquedaVuelo();
        }

        private void busquedaVuelo()
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
        }

        private void dgvVuelos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnModificar.Enabled = true;
                btnBorrar.Enabled = true;
            }
        }
    }

















    /* private Vuelo cargarVuelo()
          {
              Vuelo vv = new Vuelo();
              vv.NroVuelo = Int32.Parse(dgvVuelos.CurrentRow.Cells[0].Value.ToString());
              vv.FechaHoraSalida = dgvVuelos.CurrentRow.Cells[1].Value.ToString();
              //vv.FechaHoraLlegada = ;
              //vv.NroAvion = ;
              //vv.IdTipoAvion = ;
              //vv.IdAeropuerto = ;
              //vv.IdAeropuertoDestino = ;
              //vv.Estado = ;

              return vv;
          }*/

    /*
        Aeropuerto ae = new Aeropuerto();
        ae.IdAeropuerto = Int32.Parse(dgvDatosAeropuerto.CurrentRow.Cells[0].Value.ToString());
        ae.Domicilio = dgvDatosAeropuerto.CurrentRow.Cells[1].Value.ToString();
        ae.Telefono = dgvDatosAeropuerto.CurrentRow.Cells[2].Value.ToString();
        ae.Descripcion = dgvDatosAeropuerto.CurrentRow.Cells[3].Value.ToString();
        ae.CantPuertasEmbarque = Int32.Parse(dgvDatosAeropuerto.CurrentRow.Cells[4].Value.ToString());
        ae.CantMangasVuelo = Int32.Parse(dgvDatosAeropuerto.CurrentRow.Cells[5].Value.ToString());
        ae.Nombre = dgvDatosAeropuerto.CurrentRow.Cells[6].Value.ToString();

        return ae;
    }*/


}
