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
    public partial class formAltaPasajero : Form
    {
        private PasajerosServicio _pasajerosServicio;
        private formPasajeros _frmPasajeros;
        private Pasajero _pasajero;
        private TipoDocumentosServicio _tipoDocumentosServicio;
        public formAltaPasajero(formPasajeros formPasajeros)
        {
            _tipoDocumentosServicio = new TipoDocumentosServicio();
            _pasajerosServicio = new PasajerosServicio();
            //_pasajero = new Pasajero();
            _frmPasajeros = formPasajeros;
            InitializeComponent();
        }

        private void formAltaPasajero_Load(object sender, EventArgs e)
        {
            dtpFechaNacimiento.MaxDate = DateTime.Now.AddDays(-7);
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
            FormUtils.CargarCombo(ref cmbTipoDocumento, conector, "Descripcion", "Id");
            var tipoDocumentoSeleccionado = tipoDocumentos.First(tp => tp.Descripcion == "Seleccionar");
            cmbTipoDocumento.SelectedItem = tipoDocumentoSeleccionado;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _frmPasajeros.Show();
            this.Dispose();
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ConfirmarOperacion()) return;
                if (!ValidarPasajero()) return;
                RegistrarPasajero(_pasajero);
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
        private bool ValidarPasajero()
        {
            var tipoDocumento = ((TipoDocumento)cmbTipoDocumento.SelectedItem).Descripcion;
            var nroDocumento = txtNroDocumento.Text;
            var apellido = txtApellido.Text;
            var nombre = txtNombre.Text;
            var telefono = txtTelefono.Text;
            var email = txtEmail.Text;
            var fechaNacimiento = dtpFechaNacimiento.Value;
            var pasajeroIngresado = new Pasajero();
            var tipoDocumentoIngresado = new TipoDocumento();
            tipoDocumentoIngresado.Descripcion = tipoDocumento;
            pasajeroIngresado.NroDocumento = nroDocumento;
            pasajeroIngresado.Apellido = apellido;
            pasajeroIngresado.Nombre = nombre;
            pasajeroIngresado.Telefono = telefono;
            pasajeroIngresado.Email = email;
            pasajeroIngresado.FechaNacimiento = fechaNacimiento;

            _pasajerosServicio.ValidarPasajero(pasajeroIngresado);

            _pasajero = pasajeroIngresado;
            return true;
        }
        private bool ConfirmarOperacion()
        {
            var resultado = MessageBox.Show("Confimar Operación", "Verificación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resultado == DialogResult.Cancel) { return false; }
            return true;
        }
        private void RegistrarPasajero(Pasajero _pasajero)
        {

            if (_pasajerosServicio.RegistrarPasajero(_pasajero))
            {
                MessageBox.Show("La operación se realizó con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _frmPasajeros.Show();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Hubo un error. Intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNroDocumento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNroDocumento_KeypressKeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbTipoDocumento.SelectedItem.ToString() == "Seleccionar") { txtNroDocumento.MaxLength = 9; }
            else
            {
                if ((((TipoDocumento)cmbTipoDocumento.SelectedItem).Id).ToString() == "1")
                {
                    //Para obligar a que sólo se introduzcan números
                    txtNroDocumento.MaxLength = 8;
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
                if ((((TipoDocumento)cmbTipoDocumento.SelectedItem).Id).ToString() == "2")
                {
                    txtNroDocumento.MaxLength = 9;
                    if (txtNroDocumento.TextLength < 3)
                    {

                        //Para obligar a que sólo se introduzcan letras
                        if (Char.IsLetter(e.KeyChar))
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
                    else
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
        }

        private void cmbTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNroDocumento.Text = "";

        }
        private void txtTelefono_KeypressKeyPress(object sender, KeyPressEventArgs e)
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
