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
    public partial class Vuelo : Form
    {
        public Vuelo()
        {
            InitializeComponent();
        }

        private void Vuelo_Load(object sender, EventArgs e)
        {
            CargoCombo();
            CargaHoras();
        }

        private void CargoCombo()
        {
            try
            {
                string consulta = "SELECT Domicilio FROM Aeropuerto";
                var combo1 = DBHelper.GetDBHelper().ConsultaSQL(consulta);
                var combo2 = DBHelper.GetDBHelper().ConsultaSQL(consulta);
                cmbAeropuerto1.DataSource = combo1;
                cmbAeropuerto2.DataSource = combo2;
                cmbAeropuerto1.DisplayMember = "domicilio";
                cmbAeropuerto2.DisplayMember = "domicilio";
            }
            catch (SqlException ex)
            {
                MessageBox.Show("La consulta ejecutada es incorrecta, por favor revise nuevamente");
            }
        }

        public void cargaHoras()
        {

            foreach ()
            {

            }
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
