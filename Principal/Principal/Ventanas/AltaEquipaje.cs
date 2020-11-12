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
using Principal.Transacciones;

namespace Principal.Ventanas
{

    public partial class AltaEquipaje : Form
    {
        formEquipajes _formAnterior;
        EquipajeRepositorio _equipajeRepositorio;
        TipoEquipajeRepositorio _tiposRepositorio;
        TipoDocumentosRepositorio _tiposDocRepositorio;
        PasajerosRepositorio _pasajerosRepositorio;
        public AltaEquipaje(formEquipajes anterior)
        {
            _formAnterior = anterior;
            _equipajeRepositorio = new EquipajeRepositorio();
            _tiposRepositorio = new TipoEquipajeRepositorio();
            _tiposDocRepositorio = new TipoDocumentosRepositorio();
            _pasajerosRepositorio = new PasajerosRepositorio();
            InitializeComponent();
        }

        private void AltaEquipaje_Load(object sender, EventArgs e)
        {
            btnAceptar.Enabled = false;

            //Carga las categorias o tipos de equipajes
            List<TipoEquipaje> tiposEquipaje = _tiposRepositorio.ObtenerTipos();
            var conectorDeDatos = new BindingSource();
            conectorDeDatos.DataSource = tiposEquipaje;
            FormUtils.GetInstance.CargarCombo(ref comboCategoria, conectorDeDatos, "categoria", "id");

            //Carga los tipos de documentos
            List<TipoDocumento> tiposDocumento = _tiposDocRepositorio.ObtenerTipoDocumentos();
            var conectorDeDatos2 = new BindingSource();
            conectorDeDatos2.DataSource = tiposDocumento;
            FormUtils.GetInstance.CargarCombo(ref comboTipoDocumento, conectorDeDatos2, "Id", "Id");
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNroDocumento.Text != "")
            {
                Equipaje equipajeAlta = new Equipaje();

                TipoEquipaje tipo = (TipoEquipaje)comboCategoria.SelectedItem;
                equipajeAlta.tipo = tipo.id;

                TipoDocumento tipoDNI = (TipoDocumento)comboTipoDocumento.SelectedItem;
                equipajeAlta.tipoDNI = tipoDNI.Id;

                equipajeAlta.DNI = txtNroDocumento.Text;
                equipajeAlta.descripcion = txtDescripcion.Text;

                _equipajeRepositorio.Altaequipaje(equipajeAlta);
                _formAnterior.RefrescarFormulario();

                //FormUtils.GetInstance.GenerarTXT(equipajeAlta.ToString());

                CerrarFormuario();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un numero de documento");
            }
        }

        private void txtNroDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormUtils.GetInstance.KeypressDocumento(comboTipoDocumento.Text, txtNroDocumento.Text, sender, e);            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CerrarFormuario();
        }

        private void CerrarFormuario()
        {
            _formAnterior.RefrescarFormulario();
            _formAnterior.Show();
            this.Close();
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormUtils.GetInstance.KeypressNumeros(sender, e);
        }

        private void comboTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNroDocumento.Clear();
        }

        private void ValidarDocumento()
        {
            string nroDocumento = txtNroDocumento.Text;
            TipoDocumento tipoDocumento = (TipoDocumento)comboTipoDocumento.SelectedItem;

            string rutaCorrecto = @"C:\Users\mmoro\OneDrive\Escritorio\TP Pav\TPPav\Principal\Principal\Recursos\Imagenes\correcto.png";
            string rutaIncorrecto = @"C:\Users\mmoro\OneDrive\Escritorio\TP Pav\TPPav\Principal\Principal\Recursos\Imagenes\incorrecto.png";

            if (_pasajerosRepositorio.PasajeroHablitado(tipoDocumento.Id, nroDocumento))
            {
                toolTip.SetToolTip(pictureDocumento, "Pasajero encontrado");
                pictureDocumento.ImageLocation = rutaCorrecto;
                btnAceptar.Enabled = true;
            }
            else
            {
                toolTip.SetToolTip(pictureDocumento, "Este pasajero no existe o no esta habilitado.");
                pictureDocumento.ImageLocation = rutaIncorrecto;
                btnAceptar.Enabled = false;
            }
        }

        private void txtNroDocumento_TextChanged(object sender, EventArgs e)
        {
            ValidarDocumento();
        }
    }
}
