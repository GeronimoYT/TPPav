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
    public partial class formPasajes : Form
    {
        private PasajesServicio _pasajesServicio;
        private EmbarquesServicio _embarquesServicio;
        private PasajerosServicio _pasajerosServicio;
        private TipoPasajesServicio _tipoPasajesServicio;
        private TipoDocumentosServicio _tipoDocumentosServicio;
        private formPrincipal _frmPrincipal;

        public formPasajes(formPrincipal principal)
        {
            _pasajesServicio = new PasajesServicio();
            _embarquesServicio = new EmbarquesServicio();
            _pasajerosServicio = new PasajerosServicio();
            _tipoPasajesServicio = new TipoPasajesServicio();
            _tipoDocumentosServicio = new TipoDocumentosServicio();
            _frmPrincipal = principal;
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            new formAltaPasaje(this).Show();
            this.Hide();
        }

        private void formPasajes_Load(object sender, EventArgs e)
        {
            CargarTipoDocumento();
            CargarTipoPasaje();
            Consultar(new PasajesFiltros());
        }
        private void CargarTipoDocumento()
        {

            var tipoDocumentos = _tipoDocumentosServicio.ObtenerTipoDocumentos();
            var tipoDocumentosSeleccionar = new TipoDocumento();
            tipoDocumentosSeleccionar.Id = "Seleccionar";
            tipoDocumentos.Add(tipoDocumentosSeleccionar);
            var conector = new BindingSource();
            conector.DataSource = tipoDocumentos;

            FormUtils.CargarCombo(ref cmbTipoDocumento, conector, "Id", "Id");
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

            FormUtils.CargarCombo(ref cmbTipoPasaje, conector, "Detalle", "Id");
            var tipoPasajeSeleccionado = tipoPasajes.First(tp => tp.Detalle == "Seleccionar");
            cmbTipoPasaje.SelectedItem = tipoPasajeSeleccionado;
        }
        public void Consultar(PasajesFiltros pasajesFiltros)
        {
            try
            {
                var filtros = pasajesFiltros;
                var pasajes = _pasajesServicio.ObtenerPasajes(filtros);
                CargarGrilla(pasajes);
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            _frmPrincipal.Show();
            this.Dispose();
        }
        
        private void CargarGrilla(List<Pasaje> pasajes)
        {
            dgvPasajes.Rows.Clear();
            foreach (var pasaje in pasajes)
            {
                var fila = new String[] {
                pasaje.Id.ToString(),
                pasaje.Precio.ToString(),
                ///pasaje.Descripcion
                };
                dgvPasajes.Rows.Add(fila);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            var filtros = new PasajesFiltros
            {
                NroDocumento = (txtNroDocumento.Text).ToString(),
                TipoDocumento = ((TipoDocumento)cmbTipoDocumento.SelectedItem).Id,
                TipoPasajeId = ((TipoPasaje)cmbTipoPasaje.SelectedItem).Id,

            };
            Consultar(filtros);
        }
    }
}
