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
            CargaGrilla();
        }

        private void CargoCombo()
        {

            try
            {
                string consulta = "SELECT * FROM Aeropuerto";
                var combo = DBHelper.GetDBHelper().ConsultaSQL(consulta);
                cmbAeropuerto.DataSource = combo;
                cmbAeropuerto.DisplayMember = "domicilio";
            }
            catch (SqlException ex)
            {
                MessageBox.Show("La consulta ejecutada es incorrecta, por favor revise nuevamente");
            }
            
        }


        private void CargaGrilla()
        {
            try
            {
                string consulta = $"SELECT * FROM Aeropuerto WHERE IdAeropuerto LIKE {cmbAeropuerto.SelectedIndex + 1}";
                var grilla = DBHelper.GetDBHelper().ConsultaSQL(consulta);
                dgvDatosAeropuerto.DataSource = grilla;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("La consulta ejecutada es incorrecta, por favor revise nuevamente");
            }
        }


        private void cmbAeropuerto_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargaGrilla();
        }

        private void btnAceptarEdicion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditarAeropuerto_Click(object sender, EventArgs e)
        {
            string dato = cmbAeropuerto.SelectedIndex.ToString();
            MessageBox.Show(dato);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult resultado = MessageBox.Show("Está seguro que desea realizar esta operación?","Eliminar Aeropuerto",buttons);
            if(resultado == System.Windows.Forms.DialogResult.Yes)
            {
                try {
                    string consulta = $"DELETE FROM Aeropuerto WHERE IdAeropuerto LIKE {cmbAeropuerto.SelectedIndex + 1}";
                    var eliminar = DBHelper.GetDBHelper().ConsultaSQL(consulta);
                    CargoCombo();
                }
                catch(Exception ex) {
                    MessageBox.Show("No se ha podido realizar la operación"); 
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
