using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Principal.Clases;
//
using Principal.Clases.Repositorio;
using Principal.Utils;

namespace Principal.Ventanas
{

    public partial class AltaEquipaje : Form
    {
        Form _formAnterior;
        TipoEquipajeRepositorio _tiposRepositorio;
        //TipoDocumentoRepositorio _tiposDocRepositorio;
        public AltaEquipaje(Form anterior)
        {
            _formAnterior = anterior;
            _tiposRepositorio = new TipoEquipajeRepositorio();
            InitializeComponent();
        }

        private void AltaEquipaje_Load(object sender, EventArgs e)
        {
            List<TipoEquipaje> tiposEquipaje = _tiposRepositorio.ObtenerTipos();
            var conectorDeDatos = new BindingSource();
            conectorDeDatos.DataSource = tiposEquipaje;
            FormUtils.GetInstance.CargarCombo(ref comboCategoria, conectorDeDatos, "categoria", "id");

            /*
            List<TipoDocumento> tiposDocumento = _tiposDocRepositorio.ObtenerTipos();
            conectorDeDatos.DataSource = tiposDocumento;
            FormUtils.GetInstance.CargarCombo(ref comboCategoria, conectorDeDatos, "descripcion", "descripcion");
            */
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Equipaje equipajeAlta = new Equipaje();
            if (txtNumero.Text != "")
            {
                if (txtNroDocumento.Text != "")
                {
                    equipajeAlta.numero = Convert.ToInt32(txtNumero.Text);
                    TipoEquipaje tipo = (TipoEquipaje)comboCategoria.SelectedItem;
                    equipajeAlta.tipo = tipo.id;
                    //TipoDocumento tipoDNI = (TipoDocumento)comboTipoDocumento.SelectedItem;
                    //equipajeAlta.tipoDNI = tipoDNI.id;
                    equipajeAlta.DNI = txtNroDocumento.Text;
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un numero de documento");
                }
            }
            else
            {
                MessageBox.Show("Porfavor, ingrese un numero de equipaje");
            }

        }

        private void txtNroDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if ((((TipoDocumento)cmbTipoDocumento.SelectedItem).Id).ToString() == "DNI")
            if (comboTipoDocumento.SelectedItem.ToString() == "DNI")
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
            //if ((((TipoDocumento)cmbTipoDocumento.SelectedItem).Id).ToString() == "Pasaporte")
            if (comboTipoDocumento.SelectedItem.ToString() == "Pasaporte")
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CerrarFormuario();
        }

        private void CerrarFormuario()
        {
            _formAnterior.Show();
            this.Close();
        }
    }
}
