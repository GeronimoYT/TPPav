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
        }




        private void CargaGrilla()
        {
            try
            {
                string consulta = $"SELECT * FROM Aeropuerto WHERE Domicilio LIKE '%{txtBusquedaNombre.Text}%'";
                var grilla = DBHelper.GetDBHelper().ConsultaSQL(consulta);
                if (grilla.Rows.Count > 0)
                {
                    dgvDatosAeropuerto.DataSource = grilla;
                }
                else MessageBox.Show("No se ha encontrado ningún aeropuerto con el Domicilio " + txtBusquedaNombre.Text);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("La consulta ejecutada es incorrecta, por favor revise nuevamente ");
            }
        }


        private void cmbAeropuerto_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAceptarEdicion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditarAeropuerto_Click(object sender, EventArgs e)
        {
            formEditar edicion = new formEditar();
            edicion.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult resultado = MessageBox.Show("Está seguro que desea realizar esta operación?","Eliminar Aeropuerto",buttons);
            if(resultado == System.Windows.Forms.DialogResult.Yes)
            {
                try {
                    string consulta = $"DELETE FROM Aeropuerto WHERE Domicilio LIKE '{dgvDatosAeropuerto.CurrentCell.Value.ToString()}'";
                    var eliminar = DBHelper.GetDBHelper().ConsultaSQL(consulta);
                    MessageBox.Show("Se eliminó el aeropuerto exitosamente");
                }
                catch(Exception ex) {
                    MessageBox.Show("No se ha podido realizar la operación"); 
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            formAgregar agregarAeropuerto = new formAgregar();
            agregarAeropuerto.Show();
            this.Hide();
        }

        private void btnBuscarAeropuerto_Click(object sender, EventArgs e)
        {
            CargaGrilla();
        }

        private void dgvDatosAeropuerto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {            
            btnEditarAeropuerto.Enabled = true;
            btnEliminarAeropuerto.Enabled = true;
        }

        private void txtBusquedaID_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
