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
    public partial class formAeropuerto : Form
    {
        public formAeropuerto()
        {
            InitializeComponent();
            CargoCombo();
        }

        private void CargoCombo()
        {
            try
            {
                string consulta = "SELECT Domicilio FROM Aeropuerto";
                var combo = DBHelper.GetDBHelper().ConsultaSQL(consulta);
                cmbAeropuerto.DataSource = combo;
                cmbAeropuerto.DisplayMember = "domicilio";
            }
            catch (SqlException ex)
            {
                MessageBox.Show("La consulta ejecutada es incorrecta, por favor revise nuevamente");
            }
        }

        private void cmbAeropuerto_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

    }
}
