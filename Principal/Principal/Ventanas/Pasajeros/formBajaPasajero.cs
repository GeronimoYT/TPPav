using Principal.Clases;
using Principal.Clases.Servicios;
using Principal.Utils;
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
        private TipoDocumentosServicio _tipoDocumentosServicio;
        public formBajaPasajero(formPasajeros formPasajeros, string tipoDoc, string nroDoc)
        {
            _tipoDocumentosServicio = new TipoDocumentosServicio();
            _pasajerosServicio = new PasajerosServicio();
            _pasajero = _pasajerosServicio.ObtenerPasajero(tipoDoc, nroDoc);
            _frmPasajeros = formPasajeros;
            InitializeComponent();
        }

        private void formBajaPasajero_Load(object sender, EventArgs e)
        {
            CargarDatos();
            CargarTipoDocumento();

        }
        private void CargarTipoDocumento()
        {


            var tipoDocumentos = _tipoDocumentosServicio.ObtenerTipoDocumentos();
            tipoDocumentos.Add(new TipoDocumento
            {
                Id = "Seleccionar"
            });
            var conector = new BindingSource();
            conector.DataSource = tipoDocumentos;
            FormUtils.CargarCombo(ref cmbTipoDocumento, conector, "Id", "Id");
            var tipoDocumentoSeleccionado = tipoDocumentos.First(tp => tp.Id == _pasajero.TipoDocumento.Id);
            cmbTipoDocumento.SelectedItem = tipoDocumentoSeleccionado;


        }
        private void CargarDatos()
        {
            txtNroDocumento.Text = _pasajero.NroDocumento;
            txtApellido.Text = _pasajero.Apellido;
            txtNombre.Text = _pasajero.Nombre;
            txtTelefono.Text = _pasajero.Telefono;
            txtEmail.Text = _pasajero.Email;
            dtpFechaNacimiento.Value = _pasajero.FechaNacimiento;
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
            _frmPasajeros.Show();
            this.Dispose();
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
