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
        private bool flagCargasLugares = false;

        private AeropuertosServicio _aeropuertosServicioOrigen;
        private AeropuertosServicio _aeropuertosServicioDestino;
        private EmbarquesServicio _embarquesServicio;
        private VuelosServicio _vuelosServicio;
        private bool registro = true;

        public formAltaPasaje(formPasajes frmPasajes)
        {
            _pasajerosServicio = new PasajerosServicio();
            _pasajesServicio = new PasajesServicio();
            _embarquesServicio = new EmbarquesServicio();
            _tipoDocumentosServicio = new TipoDocumentosServicio();
            _tipoPasajesServicio = new TipoPasajesServicio();
            _aeropuertosServicioOrigen = new AeropuertosServicio();
            _aeropuertosServicioDestino = new AeropuertosServicio();
            _vuelosServicio = new VuelosServicio();
            
            _frmPasajes = frmPasajes;
            InitializeComponent();
        }

        private void formAltaPasaje_Load(object sender, EventArgs e)
        {
            CargarTipoDocumento();
            CargarTipoPasaje();
            CargarNroDocumento();
            CargarAeropuertoOrigen();
            CargarAeropuertoDestino();
            //CargarEmbarque();
            //dtpFechaSalida, dtpFechaLlegada
            dtpFechaSalida.MinDate = DateTime.Now.AddDays(1);
            dtpFechaSalida.MaxDate = DateTime.Now.AddYears(2);
            dtpFechaLlegada.MinDate = DateTime.Now.AddDays(1);
            dtpFechaLlegada.MaxDate = DateTime.Now.AddYears(2);
            dtpFechaLlegada.Value = dtpFechaLlegada.MaxDate;
            //dtpFechaLlegada.
            if (((TipoDocumento)cmbTipoDocumento.SelectedItem).Id == "Seleccionar") { cmbNroDocumento.Enabled = false; }
            flagCargado = true;
            flagCargasLugares = true;
            
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

            var nroDocumentos = _pasajerosServicio.ObtenerPasajeros(((TipoDocumento)cmbTipoDocumento.SelectedItem).Id,registro);

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
        public void CargarAeropuertoOrigen()
        {
            var aeropuertos = _aeropuertosServicioOrigen.ObtenerAeropuertos();
            var aeropuertosSeleccionar = new Aeropuerto();

            aeropuertosSeleccionar.Domicilio = "Seleccionar";
            aeropuertos.Add(aeropuertosSeleccionar);
            var conector = new BindingSource();
            conector.DataSource = aeropuertos;
            FormUtils.CargarComboV2(ref cmbAeropuertoOrigen, conector, "Domicilio", "Domicilio");
            var aeropuertoSeleccionado = aeropuertos.First(tp => tp.Domicilio == "Seleccionar");
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
            var aeropuertoSeleccionado = aeropuertos.First(tp => tp.Domicilio == "Seleccionar");
            cmbAeropuertoDestino.SelectedItem = aeropuertoSeleccionado;
        }
        /*
        public void CargarEmbarque() 
        {
            var embarques = _embarquesServicio.ObtenerEmbarques();
            var embarquesSeleccionar = new Embarque();
            embarquesSeleccionar.PuertaEmbarque = 0;
            embarques.Add(embarquesSeleccionar);
            var conector = new BindingSource();
            conector.DataSource = embarques;
            FormUtils.CargarComboV2(ref cmbEmbarque, conector, "PuertaEmbarque", "PuertaEmbarque");
            var embarqueSeleccionado = embarques.First(tp => tp.PuertaEmbarque == 0);
            cmbEmbarque.SelectedItem = embarqueSeleccionado;
        }*/
        /*
        public void CargarVuelo()
        {
            var embarques = _embarquesServicio.ObtenerEmbarques();
            var embarquesSeleccionar = new Embarque();
            embarquesSeleccionar.PuertaEmbarque = 0;
            embarques.Add(embarquesSeleccionar);
            var conector = new BindingSource();
            conector.DataSource = embarques;
            FormUtils.CargarComboV2(ref cmbEmbarque, conector, "PuertaEmbarque", "PuertaEmbarque");
            var embarqueSeleccionado = embarques.First(tp => tp.PuertaEmbarque == 0);
            cmbEmbarque.SelectedItem = embarqueSeleccionado;
        }*/

        private void CargarGrilla()
        {
            /*var vuelos = _vuelosServicio.ObtenerVuelos(((Aeropuerto)cmbAeropuertoOrigen.SelectedItem).IdAeropuerto, 
                ((Aeropuerto)cmbAeropuertoDestino.SelectedItem).IdAeropuerto);*/
            var vuelos = _vuelosServicio.ObtenerVuelos(((Aeropuerto)cmbAeropuertoOrigen.SelectedItem).Domicilio,
                ((Aeropuerto)cmbAeropuertoDestino.SelectedItem).Domicilio, dtpFechaSalida.Value, dtpFechaLlegada.Value);
            /*var embarques = _embarquesServicio.ObtenerEmbarques(((Aeropuerto)cmbAeropuertoOrigen.SelectedItem).Domicilio,
                ((Aeropuerto)cmbAeropuertoDestino.SelectedItem).Domicilio);*/

            dgvVuelos.Rows.Clear();
            foreach (var vuelo in vuelos)
            {
                var fila = new string[] {
                    /*embarque.PuertaEmbarque.ToString(),
                    embarque.FechaHoraEmbarque.ToString("dd/MM/yyyy"),
                    embarque.Estado.IdEstado.ToString(),*/
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

            if (dgvVuelos.SelectedRows.Count == 1)
            {
                var aeropuertoOrigen = new Aeropuerto(Convert.ToInt32(dgvVuelos.SelectedRows[0].Cells["IdAeropuertoOrigen"].Value.ToString()));
                var aeropuertoDestino = new Aeropuerto(Convert.ToInt32(dgvVuelos.SelectedRows[0].Cells["IdAeropuertoDestino"].Value.ToString()));
                var vuelo = new VueloV2(Convert.ToInt32(dgvVuelos.SelectedRows[0].Cells["NroVuelo"].Value.ToString()),
                    Convert.ToDateTime(dgvVuelos.SelectedRows[0].Cells["FechaHoraSalida"].Value.ToString()),
                    Convert.ToDateTime(dgvVuelos.SelectedRows[0].Cells["FechaHoraLlegada"].Value.ToString()),
                    Convert.ToInt32(dgvVuelos.SelectedRows[0].Cells["DuracionMinutos"].Value.ToString()),
                    Convert.ToInt32(dgvVuelos.SelectedRows[0].Cells["NroAvion"].Value.ToString()));
                

                /*var embarque = new EmbarqueV2(Convert.ToDateTime(dgvVuelos.SelectedRows[0].Cells["FechaHoraEmbarque"].Value.ToString())
                    , Convert.ToInt32(dgvVuelos.SelectedRows[0].Cells["PuertaEmbarque"].Value.ToString()));
                embarque.Estado = new Estado(Convert.ToInt32(dgvVuelos.SelectedRows[0].Cells["IdEstadoEmbarque"].Value.ToString()));*/

                var pasaje = new Pasaje()
                {
                    TipoDocumento = ((TipoDocumento)cmbTipoDocumento.SelectedItem).Id == "Seleccionar" ? null : (TipoDocumento)cmbTipoDocumento.SelectedItem,
                    IdTipoPasaje = ((TipoPasaje)cmbTipoPasaje.SelectedItem).Id == 0 ? null : (TipoPasaje)cmbTipoPasaje.SelectedItem,
                    NroDocumento = ((Pasajero)cmbNroDocumento.SelectedItem).NroDocumento == "Seleccionar" ? null : (Pasajero)cmbNroDocumento.SelectedItem,
                    //AeropuertoOrigen = ((Aeropuerto)cmbAeropuertoOrigen.SelectedItem).IdAeropuerto == 0 ? null : (Aeropuerto)cmbAeropuertoOrigen.SelectedItem,
                    //AeropuertoDestino = ((Aeropuerto)cmbAeropuertoDestino.SelectedItem).IdAeropuerto == 0 ? null : (Aeropuerto)cmbAeropuertoDestino.SelectedItem,
                    AeropuertoDestino = aeropuertoDestino,
                    AeropuertoOrigen = aeropuertoOrigen,
                    Vuelo = vuelo,
                    Motivo = txtDecripcion.Text,
                    //Embarque = embarque,

                };
                _pasaje = _pasajesServicio.ValidarPasaje(pasaje);
            }
            
            
            //_pasaje = _pasajesServicio.Validar(pasaje);
        }
        private void RegistrarPasaje(Pasaje pasajero)
        {
            if (dgvVuelos.SelectedRows.Count == 1) 
            {
                _pasajesServicio.RegistrarPasaje(_pasaje);
                MessageBox.Show("La operación se realizó con éxito");
                CerrarForm();
            }
            else
            { MessageBox.Show("Debe seleccionar un Vuelo", "Información"); }
            
            
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
            this.Hide();
            formularioPasajeros.ShowDialog();
            CargarTipoDocumento();
            CargarTipoPasaje();
            if (((TipoDocumento)cmbTipoDocumento.SelectedItem).Id == "Seleccionar") { cmbNroDocumento.Enabled = false; }
            flagCargado = true;
        }

       

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void dgvVuelos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        

        private void cmbAeropuertoOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if (flagCargasLugares) {
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dtpFechaSalida_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
