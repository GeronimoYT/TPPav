using Principal.Clases;
using Principal.Clases.Filtros;
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
    public partial class formAltaPasaje : Form
    {
        private PasajesServicio _pasajesServicio;
        private PasajerosServicio _pasajerosServicio;
        private formPasajes _frmPasajes;
        private TipoDocumentosServicio _tipoDocumentosServicio;
        private TipoPasajesServicio _tipoPasajesServicio;
        private Pasaje _pasaje;
        private bool flagCargado = false;
        private bool flagPrueba = false;

        public formAltaPasaje(formPasajes frmPasajes)
        {
            _pasajerosServicio = new PasajerosServicio();
            _pasajesServicio = new PasajesServicio();
            _tipoDocumentosServicio = new TipoDocumentosServicio();
            _tipoPasajesServicio = new TipoPasajesServicio();
            _frmPasajes = frmPasajes;
            InitializeComponent();
        }

        private void formAltaPasaje_Load(object sender, EventArgs e)
        {
            CargarTipoDocumento();
            CargarTipoPasaje();
            CargarNroDocumento();
            
            if (((TipoDocumento)cmbTipoDocumento.SelectedItem).Id == "Seleccionar") { cmbNroDocumento.Enabled = false; }
            flagCargado = true;
            /*if (((Pasajero)cmbNroDocumento.SelectedItem).NroDocumento != "Seleccionar" &&
                flagCargado && ((TipoDocumento)cmbTipoDocumento.SelectedItem).Id != "Seleccionar") { CargarPasajero(); }*/
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
            var tipoDocumentoSeleccionado = tipoDocumentos.First(tp => tp.Id == "Seleccionar");
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
            var tipoPasajeSeleccionado = tipoPasajes.First(tp => tp.Detalle == "Seleccionar");
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
            var nroDocumentosSeleccionado = nroDocumentos.First(tp => tp.NroDocumento == "Seleccionar");
            cmbNroDocumento.SelectedItem = nroDocumentosSeleccionado;
            if (flagCargado) { flagPrueba = true; }
            
        }
        public void CargarPasajero()
        {
            //Pasajero pasajero = new Pasajero();
            Pasajero pasajero =_pasajerosServicio.ObtenerPasajero(((TipoDocumento)cmbTipoDocumento.SelectedItem).Id,
                ((Pasajero) cmbNroDocumento.SelectedItem).NroDocumento);
            
            txtApellidoPasajero.Text = pasajero.Apellido;
            txtNombrePasajero.Text = pasajero.Nombre;
        }




        private void button2_Click(object sender, EventArgs e)
        {
            _frmPasajes.Show();
            this.Dispose();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ConfirmarOperacion()) return;
                ValidarPasaje();
                //if (!ValidarPasaje()) return;

                RegistrarPasaje(_pasaje);
                //CerrarForm();
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
                TipoDocumento = ((TipoDocumento)cmbTipoDocumento.SelectedItem).Id == "Seleccionar" ? null : (TipoDocumento)cmbTipoDocumento.SelectedItem,
                IdTipoPasaje = ((TipoPasaje)cmbTipoPasaje.SelectedItem).Id == 0 ? null : (TipoPasaje)cmbTipoPasaje.SelectedItem,
                NroDocumento = ((Pasajero)cmbNroDocumento.SelectedItem).NroDocumento == "Seleccionar" ? null : (Pasajero)cmbNroDocumento.SelectedItem
            };
            _pasaje = pasaje;
            //_pasaje = _pasajesServicio.Validar(pasaje);
        }
        private void RegistrarPasaje(Pasaje pasajero)
        {
            _pasajesServicio.RegistrarPasaje(_pasaje);
            MessageBox.Show("La operación se realizó con éxito");
            CerrarForm();
        }
        private void CerrarForm()
        {
            _frmPasajes.Show();
            _frmPasajes.Consultar(new PasajesFiltros());
            this.Dispose();
        }


        private void cmbTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((TipoDocumento)cmbTipoDocumento.SelectedItem).Id == "Seleccionar") 
            { 
                cmbNroDocumento.Enabled = false;
                txtApellidoPasajero.Text = "";
                txtNombrePasajero.Text = "";
                flagCargado = false;
            }
            else {
                cmbNroDocumento.Enabled = true;
                flagCargado = true;
                CargarNroDocumento();               
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CerrarForm();
        }

        private void cmbNroDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(flagPrueba && flagCargado && ((TipoDocumento)cmbTipoDocumento.SelectedItem).Id != "Seleccionar") { 
                if(((Pasajero)cmbNroDocumento.SelectedItem).NroDocumento != "Seleccionar") { CargarPasajero(); }
                 }
            if(((Pasajero)cmbNroDocumento.SelectedItem).NroDocumento == "Seleccionar")
            {
                txtApellidoPasajero.Text = "";
                txtNombrePasajero.Text = "";
            }
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            var formularioPasajeros = new formPasajeros(this);
            formularioPasajeros.ShowDialog();
        }
    }
}
