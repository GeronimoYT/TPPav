using Principal.Clases;
using Principal.Clases.Filtros;
using Principal.Clases.Servicios;
using Principal.Transacciones.Pasajes;
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

        private PasajerosServicio _pasajerosServicio;
        private TipoPasajesServicio _tipoPasajesServicio;
        private TipoDocumentosServicio _tipoDocumentosServicio;
        private formPrincipal _frmPrincipal;

        public formPasajes(formPrincipal principal)
        {
            _pasajesServicio = new PasajesServicio();
            //_embarquesServicio = new EmbarquesServicio();
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
                var fila = new string[] {
                    pasaje.Id.ToString(),
                    pasaje.IdTipoPasaje.Id.ToString(),
                    pasaje.IdTipoPasaje.Detalle,
                    pasaje.TipoDocumento.Id,
                    pasaje.NroDocumento.NroDocumento,

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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvPasajes.SelectedRows.Count == 1)
            {
                var filtros = new PasajesFiltros
                {
                    Id = Convert.ToInt32(dgvPasajes.SelectedRows[0].Cells["idPasaje"].Value.ToString()),
                    TipoDocumento = dgvPasajes.SelectedRows[0].Cells["tipoDocumento"].Value.ToString(),
                    NroDocumento = dgvPasajes.SelectedRows[0].Cells["nroDocumento"].Value.ToString(),

                };
                new formEditarPasaje(this, filtros).Show();
                this.Hide();
            }
            else
            { MessageBox.Show("Debe seleccionar solo una fila", "Información"); }
        }
    }
}
