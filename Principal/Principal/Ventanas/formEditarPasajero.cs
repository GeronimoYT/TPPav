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
    public partial class formEditarPasajero : Form
    {
        private PasajerosServicio _pasajerosServicio;
        private formPasajeros _frmPasajeros;
        private Pasajero _pasajero;
        public formEditarPasajero(formPasajeros formPasajeros, string nroDoc)
        {
            _pasajerosServicio = new PasajerosServicio();
            _pasajero = _pasajerosServicio.ObtenerPasajero(nroDoc);
            _frmPasajeros = formPasajeros;
            InitializeComponent();
        }

        private void formEditarPasajero_Load(object sender, EventArgs e)
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

        }
        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _frmPasajeros.Show();
            _frmPasajeros.ConsultarPasajeros();
            this.Dispose();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ConfirmarOperacion()) { return; }
                ValidarPasajero();
                RegistrarPasajero();

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
        private bool ConfirmarOperacion()
        {
            var resultado = MessageBox.Show("Confimar Operación", "Verificación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resultado == DialogResult.Cancel) { return false; }
            return true;
        }
        private void ValidarPasajero()
        {
            
            _pasajero.NroDocumento = txtNroDocumento.Text;
            _pasajero.Apellido = txtApellido.Text;
            _pasajero.Nombre = txtNombre.Text;
            _pasajero.Telefono = txtTelefono.Text;
            _pasajero.Email = txtEmail.Text;
            _pasajerosServicio.ValidarPasajero(_pasajero);

        }
        public void RegistrarPasajero()
        {
            _pasajerosServicio.ActualizarPasajero(_pasajero);
            MessageBox.Show("La operación se realizó con éxito", "Información");
            _frmPasajeros.Show();
            this.Dispose();

        }
        private void txtTelefono_KeypressKeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }
    }
}
