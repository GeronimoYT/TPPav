using Principal.Clases;
using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal.Ventanas
{
    public partial class formEditar : Form
    {
        public formEditar(Aeropuerto ae)
        {
            InitializeComponent();
            CargaGrilla();
            txtID.Text = ae.IdAeropuerto.ToString();
            txtNuevoNombre.Text = ae.Nombre.ToString();
            txtNuevoDomicilio.Text = ae.Domicilio;
            txtNuevoTelefono.Text = ae.Telefono.ToString();
            txtNuevaDescripcion.Text = ae.Descripcion;
            txtCPEmbarque.Text = ae.CantPuertasEmbarque.ToString();
            txtCMVuelo.Text = ae.CantMangasVuelo.ToString();
        }

        private void txtNuevoDomicilio_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            formAeropuerto aeropuerto = new formAeropuerto();
            aeropuerto.Show();
            this.Close();
        }

        private void formEditar_Load(object sender, EventArgs e)
        {
            
        }

        private void CargaGrilla()
        {
            try
            {
                string consulta = $"SELECT * FROM Aeropuerto";
                var grilla = DBHelper.GetDBHelper().ConsultaSQL(consulta);
                dgvDatosAeropuerto.DataSource = grilla;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("La consulta ejecutada es incorrecta, por favor revise nuevamente ");
            }
        }
        private void LimpiarCampos()
        {
            txtID.Text = "";
            txtNuevoNombre.Text = "";
            txtNuevoDomicilio.Text = "";
            txtNuevoTelefono.Text = "";
            txtNuevaDescripcion.Text = "";
            txtCPEmbarque.Text = "";
            txtCMVuelo.Text = "";
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                string consulta = $"UPDATE Aeropuerto SET Nombre = '{txtNuevoNombre.Text}', Domicilio = '{txtNuevoDomicilio.Text}', Telefono = '{txtNuevoTelefono.Text}', Descripcion = '{txtNuevaDescripcion.Text}', CantPuertasEmbarque = '{txtCPEmbarque.Text}', CantMangasVuelo = '{txtCMVuelo.Text}' WHERE IdAeropuerto = '{txtID.Text}'";
                var aeropuerto = DBHelper.GetDBHelper().ConsultaSQL(consulta);
                MessageBox.Show("Actualización exitosa!");
                LimpiarCampos();
                formAeropuerto aep = new formAeropuerto();
                aep.Show();
                this.Close();
                

            }catch(Exception ex)
            {
                MessageBox.Show("No se ha podido actualizar el aeropuerto");
            }
        }

        
    }
}
