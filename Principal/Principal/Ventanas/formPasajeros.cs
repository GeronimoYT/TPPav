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
        private void CargarTipoDocumento()
        {
            /*
            var pasajeros = _pasajerosServicio.ObtenerPasajeros();
            //var tipoDocumentoSeleccionado = pasajeros.First();
            //me conecto los datos al combo
            var conector = new BindingSource();
            conector.DataSource = pasajeros;
            cmbTipoDocumento.DataSource = conector;
            //que es lo que se va a mostara en el combo
            cmbTipoDocumento.DisplayMember = "TipoDocumento";
            // el nro de  documento del tipo documeno que voy a mostrar
            cmbTipoDocumento.ValueMember = "NroDocumento";
            //cmbTipoDocumento.SelectedItem = tipoDocumentoSeleccionado;*/

            cmbTipoDocumento.Items.Add("DNI");
            cmbTipoDocumento.Items.Add("Pasaporte");
        }
        private void CargarGrilla(List<Pasajero> pasajeros)
        {
            dgvPasajeros.Rows.Clear();
            foreach (var pasajero in pasajeros)
            {
                var fila = new String[] {
                pasajero.TipoDocumento,
                pasajero.NroDocumento,
                //pasajero.Apellido,
                //pasajero.Nombre,
                pasajero.Email,
                pasajero.Telefono,
                };
                dgvPasajeros.Rows.Add(fila);
            }
        }
        public void ConsultarPasajeros()
        {
            var tipoDocumentoIngresado = Convert.ToString(cmbTipoDocumento.SelectedItem);
            var nroDocumentoIngresado = txtNroDocumento.Text;
            var nombreIngresado = txtNombre.Text;
            var apellidoIngresado = txtApellido.Text;
            var incluirEnBaja = ckIncluirEnBaja.Checked;
            var pasajeros = _pasajerosServicio.ObtenerPasajeros(tipoDocumentoIngresado, nroDocumentoIngresado, apellidoIngresado, nombreIngresado, incluirEnBaja);
            CargarGrilla(pasajeros);
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
