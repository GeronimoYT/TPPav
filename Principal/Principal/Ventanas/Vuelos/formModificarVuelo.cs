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

namespace Principal.Ventanas.Vuelos
{
    public partial class formModificarVuelo : Form
    {
        //private FormUtils formUtils;

        public formModificarVuelo(Vuelo v)
        {
            InitializeComponent();
            cmbNuevoA.SelectedValue = v.NroAvion;
            cmbNuevoAO.SelectedValue = v.IdAeropuerto;
            cmbNuevoAD.SelectedValue = v.IdAeropuerto;
            cmbNuevoEstado.SelectedValue = v.Estado;
        }

        private void formModificarVuelo_Load(object sender, EventArgs e)
        {
            cargaFechasYHoras();
            cargaAviones();
            cargaAeropuertos();
            cargaEstados();
        }

        private void cargaFechasYHoras()
        {
            NuevaFechaS.Value = DateTime.Today;
            NuevaFechaL.Value = DateTime.Today;

            for (int i = 00; i <= 23; i++)
            {
                if (i < 10)
                {
                    cmbHoraSalida.Items.Add("0" + i + ":00");
                    cmbHoraLlegada.Items.Add("0" + i + ":00");
                }
                else
                {
                    cmbHoraSalida.Items.Add(i + ":00");
                    cmbHoraLlegada.Items.Add(i + ":00");
                }
            }
        }

        private void cargaAviones()
        {
            string consulta1 = "SELECT * FROM Avion";
            var combo1 = DBHelper.GetDBHelper().ConsultaSQL(consulta1);
            cmbNuevoA.DataSource = combo1;
            cmbNuevoA.DisplayMember = "nroavion";
            cmbNuevoA.ValueMember = "nroavion";
            cmbNuevoA.SelectedIndex = -1;
        }
        private void cargaAeropuertos()
        {

                string consulta = "SELECT * FROM Aeropuerto";
                var comboAO= DBHelper.GetDBHelper().ConsultaSQL(consulta);
                var comboAD = DBHelper.GetDBHelper().ConsultaSQL(consulta);

                cmbNuevoAO.DataSource = comboAO;
                cmbNuevoAD.DataSource = comboAD;

                cmbNuevoAO.DisplayMember = "domicilio";
                cmbNuevoAO.ValueMember = "idAeropuerto";
                cmbNuevoAO.SelectedIndex = -1;

                cmbNuevoAD.DisplayMember = "domicilio";
                cmbNuevoAD.ValueMember = "idAeropuerto";
                cmbNuevoAD.SelectedIndex = -1;
          }

        private void cargaEstados()
        {
            string consulta = "SELECT * FROM ESTADO WHERE AMBITO = 1";
            var comboE = DBHelper.GetDBHelper().ConsultaSQL(consulta);

            cmbNuevoEstado.DataSource = comboE;

            cmbNuevoEstado.DisplayMember = "domicilio";
            cmbNuevoEstado.ValueMember = "idEstado";
            cmbNuevoEstado.SelectedIndex = -1;
        }

        private void btnConfirmarVuelo_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult resultado = MessageBox.Show("¿Está seguro que desea actualizar los datos del Vuelo?", "VUELO", buttons);
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    var fechaHoraSalida = NuevaFechaS.Value.ToString("dd/MM/yyyy") + ' ' + cmbHoraSalida.Text;
                    var fechaHoraLlegada = NuevaFechaL.Value.ToString("dd/MM/yyyy") + ' ' + cmbHoraLlegada.Text;
                    
                    var fechaHoraS = Convert.ToDateTime(fechaHoraSalida);
                    var fechaHoraL = Convert.ToDateTime(fechaHoraLlegada);

                    //ACTUALIZO DATOS DE BS SEGUN QUE DATO ???
                    string consulta = $"UPDATE Vuelo SET FechaHoraSalida = '{fechaHoraS.ToString("dd-MM-yyyy HH:mm")}', FechaHoraLlegada = '{fechaHoraL.ToString("dd-MM-yyyy HH:mm")}', " +
                                      $"NroAvion = '{cmbNuevoA.SelectedValue.ToString()}', IdTipoAvion = {txtNuevoTA.Text}, IdAeropuerto = '{cmbNuevoAO.SelectedValue.ToString()}'," +
                                      $" IdAeropuertoDestino = '{cmbNuevoAD.SelectedValue.ToString()}', Estado = '{cmbNuevoEstado.SelectedValue.ToString()})";
                    var carga = DBHelper.GetDBHelper().ConsultaSQL(consulta);
                    MessageBox.Show("Se modificaron los datos del Vuelo!");
                    //LimpiarCampos();
                    formVuelo ventanaVuelo = new formVuelo();
                    ventanaVuelo.Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se ha podido Registrar el Vuelo");
                }
            }
            else
            { this.Close(); }


        }

        private void btnCancelarVuelo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbNuevoA_SelectedIndexChanged(object sender, EventArgs e)
        {
            Avion avion = (Avion)cmbNuevoA.SelectedItem;

            if (cmbNuevoA.SelectedIndex != -1)
            {
                try
                {
                    /*string consultasql = $"SELECT DescripcionTipo FROM Avion a JOIN TipoAvion tp ON a.IdTipoAvion = tp.IdTipoAvion " +
                                         $"WHERE a.NroAvion LIKE {avion.idTipo.ToString()}";

                    var res = DBHelper.GetDBHelper().ComandoSQL(consultasql);
                    txtTipoAvion.Text = res;*/

                    /*string consulta = $"SELECT DescripcionTipo FROM TipoAvion WHERE IdTipoAvion LIKE {avion.idTipo}";
                    var res = DBHelper.GetDBHelper().ConsultaSQL(consulta);
                    cmbNumAvion.DataSource = res;
                    txtTipoAvion.Text= res.ToString();*/
                    txtNuevoTA.Text = avion.idTipo.ToString();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("La consulta ejecutada es incorrecta");
                }
            }
            else
            {
                txtNuevoTA.Text = "";
            }
        }

        private void btnConfirmarVuelo_Click_1(object sender, EventArgs e)
        {

        }
    }
}
