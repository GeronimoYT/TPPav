using Principal.Clases;
using Principal.Clases.Filtros;
using Principal.Clases.Servicios;
using Principal.Utils;
using Principal.Ventanas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal.Transacciones.Pasajes
{
    public partial class formEditarPasaje : Form
    {
        private PasajesServicio _pasajesServicio;
        private PasajerosServicio _pasajerosServicio;
        private formPasajes _frmPasajes;
        private TipoDocumentosServicio _tipoDocumentosServicio;
        private TipoPasajesServicio _tipoPasajesServicio;
        private Pasaje _pasaje;
        public formEditarPasaje(formPasajes frmPasajes, PasajesFiltros f)
        {
            _pasajerosServicio = new PasajerosServicio();
            _pasajesServicio = new PasajesServicio();
            //_pasajero = new Pasajero();
            _frmPasajes = frmPasajes;
            _tipoDocumentosServicio = new TipoDocumentosServicio();
            _tipoPasajesServicio = new TipoPasajesServicio();
            _pasaje = _pasajesServicio.ObtenerPasaje(f);
            InitializeComponent();
        }
        private void formEditarPasaje_Load(object sender, EventArgs e)
        {
            CargarDatos();
            CargarTipoDocumento();
            CargarTipoPasaje();
            CargarNroDocumento();
            
        }
        private void CargarDatos()
        {
            //cmbTipoDocumento.Text = _pasajero.TipoDocumento;
            txtNroPasaje.Text = _pasaje.Id.ToString();
            /*txtApellido.Text = _pasajero.Apellido;
            txtNombre.Text = _pasajero.Nombre;
            txtTelefono.Text = _pasajero.Telefono;
            txtEmail.Text = _pasajero.Email;
            dtpFechaNacimiento.Value = _pasajero.FechaNacimiento;*/
        }
        private void CargarTipoDocumento()
        {

            var tipoDocumentos = _tipoDocumentosServicio.ObtenerTipoDocumentos();
            var tipoDocumentosSeleccionar = new TipoDocumento();
            tipoDocumentosSeleccionar.Id = "Seleccionar";
            tipoDocumentos.Add(tipoDocumentosSeleccionar);
            var conector = new BindingSource();
            conector.DataSource = tipoDocumentos;

            FormUtils.CargarComboV2(ref cmbTipoDocumento, conector, "Id", "Id");
            var tipoDocumentoSeleccionado = tipoDocumentos.First(tp => tp.Id == _pasaje.TipoDocumento.Id);
            cmbTipoDocumento.SelectedItem = tipoDocumentoSeleccionado;

        }
        private void CargarTipoPasaje()
        {
            var tipoPasajes = _tipoPasajesServicio.ObtenerTipoPasajes();
            var tipoPasajesSeleccionar = new TipoPasaje();
            tipoPasajesSeleccionar.Detalle = "Seleccionar";
            tipoPasajes.Add(tipoPasajesSeleccionar);

            var conector = new BindingSource();
            conector.DataSource = tipoPasajes;

            FormUtils.CargarComboV2(ref cmbTipoPasaje, conector, "Detalle", "Id");
            var tipoPasajeSeleccionado = tipoPasajes.First(tp => tp.Detalle == _pasaje.IdTipoPasaje.Detalle);
            cmbTipoPasaje.SelectedItem = tipoPasajeSeleccionado;
        }
        private void CargarNroDocumento()
        {

            var nroDocumentos = _pasajerosServicio.ObtenerPasajeros(((TipoDocumento)cmbTipoDocumento.SelectedItem).Id);

            var nroDocumentosSeleccionar = new Pasajero();
            nroDocumentosSeleccionar.NroDocumento = "Seleccionar";
            nroDocumentos.Add(nroDocumentosSeleccionar);
            var conector = new BindingSource();
            conector.DataSource = nroDocumentos;

            FormUtils.CargarComboV2(ref cmbNroDocumento, conector, "NroDocumento", "TipoDocumento");
            var nroDocumentosSeleccionado = nroDocumentos.First(tp => tp.NroDocumento == _pasaje.NroDocumento.NroDocumento);
            cmbNroDocumento.SelectedItem = nroDocumentosSeleccionado;

        }
        public void CerrarVentana()
        {
            _frmPasajes.Show();
            _frmPasajes.Consultar(new PasajesFiltros());
            this.Dispose();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ConfirmarOperacion()) { return; }
                ValidarPasaje();
                RegistrarPasaje(_pasaje);

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
        private void ValidarPasaje()
        {
            var pasaje = new Pasaje()
            {
                Id = _pasaje.Id,
                TipoDocumento = ((TipoDocumento)cmbTipoDocumento.SelectedItem).Id == "Seleccionar" ? null : (TipoDocumento)cmbTipoDocumento.SelectedItem,
                IdTipoPasaje = ((TipoPasaje)cmbTipoPasaje.SelectedItem).Id == 0 ? null : (TipoPasaje)cmbTipoPasaje.SelectedItem,
                NroDocumento = ((Pasajero)cmbNroDocumento.SelectedItem).NroDocumento == "Seleccionar" ? null : (Pasajero)cmbNroDocumento.SelectedItem
            };
            _pasaje = pasaje;
            //_pasaje = _pasajesServicio.Validar(pasaje);
        }
        private void RegistrarPasaje(Pasaje pasajero)
        {
            _pasajesServicio.ActualizarPasaje(_pasaje);
            MessageBox.Show("La operación se realizó con éxito");
            CerrarVentana();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CerrarVentana();
        }

        private void cmbTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
