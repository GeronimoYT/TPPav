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
        public formEquipajes(Form anterior)
        {
            _formPrincipal = anterior;
            _equipajeRepositorio = new EquipajeRepositorio();
            InitializeComponent();
        }

        private void BuscarEquipajesPasajero()
        {
            PasajerosRepositorio pasajerosRepo = new PasajerosRepositorio();
            if (pasajerosRepo.ObtenerPasajero(txtBusqueda.Text) != null)
            {
                List<Equipaje> equipajes = _equipajeRepositorio.ObtenerEquipajesPasajero(pasajerosRepo.ObtenerPasajero(txtBusqueda.Text));
                var conectorDeDatos = new BindingSource();
                conectorDeDatos.DataSource = equipajes;
                FormUtils.GetInstance.CargarList(ref lboxEquipaje, conectorDeDatos, "numero", "numero");
            }
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            if (txtBusqueda.Text != "") { BuscarEquipajesPasajero(); }
            else { MessageBox.Show("Por favor, ingrese un numero de documento."); }
        }

        private void lboxEquipaje_SelectedIndexChanged(object sender, EventArgs e)
        {
            Equipaje equipajeSelecionado = (Equipaje)lboxEquipaje.SelectedItem;
            txtNumero.Text = equipajeSelecionado.numero.ToString();
            //Implementar busqueda de tipos de equipaje en la base de datos
            txtNumero.Text = equipajeSelecionado.tipo.ToString();

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
                _equipajeRepositorio.BajaEquipaje((Equipaje)lboxEquipaje.SelectedItem);
            }
        }
    }
}
