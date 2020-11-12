using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
using Principal.Clases;
using Principal.Utils;

namespace Principal.Ventanas.TiposAvion
{
    public partial class ModificacionTipo : Form
    {
        private Form _formTipos;
        private TipoAvion tipoModificacion;
        private TiposAvionRepositorio _tiposRepositorio;

        public ModificacionTipo(Form formTipos, TipoAvion tipoAvion)
        {
            _formTipos = formTipos;
            tipoModificacion = tipoAvion;
            _tiposRepositorio = new TiposAvionRepositorio();
            InitializeComponent();
        }

        private void ModificacionTipo_Load(object sender, EventArgs e)
        {
            txtDescripcion.Text = tipoModificacion.descripcion;
            txtLongitud.Text = tipoModificacion.longitud.ToString();
            txtAlcance.Text = tipoModificacion.alcance.ToString();
            txtClase1.Text = tipoModificacion.pasajerosClase1.ToString();
            txtClaseTurista.Text = tipoModificacion.pasajerosClase2.ToString();
            txtEquipaje.Text = tipoModificacion.capacidadEquipaje.ToString();
            txtSalidas.Text = tipoModificacion.salidasEmergencia.ToString();

            //txtId.Text = tipoModificacion.id.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            TipoAvion modificarTipo = new TipoAvion();
            modificarTipo.descripcion = txtDescripcion.Text;
            modificarTipo.longitud = Convert.ToSingle(txtLongitud.Text);
            modificarTipo.alcance = Convert.ToInt32(txtAlcance.Text);
            modificarTipo.pasajerosClase1 = Convert.ToInt32(txtClase1.Text);
            modificarTipo.pasajerosClase2 = Convert.ToInt32(txtClaseTurista.Text);
            modificarTipo.capacidadEquipaje = Convert.ToInt32(txtEquipaje.Text);
            modificarTipo.salidasEmergencia = Convert.ToInt32(txtSalidas.Text);

            modificarTipo.estado = tipoModificacion.estado;
            modificarTipo.id = tipoModificacion.id;
            
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult resultado = MessageBox.Show("Está seguro que desea realizar esta operación?", "Modificar Tipo Avion", buttons);
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                _tiposRepositorio.ModificacionTipo(modificarTipo);
            }
            
            CerrarFormuario();
        }

        private void CerrarFormuario()
        {
            _formTipos.Show();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CerrarFormuario();
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormUtils.GetInstance.KeypressNumeros(sender, e);
        }

        private void txtLongitud_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormUtils.GetInstance.KeypressNumeros(sender, e);
        }

        private void txtAlcance_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormUtils.GetInstance.KeypressNumeros(sender, e);
        }

        private void txtClase1_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormUtils.GetInstance.KeypressNumeros(sender, e);
        }

        private void txtClaseTurista_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormUtils.GetInstance.KeypressNumeros(sender, e);
        }

        private void txtEquipaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormUtils.GetInstance.KeypressNumeros(sender, e);
        }

        private void txtSalidas_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSalidas_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormUtils.GetInstance.KeypressNumeros(sender, e);
        }
    }
}
