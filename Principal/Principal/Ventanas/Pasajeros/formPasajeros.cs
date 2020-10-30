﻿using Principal.Clases;
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
    public partial class formPasajeros : Form
    {
        private PasajerosServicio _pasajerosServicio;
        private formPrincipal _frmPrincipal;
        private TipoDocumentosServicio _tipoDocumentosServicio;
        private bool flag;

        public formPasajeros(formPrincipal principal)
        {

            _pasajerosServicio = new PasajerosServicio();
            _tipoDocumentosServicio = new TipoDocumentosServicio();
            _frmPrincipal = principal;
            InitializeComponent();
        }

        private void formPasajeros_Load(object sender, EventArgs e)
        {
            flag = true;
            CargarTipoDocumento();
        }

        private void CargarGrilla(List<Pasajero> pasajeros)
        {
            dgvPasajeros.Rows.Clear();
            foreach (var pasajero in pasajeros)
            {
                if (!ControlEdad())
                {
                    var fila = new String[] {
                    pasajero.TipoDocumento?.Id,
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
                else
                {
                    if (Convert.ToInt32(txtEdadDesde.Text) <= pasajero.Edad && Convert.ToInt32(txtEdadHasta.Text) >= pasajero.Edad)
                    {
                        var fila = new String[] {
                    pasajero.TipoDocumento?.Id,
                    //pasajero.TipoDocumento,
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

            }
            if (!flag)
            {
                flag = true; txtEdadDesde.Text = null; txtEdadHasta.Text = null;
            }
        }
        public void ConsultarPasajeros()
        {
            var tipoDocumentoIngresado = (((TipoDocumento)cmbTipoDocumento.SelectedItem).Id).ToString();
            
            var nroDocumentoIngresado = txtNroDocumento.Text;
            var nombreIngresado = txtNombre.Text;
            var apellidoIngresado = txtApellido.Text;
            var incluirEnBaja = ckIncluirEnBaja.Checked;

            var pasajeros = _pasajerosServicio.ObtenerPasajeros(tipoDocumentoIngresado, nroDocumentoIngresado, apellidoIngresado, nombreIngresado, incluirEnBaja);
            CargarGrilla(pasajeros);
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
            FormUtils.CargarCombo(ref cmbTipoDocumento, conector, "Id", "Id");
            var tipoDocumentoSeleccionado = tipoDocumentos.First(tp => tp.Id == "Seleccionar");
            cmbTipoDocumento.SelectedItem = tipoDocumentoSeleccionado;
            



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

        private bool ControlEdad()
        {

            if (!string.IsNullOrEmpty(txtEdadDesde.Text.ToString()) && !string.IsNullOrEmpty(txtEdadHasta.Text.ToString()))
            {
                if (Convert.ToInt32(txtEdadDesde.Text) > Convert.ToInt32(txtEdadHasta.Text))
                {

                    flag = false;
                    return false;
                }

                return true;
            }
            if (!string.IsNullOrEmpty(txtEdadDesde.Text.ToString()) || !string.IsNullOrEmpty(txtEdadHasta.Text.ToString()))
            {

                if (!string.IsNullOrEmpty(txtEdadDesde.Text.ToString()) && string.IsNullOrEmpty(txtEdadHasta.Text.ToString()))
                {
                    txtEdadHasta.Text = "999";
                    return true;
                }
                if (!string.IsNullOrEmpty(txtEdadHasta.Text.ToString()) && string.IsNullOrEmpty(txtEdadDesde.Text.ToString()))
                {
                    txtEdadDesde.Text = "0";
                    return true;
                }
                return false;
            }
            if (string.IsNullOrEmpty(txtEdadDesde.Text.ToString()) && string.IsNullOrEmpty(txtEdadHasta.Text.ToString()))
            {

                return false;
            }

            flag = false;
            return false;

        }

        private void txtEdadDesde_KeypressKeyPress(object sender, KeyPressEventArgs e)
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
        private void txtEdadHasta_KeypressKeyPress(object sender, KeyPressEventArgs e)
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
