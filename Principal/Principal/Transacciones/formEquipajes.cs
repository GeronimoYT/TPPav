using Principal.Clases;
using Principal.Clases.Repositorio;
using Principal.Utils;
using Principal.Ventanas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal.Transacciones
{
    public partial class formEquipajes : Form
    {
        Form _formPrincipal;
        EquipajeRepositorio _equipajeRepositorio;
        TipoEquipajeRepositorio _tiposRepositorio;
        PasajerosRepositorio _pasajerosRepo;

        public formEquipajes(Form anterior)
        {
            _formPrincipal = anterior;
            _equipajeRepositorio = new EquipajeRepositorio();
            _tiposRepositorio = new TipoEquipajeRepositorio();
            _pasajerosRepo = new PasajerosRepositorio();
            InitializeComponent();
        }

        private void BuscarEquipajesPasajero()
        {

            string numero = txtBusqueda.Text;

            string tipo = comboBusqueda.Text;

            Pasajero pasajeroBusqueda = _pasajerosRepo.ObtenerPasajero(tipo, numero);

            bool habilitado = _pasajerosRepo.PasajeroHablitado(tipo, numero);

            if (pasajeroBusqueda != null)
            {
                if (chboxBusqueda.Checked || habilitado)
                {
                    List<Equipaje> equipajes = _equipajeRepositorio.ObtenerEquipajesPasajero(pasajeroBusqueda);
                    cargarEquipajes(equipajes);
                }
                else
                { 
                    MessageBox.Show($"No se ha encontrado un pasajero con el Documento: {numero}");
                    RefrescarFormulario();
                }
                
            }
            else 
            {
                MessageBox.Show($"No se ha encontrado un pasajero con el Documento: {numero}");
                RefrescarFormulario();
            }
        }

        private void lboxEquipaje_SelectedIndexChanged(object sender, EventArgs e)
        {
            Equipaje equipajeSelecionado = (Equipaje)lboxEquipaje.SelectedItem;
            txtNumero.Text = equipajeSelecionado.numero.ToString();

            TipoEquipaje tipoEquipaje = _tiposRepositorio.ObtenerTipo(equipajeSelecionado.tipo);
            txtCategoria.Text = tipoEquipaje.categoria;

            txtTipoDocumento.Text = equipajeSelecionado.tipoDNI.ToString();
            txtNroDocumento.Text = equipajeSelecionado.DNI.ToString();
            txtDescripcion.Text = equipajeSelecionado.descripcion;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            CerrarFormuario();
        }

        private void CerrarFormuario()
        {
            _formPrincipal.Show();
            this.Close();
        }

        private void formEquipajes_Load(object sender, EventArgs e)
        {
            TipoDocumentosRepositorio tipoRepo = new TipoDocumentosRepositorio();
            List<TipoDocumento> tiposDocumentos = tipoRepo.ObtenerTipoDocumentos();
            var conectorDeDatos = new BindingSource();
            conectorDeDatos.DataSource = tiposDocumentos;
            FormUtils.GetInstance.CargarCombo(ref comboBusqueda, conectorDeDatos, "Id", "Id");

            List<Equipaje> equipajes = _equipajeRepositorio.ObtenerEquipajesPasajerosActivos();
            cargarEquipajes(equipajes);
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            AltaEquipaje altaEquipaje = new AltaEquipaje(this);
            altaEquipaje.Show();
            this.Hide();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult resultado = MessageBox.Show("Está seguro que desea eliminar este equipaje?", "Eliminar Equipaje", buttons);
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                Equipaje equipajeBaja = (Equipaje)lboxEquipaje.SelectedItem;
                equipajeBaja.estado = "N";
                _equipajeRepositorio.BajaEquipaje(equipajeBaja);
                RefrescarFormulario();
            }
        }

        private void chboxBusqueda_CheckedChanged(object sender, EventArgs e)
        {
            if (txtBusqueda.Text.Length > 7)
            {
                BuscarEquipajesPasajero();
            }
            else 
            {

                List<Equipaje> equipajes;
                if (chboxBusqueda.Checked) { equipajes = _equipajeRepositorio.ObtenerEquipajes(); }
                else { equipajes = _equipajeRepositorio.ObtenerEquipajesPasajerosActivos(); }
                cargarEquipajes(equipajes); 
            }
        }

        public void RefrescarFormulario()
        {
            txtBusqueda.Clear();
            chboxBusqueda.Checked = false;

            List<Equipaje> equipajes = _equipajeRepositorio.ObtenerEquipajesPasajerosActivos();
            cargarEquipajes(equipajes);
        }

        private void cargarEquipajes(List<Equipaje> equipajes)
        {
            var conectorDeDatos = new BindingSource();
            conectorDeDatos.DataSource = equipajes;
            FormUtils.GetInstance.CargarList(ref lboxEquipaje, conectorDeDatos, "numero", "numero");

        }

        private void btnBuqueda_Click(object sender, EventArgs e)
        {
            if (txtBusqueda.Text.Length > 7) { BuscarEquipajesPasajero(); }
            else { MessageBox.Show("Por favor, ingrese un numero de documento valido."); }
        }

        private void comboBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Equipaje> equipajes = _equipajeRepositorio.ObtenerEquipajesTipoDocumento((TipoDocumento)comboBusqueda.SelectedItem);
            cargarEquipajes(equipajes);
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            RefrescarFormulario();
        }
    }
}
