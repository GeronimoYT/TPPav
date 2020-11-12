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
        private AeropuertosServicio _aeropuertosServicioOrigen;
        private AeropuertosServicio _aeropuertosServicioDestino;
        private EmbarquesServicio _embarquesServicio;
        private VuelosServicio _vuelosServicio;

        private bool flagCargado = false;
        private bool flagPrueba = false;
        private bool flagCargasLugares = false;
        private bool registro = false;
        public formEditarPasaje(formPasajes frmPasajes, PasajesFiltros f)
        {
            _pasajerosServicio = new PasajerosServicio();
            _pasajesServicio = new PasajesServicio();
            //_pasajero = new Pasajero();
            _frmPasajes = frmPasajes;
            _tipoDocumentosServicio = new TipoDocumentosServicio();
            _tipoPasajesServicio = new TipoPasajesServicio();
            _aeropuertosServicioOrigen = new AeropuertosServicio();
            _aeropuertosServicioDestino = new AeropuertosServicio();
            _embarquesServicio = new EmbarquesServicio();
            _vuelosServicio = new VuelosServicio();
            _pasaje = _pasajesServicio.ObtenerPasaje(f);
            InitializeComponent();
        }
        private void formEditarPasaje_Load(object sender, EventArgs e)
        {
            CargarDatos();
            CargarTipoDocumento();
            CargarNroDocumento();
            CargarPasajero();
            CargarTipoPasaje();
            CargarNroDocumento();
            CargarAeropuertoOrigen();
            CargarAeropuertoDestino();
            dtpFechaSalida.MinDate = DateTime.Now.AddDays(1);
            dtpFechaSalida.MaxDate = DateTime.Now.AddYears(2);
            dtpFechaLlegada.MinDate = DateTime.Now.AddDays(1);
            dtpFechaLlegada.MaxDate = DateTime.Now.AddYears(2);
            dtpFechaLlegada.Value = dtpFechaLlegada.MaxDate;
            CargarGrilla();
            flagCargasLugares = true;

        }
        private void CargarDatos()
        {
            //cmbTipoDocumento.Text = _pasajero.TipoDocumento;
            txtNroPasaje.Text = _pasaje.Id.ToString();
            txtDecripcion.Text = _pasaje.Motivo;
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

            var nroDocumentos = _pasajerosServicio.ObtenerPasajeros(((TipoDocumento)cmbTipoDocumento.SelectedItem).Id,registro);

            var nroDocumentosSeleccionar = new Pasajero();
            nroDocumentosSeleccionar.NroDocumento = "Seleccionar";
            nroDocumentos.Add(nroDocumentosSeleccionar);
            var conector = new BindingSource();
            conector.DataSource = nroDocumentos;

            FormUtils.CargarComboV2(ref cmbNroDocumento, conector, "NroDocumento", "TipoDocumento");
            var nroDocumentosSeleccionado = nroDocumentos.First(tp => tp.NroDocumento == _pasaje.NroDocumento.NroDocumento);
            cmbNroDocumento.SelectedItem = nroDocumentosSeleccionado;

        }
        public void CargarAeropuertoOrigen()
        {
            var aeropuertos = _aeropuertosServicioOrigen.ObtenerAeropuertos();
            var aeropuertosSeleccionar = new Aeropuerto();

            aeropuertosSeleccionar.Domicilio = "Seleccionar";
            aeropuertos.Add(aeropuertosSeleccionar);
            var conector = new BindingSource();
            conector.DataSource = aeropuertos;
            FormUtils.CargarComboV2(ref cmbAeropuertoOrigen, conector, "Domicilio", "Domicilio");
            var aeropuertoSeleccionado = aeropuertos.First(tp => tp.Domicilio == _pasaje.AeropuertoOrigen.Domicilio);
            cmbAeropuertoOrigen.SelectedItem = aeropuertoSeleccionado;
        }
        public void CargarAeropuertoDestino()
        {
            var aeropuertos = _aeropuertosServicioDestino.ObtenerAeropuertos();
            var aeropuertosSeleccionar = new Aeropuerto();

            aeropuertosSeleccionar.Domicilio = "Seleccionar";
            aeropuertos.Add(aeropuertosSeleccionar);
            var conector = new BindingSource();
            conector.DataSource = aeropuertos;
            FormUtils.CargarComboV2(ref cmbAeropuertoDestino, conector, "Domicilio", "Domicilio");
            var aeropuertoSeleccionado = aeropuertos.First(tp => tp.Domicilio == _pasaje.AeropuertoDestino.Domicilio);
            cmbAeropuertoDestino.SelectedItem = aeropuertoSeleccionado;
        }
        public void CargarPasajero()
        {
            //Pasajero pasajero = new Pasajero();
            Pasajero pasajero = _pasajerosServicio.ObtenerPasajero(((TipoDocumento)cmbTipoDocumento.SelectedItem).Id,
                ((Pasajero)cmbNroDocumento.SelectedItem).NroDocumento);

            txtApellidoPasajero.Text = pasajero.Apellido;
            txtNombrePasajero.Text = pasajero.Nombre;
        }
        private void CargarGrilla()
        {
            
            var vuelos = _vuelosServicio.ObtenerVuelos(((Aeropuerto)cmbAeropuertoOrigen.SelectedItem).Domicilio,
                ((Aeropuerto)cmbAeropuertoDestino.SelectedItem).Domicilio, dtpFechaSalida.Value, dtpFechaLlegada.Value);
            dgvVuelos.Rows.Clear();
            foreach (var vuelo in vuelos)
            {
                var fila = new string[] {
                    
                    vuelo.NroVuelo.ToString(),
                    vuelo.IdAeropuerto.IdAeropuerto.ToString(),
                    vuelo.IdAeropuerto.Nombre,
                    vuelo.IdAeropuerto.Domicilio,
                    vuelo.IdAeropuertoDestino.IdAeropuerto.ToString(),
                    vuelo.IdAeropuertoDestino.Nombre,
                    vuelo.IdAeropuertoDestino.Domicilio,
                    vuelo.FechaHoraSalida.ToString("dd/MM/yyyy hh:mm"),
                    vuelo.FechaHoraLlegada.ToString("dd/MM/yyyy hh:mm"),
                    vuelo.Minutos.ToString(),
                    vuelo.Avion.NroAvion.ToString(),
                    vuelo.Avion.TipoAvion.id.ToString(),
                    vuelo.Avion.TipoAvion.descripcion,

                };
                dgvVuelos.Rows.Add(fila);

            }
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
            if (dgvVuelos.SelectedRows.Count == 1)
            {
                var aeropuertoOrigen = new Aeropuerto(Convert.ToInt32(dgvVuelos.SelectedRows[0].Cells["IdAeropuertoOrigen"].Value.ToString()));
                var aeropuertoDestino = new Aeropuerto(Convert.ToInt32(dgvVuelos.SelectedRows[0].Cells["IdAeropuertoDestino"].Value.ToString()));
                var vuelo = new VueloV2(Convert.ToInt32(dgvVuelos.SelectedRows[0].Cells["NroVuelo"].Value.ToString()),
                    Convert.ToDateTime(dgvVuelos.SelectedRows[0].Cells["FechaHoraSalida"].Value.ToString()),
                    Convert.ToDateTime(dgvVuelos.SelectedRows[0].Cells["FechaHoraLlegada"].Value.ToString()),
                    Convert.ToInt32(dgvVuelos.SelectedRows[0].Cells["DuracionMinutos"].Value.ToString()),
                    Convert.ToInt32(dgvVuelos.SelectedRows[0].Cells["NroAvion"].Value.ToString()));
                

                var pasaje = new Pasaje()
                {
                    Id = _pasaje.Id,
                    TipoDocumento = ((TipoDocumento)cmbTipoDocumento.SelectedItem).Id == "Seleccionar" ? null : (TipoDocumento)cmbTipoDocumento.SelectedItem,
                    IdTipoPasaje = ((TipoPasaje)cmbTipoPasaje.SelectedItem).Id == 0 ? null : (TipoPasaje)cmbTipoPasaje.SelectedItem,
                    NroDocumento = ((Pasajero)cmbNroDocumento.SelectedItem).NroDocumento == "Seleccionar" ? null : (Pasajero)cmbNroDocumento.SelectedItem,
                    //AeropuertoOrigen = ((Aeropuerto)cmbAeropuertoOrigen.SelectedItem).IdAeropuerto == 0 ? null : (Aeropuerto)cmbAeropuertoOrigen.SelectedItem,
                    //AeropuertoDestino = ((Aeropuerto)cmbAeropuertoDestino.SelectedItem).IdAeropuerto == 0 ? null : (Aeropuerto)cmbAeropuertoDestino.SelectedItem,
                    AeropuertoDestino = aeropuertoDestino,
                    AeropuertoOrigen = aeropuertoOrigen,
                    Vuelo = vuelo,
                    Motivo = txtDecripcion.Text,
                    

                };
                _pasaje = _pasajesServicio.ValidarPasaje(pasaje);
            }
        }
        private void RegistrarPasaje(Pasaje pasajero)
        {
            if (dgvVuelos.SelectedRows.Count == 1)
            {
                _pasajesServicio.ActualizarPasaje(_pasaje);
                MessageBox.Show("La operación se realizó con éxito");
                CerrarVentana();
            }
            else
            { MessageBox.Show("Debe seleccionar un Vuelo", "Información"); }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CerrarVentana();
        }

        private void cmbTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbTipoDocumento_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void cmbNroDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbAeropuertoOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if (flagCargasLugares)
            {
                CargarGrilla();

            }*/
        }

        private void cmbAeropuertoDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if (flagCargasLugares)
            {
                CargarGrilla();

            }*/
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            var formularioPasajeros = new formPasajeros(this);
            this.Hide();
            formularioPasajeros.ShowDialog();
            CargarTipoDocumento();
            CargarTipoPasaje();
            if (((TipoDocumento)cmbTipoDocumento.SelectedItem).Id == "Seleccionar") { cmbNroDocumento.Enabled = false; }
            flagCargado = true;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            CargarGrilla();
        }
    }
}
