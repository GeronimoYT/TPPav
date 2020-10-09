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
            CargaGrilla();
        }

        private void CargaGrilla()
        {
            try
            {
                string consulta = $"SELECT * FROM Vuelo";
                var grilla = DBHelper.GetDBHelper().ConsultaSQL(consulta);
                dgvVuelos.DataSource = grilla;

                CargoCombo();
                //CargaHoras();
            }catch(Exception ex)
            {

            }
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
                MessageBox.Show("La consulta ejecutada es incorrecta, por favor revise nuevamente ");
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
                    if (dgvVuelos.CurrentRow == null)
                        return;
                    //ELSE ?
                    dgvVuelos.Rows.Remove(dgvVuelos.CurrentRow);
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
    }
}
