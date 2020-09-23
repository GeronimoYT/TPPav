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
    public partial class formVuelo : Form
    {
        public formVuelo()
        {
            InitializeComponent();
            CargoCombo();
            //CargaHoras();
        }

       
        private void CargoCombo()
        {
            try
            {
                //string consulta1 = "SELECT NroAvion FROM Avion";
                string consulta2 = "SELECT Domicilio FROM Aeropuerto";
                //string consulta3 = "SELECT NombreEstado FROM Estado";

                //var combo1 = DBHelper.GetDBHelper().ConsultaSQL(consulta1);
                var combo2 = DBHelper.GetDBHelper().ConsultaSQL(consulta2);
                var combo3 = DBHelper.GetDBHelper().ConsultaSQL(consulta2);
               // var combo4 = DBHelper.GetDBHelper().ConsultaSQL(consulta3);

                //cmbNumAvion.DataSource = combo1;
                cmbAeropuerto1.DataSource = combo2;
                cmbAeropuerto2.DataSource = combo3;
                //cmbEstadoVuelo.DataSource = combo4;

                cmbNumAvion.DisplayMember = "numero avion";
                cmbAeropuerto1.DisplayMember = "domicilio";
                cmbAeropuerto2.DisplayMember = "domicilio";
                cmbEstadoVuelo.DisplayMember = "estado vuelo";
            }
            catch (SqlException ex)
            {
                MessageBox.Show("La consulta ejecutada es incorrecta, por favor revise nuevamente");
            }
        }

        public void cargaHoras()
        {

            
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

        }
    }
}
