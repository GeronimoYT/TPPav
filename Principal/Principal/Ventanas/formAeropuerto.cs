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
            CargaInicial();
        }


        private void CargaInicial()
        {
            try
            {
                string consulta = $"SELECT * FROM Aeropuerto";
                var grilla = DBHelper.GetDBHelper().ConsultaSQL(consulta);
                dgvDatosAeropuerto.DataSource = grilla;
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
                string consulta = $"SELECT * FROM Aeropuerto WHERE Nombre LIKE '%{txtBusquedaNombre.Text}%'";
                var grilla = DBHelper.GetDBHelper().ConsultaSQL(consulta);                
                if (grilla.Rows.Count > 0)
                {
                    dgvDatosAeropuerto.DataSource = grilla;
                }
                else MessageBox.Show("No se ha encontrado ningún aeropuerto con el Nombre " + txtBusquedaNombre.Text);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("La consulta ejecutada es incorrecta, por favor revise nuevamente ");
            }
        }


      

        private void btnAceptarEdicion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditarAeropuerto_Click(object sender, EventArgs e)
        {
            formEditar edicion = new formEditar(CargarAeropuerto());
            edicion.Show();
            this.Close();
        }

        private Aeropuerto CargarAeropuerto()
        {

            Aeropuerto ae = new Aeropuerto();
            ae.IdAeropuerto = Int32.Parse(dgvDatosAeropuerto.CurrentRow.Cells[0].Value.ToString());
            ae.Domicilio = dgvDatosAeropuerto.CurrentRow.Cells[1].Value.ToString();
            ae.Telefono = dgvDatosAeropuerto.CurrentRow.Cells[2].Value.ToString();
            ae.Descripcion = dgvDatosAeropuerto.CurrentRow.Cells[3].Value.ToString();
            ae.CantPuertasEmbarque = Int32.Parse(dgvDatosAeropuerto.CurrentRow.Cells[4].Value.ToString());
            ae.CantMangasVuelo = Int32.Parse(dgvDatosAeropuerto.CurrentRow.Cells[5].Value.ToString());
            ae.Nombre = dgvDatosAeropuerto.CurrentRow.Cells[6].Value.ToString();

            return ae;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult resultado = MessageBox.Show("Está seguro que desea realizar esta operación?","Eliminar Aeropuerto",buttons);
            if(resultado == System.Windows.Forms.DialogResult.Yes)
            {
                try {
                    string consulta = $"DELETE FROM Aeropuerto WHERE Nombre LIKE '{dgvDatosAeropuerto.CurrentRow.Cells[6].Value.ToString()}'";
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
            if(e.RowIndex >= 0)
            {
                btnEditarAeropuerto.Enabled = true;
                btnEliminarAeropuerto.Enabled = true;
            }
        }
    }
}
