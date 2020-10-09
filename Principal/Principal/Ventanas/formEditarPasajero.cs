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
        public formEditarPasajero(formPasajeros formPasajeros, string tipoDoc, string nroDoc)
        {
            _pasajerosServicio = new PasajerosServicio();
            _pasajero = _pasajerosServicio.ObtenerPasajero(tipoDoc, nroDoc);
            _frmPasajeros = formPasajeros;
            InitializeComponent();
        }

        private void formEditarPasajero_Load(object sender, EventArgs e)
        {
            CargarDatos();
            CargarTipoDocumento();
        }
        private void CargarDatos()
        {
            //cmbTipoDocumento.Text = _pasajero.TipoDocumento;
            txtNroDocumento.Text = _pasajero.NroDocumento;
            txtApellido.Text = _pasajero.Apellido;
            txtNombre.Text = _pasajero.Nombre;
            txtTelefono.Text = _pasajero.Telefono;
            txtEmail.Text = _pasajero.Email;

        }
        private void CargarTipoDocumento()
        {

            cmbTipoDocumento.Items.Add("DNI");
            cmbTipoDocumento.Items.Add("Pasaporte");

            if (_pasajero.TipoDocumento == "DNI")
            {
                cmbTipoDocumento.SelectedItem = "DNI";
            }
            if (_pasajero.TipoDocumento == "Pasaporte")
            {
                cmbTipoDocumento.SelectedItem = "Pasaporte";
            }
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
            _pasajero.TipoDocumento = Convert.ToString(cmbTipoDocumento.SelectedItem);
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
    }
}
