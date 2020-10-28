using Principal.Clases;
using Principal.Clases.Servicios;
using System;
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
    public partial class formBajaPasajero : Form
    {
        private PasajerosServicio _pasajerosServicio;
        private formPasajeros _frmPasajeros;
        private Pasajero _pasajero;
        public formBajaPasajero(formPasajeros formPasajeros, string nroDoc)
        {
            _pasajerosServicio = new PasajerosServicio();
            _pasajero = _pasajerosServicio.ObtenerPasajero(nroDoc);
            _frmPasajeros = formPasajeros;
            InitializeComponent();
        }

        private void formBajaPasajero_Load(object sender, EventArgs e)
        {
            CargarDatos();
            
        }
        private void CargarDatos()
        {
            
            txtNroDocumento.Text = _pasajero.NroDocumento;
            txtApellido.Text = _pasajero.Apellido;
            txtNombre.Text = _pasajero.Nombre;
            txtTelefono.Text = _pasajero.Telefono;
            txtEmail.Text = _pasajero.Email;
            if (_pasajero.Estado)
                rbActivo.Checked = true;
            else
                rbInactivo.Checked = true;

        }
        

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ConfirmarOperacion()) { return; }
                ValidarPasajero();
                BajarPasajero();

            }
            catch (ApplicationException aex)
            {
                MessageBox.Show(aex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un problema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ValidarPasajero()
        {
            if (rbActivo.Checked)
                _pasajero.Estado = true;
            if (rbInactivo.Checked)
                _pasajero.Estado = false;
        }
        private void BajarPasajero()
        {
            _pasajerosServicio.DarBajaPasajero(_pasajero);
            MessageBox.Show("La operación se realizó con éxito", "Información");
        }
        private bool ConfirmarOperacion()
        {
            var resultado = MessageBox.Show("Confimar Operación", "Verificación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resultado == DialogResult.Cancel) { return false; }
            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _frmPasajeros.Show();
            this.Dispose();
        }

        private void rbInactivo_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
