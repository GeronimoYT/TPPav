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
            cmbNuevoA.SelectedValue = v.Avion.numero;
            cmbNuevoAO.SelectedValue = v.Aeropuerto.IdAeropuerto;
            cmbNuevoAD.SelectedValue = v.AeropuertoDestino.IdAeropuerto;
            cmbNuevoEstado.SelectedValue = v.Estado.IdEstado;
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

            cmbHoraSalida.Items.Add("00:00"); cmbHoraSalida.Items.Add("01:00"); cmbHoraSalida.Items.Add("02:00"); cmbHoraSalida.Items.Add("03:00"); cmbHoraSalida.Items.Add("04:00"); cmbHoraSalida.Items.Add("05:00"); cmbHoraSalida.Items.Add("06:00"); cmbHoraSalida.Items.Add("07:00"); cmbHoraSalida.Items.Add("08:00"); cmbHoraSalida.Items.Add("09:00"); cmbHoraSalida.Items.Add("10:00"); cmbHoraSalida.Items.Add("11:00");
            cmbHoraSalida.Items.Add("12:00"); cmbHoraSalida.Items.Add("13:00"); cmbHoraSalida.Items.Add("14:00"); cmbHoraSalida.Items.Add("15:00"); cmbHoraSalida.Items.Add("16:00"); cmbHoraSalida.Items.Add("17:00"); cmbHoraSalida.Items.Add("18:00"); cmbHoraSalida.Items.Add("19:00"); cmbHoraSalida.Items.Add("20:00"); cmbHoraSalida.Items.Add("21:00"); cmbHoraSalida.Items.Add("22:00"); cmbHoraSalida.Items.Add("23:00");

            cmbHoraLlegada.Items.Add("00:00"); cmbHoraLlegada.Items.Add("01:00"); cmbHoraLlegada.Items.Add("02:00"); cmbHoraLlegada.Items.Add("03:00"); cmbHoraLlegada.Items.Add("04:00"); cmbHoraLlegada.Items.Add("05:00"); cmbHoraLlegada.Items.Add("06:00"); cmbHoraLlegada.Items.Add("07:00"); cmbHoraLlegada.Items.Add("08:00"); cmbHoraLlegada.Items.Add("09:00"); cmbHoraLlegada.Items.Add("10:00"); cmbHoraLlegada.Items.Add("11:00");
            cmbHoraLlegada.Items.Add("12:00"); cmbHoraLlegada.Items.Add("13:00"); cmbHoraLlegada.Items.Add("14:00"); cmbHoraLlegada.Items.Add("15:00"); cmbHoraLlegada.Items.Add("16:00"); cmbHoraLlegada.Items.Add("17:00"); cmbHoraLlegada.Items.Add("18:00"); cmbHoraLlegada.Items.Add("19:00"); cmbHoraLlegada.Items.Add("20:00"); cmbHoraLlegada.Items.Add("21:00"); cmbHoraLlegada.Items.Add("22:00"); cmbHoraLlegada.Items.Add("23:00");
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

        }

        private void btnCancelarVuelo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbNuevoA_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
