using Principal.Clases;
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
    public partial class formAltaVuelo : Form
    {
        public formPrincipal principal;

        public object Me { get; private set; }

        public formAltaVuelo()
        {
            InitializeComponent();
        }

        private void formVuelo_Load(object sender, EventArgs e)
        {
            CargaHoras();
            CargoCombo();
            //txtNumVuelo.
        }

        private void CargoCombo()
        {
            try
            {
                string consulta1 = "SELECT NroAvion FROM Avion";
                string consulta2 = "SELECT * FROM Aeropuerto";
                string consulta3 = "SELECT * FROM Estado";
                
                var combo1 = DBHelper.GetDBHelper().ConsultaSQL(consulta1);
                var combo2 = DBHelper.GetDBHelper().ConsultaSQL(consulta2);
                var combo3 = DBHelper.GetDBHelper().ConsultaSQL(consulta2);
                var combo4 = DBHelper.GetDBHelper().ConsultaSQL(consulta3);
                
                cmbNumAvion.DataSource = combo1;
                cmbAeropuertoOrigen.DataSource = combo2;
                cmbAeropuertoDestino.DataSource = combo3;
                cmbEstado.DataSource = combo4;

                
                cmbNumAvion.DisplayMember = "nroavion";
                cmbNumAvion.SelectedIndex = -1;
                /*if (cmbNumAvion.SelectedValue != null)
                {
                    //RELLENAR TXTBOX CON DESCRIP DE TIPO AVION
                }
                else
                {
                    //RELLENAR TXTBOX CON DESCRIP "" 
                }*/
                cmbAeropuertoOrigen.DisplayMember = "domicilio";
                cmbAeropuertoOrigen.SelectedIndex = -1;
                cmbAeropuertoDestino.DisplayMember = "domicilio";
                cmbAeropuertoDestino.SelectedIndex = -1;
                cmbEstado.DisplayMember = "NombreEstado";
                cmbEstado.SelectedIndex = -1;

            }
            catch (SqlException ex)
            {
                MessageBox.Show("La consulta ejecutada es incorrecta, por favor revise nuevamente");
            }
        }

        public void CargaHoras()
        {
            cmbHoraSalida.Items.Add("00:00"); cmbHoraSalida.Items.Add("01:00"); cmbHoraSalida.Items.Add("02:00"); cmbHoraSalida.Items.Add("03:00"); cmbHoraSalida.Items.Add("04:00"); cmbHoraSalida.Items.Add("05:00"); cmbHoraSalida.Items.Add("06:00"); cmbHoraSalida.Items.Add("07:00"); cmbHoraSalida.Items.Add("08:00"); cmbHoraSalida.Items.Add("09:00"); cmbHoraSalida.Items.Add("10:00"); cmbHoraSalida.Items.Add("11:00");
            cmbHoraSalida.Items.Add("12:00"); cmbHoraSalida.Items.Add("13:00"); cmbHoraSalida.Items.Add("14:00"); cmbHoraSalida.Items.Add("15:00"); cmbHoraSalida.Items.Add("16:00"); cmbHoraSalida.Items.Add("17:00"); cmbHoraSalida.Items.Add("18:00"); cmbHoraSalida.Items.Add("19:00"); cmbHoraSalida.Items.Add("20:00"); cmbHoraSalida.Items.Add("21:00"); cmbHoraSalida.Items.Add("22:00"); cmbHoraSalida.Items.Add("23:00");
            cmbHoraLlegada.Items.Add("00:00"); cmbHoraLlegada.Items.Add("01:00"); cmbHoraLlegada.Items.Add("02:00"); cmbHoraLlegada.Items.Add("03:00"); cmbHoraLlegada.Items.Add("04:00"); cmbHoraLlegada.Items.Add("05:00"); cmbHoraLlegada.Items.Add("06:00"); cmbHoraLlegada.Items.Add("07:00"); cmbHoraLlegada.Items.Add("08:00"); cmbHoraLlegada.Items.Add("09:00"); cmbHoraLlegada.Items.Add("10:00"); cmbHoraLlegada.Items.Add("11:00");
            cmbHoraLlegada.Items.Add("12:00"); cmbHoraLlegada.Items.Add("13:00"); cmbHoraLlegada.Items.Add("14:00"); cmbHoraLlegada.Items.Add("15:00"); cmbHoraLlegada.Items.Add("16:00"); cmbHoraLlegada.Items.Add("17:00"); cmbHoraLlegada.Items.Add("18:00"); cmbHoraLlegada.Items.Add("19:00"); cmbHoraLlegada.Items.Add("20:00"); cmbHoraLlegada.Items.Add("21:00"); cmbHoraLlegada.Items.Add("22:00"); cmbHoraLlegada.Items.Add("23:00");
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmarVuelo_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult resultado = MessageBox.Show("¿Está seguro que desea confirmar el Vuelo?", "VUELO", buttons);
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    //var fechaSalida = calendarioSalida.Date;
                    //var fechaLlegada = calendarioLlegada.ToString();
                    //CARGA DE DATOS DEL VUELO A BD
                    //string consultaCarga = $"INSERT INTO Vuelo (FechaHoraSalida,FechaHoraLlegada,NroAvion,IdTipoAvion,IdAeropuerto,IdDestino,Estado) VALUES ('{calendarioSalida.Text}','{calendarioLlegada.Text}','{cmbNumAvion.Text}','{txtTipoAvion.Text}','{cmbAeropuertoOrigen.Text}','{cmbAeropuertoDestino.Text}','{cmbEstado.Text}')";
                    //var carga = DBHelper.GetDBHelper().ConsultaSQL(consultaCarga);
                    MessageBox.Show("Carga exitosa!");
                    Vuelo ventanaVuelo = new Vuelo();
                    ventanaVuelo.Show();
                    LimpiarCampos();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se ha podido realizar la operación");
                }
            }
            else
            {
                LimpiarCampos();
            }
        }

        //PRUEBA DE SENTENCIA SQL
        //{CONCAT({calendarioSalida.Text}'_'{cmbHoraSalida.Text}) FyHSalida.Text}
        //string consultaCarga = $"INSERT INTO Vuelo (FechaHoraSalida,FechaHoraLlegada,NroAvion,IdTipoAvion,IdAeropuerto,IdDestino,Estado) VALUES ('{CONCAT({calendarioSalida.Text}'_'{cmbHoraSalida.Text}) FyHSalida.Text}','{CONCAT({calendarioLlegada.Text}'_'{cmbHoraLlegada.Text}) FyHLlegada.Text}','{cmbNumAvion.Text}','{txtTipoAvion.Text}','{cmbAeropuertoOrigen.Text}','{cmbAeropuertoDestino.Text}','{cmbEstado.Text}')";

        private void LimpiarCampos()
        {
            var hoy = DateTime.Today;
            calendarioSalida.SelectionStart = hoy;
            calendarioLlegada.SelectionStart = hoy;
            cmbHoraSalida.Text = "";
            cmbHoraLlegada.Text = "";
            cmbNumAvion.SelectedIndex = -1;
            txtTipoAvion.Text = "";
            cmbAeropuertoOrigen.SelectedIndex = -1;
            cmbAeropuertoDestino.SelectedIndex = -1;
            cmbEstado.SelectedIndex = -1;

        }

        private void btnCancelarVuelo_Click_1(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult resultado = MessageBox.Show("¿Está seguro que desea Salir?", "VUELO", buttons);
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    //formPrincipal principal = new formPrincipal();
                    this.Close();  
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se ha podido realizar la operación");
                }
            }
        }
    }
}
