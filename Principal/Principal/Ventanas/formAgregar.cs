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
    public partial class formAgregar : Form
    {
        public formAgregar()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            formAeropuerto aeropuerto = new formAeropuerto();
            aeropuerto.Show();
            this.Close();
        }

        private void formAgregar_Load(object sender, EventArgs e)
        {
            CargaGrilla();
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

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (txtNuevoDomicilio.Text.Equals("")) {
                MessageBox.Show("Debe ingresar al menos un domicilio para el nuevo aeropuerto");
            }
            else
            {
                try {
                    string consultaCarga = $"INSERT INTO Aeropuerto (Domicilio,Telefono,Descripcion,CantPuertasEmbarque,CantMangasVuelo) VALUES ('{txtNuevoDomicilio.Text}','{txtNuevoTelefono.Text}','{txtNuevaDescripcion.Text}','{txtCPEmbarque.Text}','{txtCMVuelo.Text}')";
                    var carga = DBHelper.GetDBHelper().ConsultaSQL(consultaCarga);
                    MessageBox.Show("Carga exitosa!");
                    CargaGrilla();
                    LimpiarCampos();
                }catch(SqlException ex)
                {
                    MessageBox.Show("Error al realizar la consulta a la Base de Datos ");
                }
            }
            
        }


        private void LimpiarCampos()
        {
            txtNuevoDomicilio.Text = "";
            txtNuevoTelefono.Text = "";
            txtNuevaDescripcion.Text = "";
            txtCPEmbarque.Text = "";
            txtCMVuelo.Text = "";
        }
    }
}
