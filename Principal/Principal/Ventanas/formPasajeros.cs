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
            
        }
        
        private void CargarGrilla(List<Pasajero> pasajeros)
        {
            dgvPasajeros.Rows.Clear();
            foreach (var pasajero in pasajeros)
            {
                var fila = new String[] {
                pasajero.NroDocumento,
                pasajero.Apellido,
                pasajero.Nombre,
                pasajero.Email,
                pasajero.Telefono,
                };
                dgvPasajeros.Rows.Add(fila);
            }
        }
        public void ConsultarPasajeros()
        {
            
            var nroDocumentoIngresado = txtNroDocumento.Text;
            var nombreIngresado = txtNombre.Text;
            var apellidoIngresado = txtApellido.Text;
            var incluirEnBaja = ckIncluirEnBaja.Checked;
            var pasajeros = _pasajerosServicio.ObtenerPasajeros(nroDocumentoIngresado, apellidoIngresado, nombreIngresado, incluirEnBaja);
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
                
                var nroDoc = dgvPasajeros.SelectedRows[0].Cells["nroDocumento"].Value.ToString();
                new formEditarPasajero(this, nroDoc).Show();
                this.Hide();
            }
            else
            { MessageBox.Show("Debe seleccionar solo una fila", "Información"); }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dgvPasajeros.SelectedRows.Count == 1)
            {
                
                var nroDoc = dgvPasajeros.SelectedRows[0].Cells["nroDocumento"].Value.ToString();
                new formBajaPasajero(this, nroDoc).Show();
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

        private void txtNroDocumento_KeypressKeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

    }
}
