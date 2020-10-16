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
    public partial class formPasajeros : Form
    {
        private PasajerosServicio _pasajerosServicio;
        private formPrincipal _frmPrincipal;

        public formPasajeros(formPrincipal principal)
        {
            _pasajerosServicio = new PasajerosServicio();
            _frmPrincipal = principal;
            InitializeComponent();
        }

        private void formPasajeros_Load(object sender, EventArgs e)
        {
            CargarTipoDocumento();
        }
        
        private void CargarGrilla(List<Pasajero> pasajeros)
        {
            dgvPasajeros.Rows.Clear();
            foreach (var pasajero in pasajeros)
            {
                var fila = new String[] {
                //pasajero.TipoDocumento?.Id,
                pasajero.TipoDocumento,
                pasajero.NroDocumento,
                pasajero.Apellido,
                pasajero.Nombre,
                pasajero.Email,
                pasajero.Telefono,
                pasajero.FechaNacimiento.ToString("dd/MM/yyyy"),
                pasajero.Edad.ToString()
                };
                dgvPasajeros.Rows.Add(fila);
            }
        }
        public void ConsultarPasajeros()
        {
            //var tipoDocumentoIngresado = (((TipoDocumento)cmbTipoDocumento.SelectedItem).Id).ToString();
            var tipoDocumentoIngresado = cmbTipoDocumento.SelectedItem.ToString();
            var nroDocumentoIngresado = txtNroDocumento.Text;
            var nombreIngresado = txtNombre.Text;
            var apellidoIngresado = txtApellido.Text;
            var incluirEnBaja = ckIncluirEnBaja.Checked;
            
            var pasajeros = _pasajerosServicio.ObtenerPasajeros(tipoDocumentoIngresado, nroDocumentoIngresado, apellidoIngresado, nombreIngresado, incluirEnBaja);
            CargarGrilla(pasajeros);
        }
        private void CargarTipoDocumento()
        {
            /*
            var tipoDocumentos = _tipoDocumentosServicio.ObtenerTipoDocumentos();
            tipoDocumentos.Add(new TipoDocumento
            {
                Id = "Seleccionar"
            });
            var conector = new BindingSource();
            conector.DataSource = tipoDocumentos;
            FormUtils.CargarCombo(ref cmbTipoDocumento, conector, "Id", "Id");
            var tipoDocumentoSeleccionado = tipoDocumentos.First(tp => tp.Id == "Seleccionar");
            cmbTipoDocumento.SelectedItem = tipoDocumentoSeleccionado;*/
            cmbTipoDocumento.Items.Add("Seleccionar");
            cmbTipoDocumento.Items.Add("DNI");
            cmbTipoDocumento.Items.Add("Pasaporte");
            cmbTipoDocumento.SelectedItem = "Seleccionar";



        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            new formAltaPasajero(this).Show();
            this.Hide();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvPasajeros.SelectedRows.Count == 1)
            {
                var tipoDoc = dgvPasajeros.SelectedRows[0].Cells["tipoDocumento"].Value.ToString();
                var nroDoc = dgvPasajeros.SelectedRows[0].Cells["nroDocumento"].Value.ToString();
                new formEditarPasajero(this, tipoDoc, nroDoc).Show();
                this.Hide();
            }
            else
            { MessageBox.Show("Debe seleccionar solo una fila", "Información"); }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dgvPasajeros.SelectedRows.Count == 1)
            {
                var tipoDoc = dgvPasajeros.SelectedRows[0].Cells["tipoDocumento"].Value.ToString();
                var nroDoc = dgvPasajeros.SelectedRows[0].Cells["nroDocumento"].Value.ToString();
                new formBajaPasajero(this, tipoDoc, nroDoc).Show();
                this.Hide();
            }
            else
                MessageBox.Show("Debe seleccionar solo una fila", "Información");
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ConsultarPasajeros();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            _frmPrincipal.Show();
            this.Dispose();
        }

        

    }
}
