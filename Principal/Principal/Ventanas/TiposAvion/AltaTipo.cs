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
    public partial class AltaTipo : Form
    {
        private Form _formTipos;
        private TiposAvionRepositorio _tiposRepositorio;
        public AltaTipo(Form tipos)
        {
            _formTipos = tipos;
            _tiposRepositorio = new TiposAvionRepositorio();
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            TipoAvion nuevoTipo = new TipoAvion();
            nuevoTipo.descripcion = txtDescripcion.Text;
            nuevoTipo.longitud = Convert.ToSingle(txtLongitud.Text);
            nuevoTipo.alcance = Convert.ToInt32(txtAlcance.Text);
            nuevoTipo.pasajerosClase1 = Convert.ToInt32(txtClase1.Text);
            nuevoTipo.pasajerosClase2 = Convert.ToInt32(txtClaseTurista.Text);
            nuevoTipo.capacidadEquipaje = Convert.ToInt32(txtEquipaje.Text);
            nuevoTipo.salidasEmergencia = Convert.ToInt32(txtSalidas.Text);

            nuevoTipo.id = 0;

            _tiposRepositorio.AltaTipo(nuevoTipo);
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

        private void txtLongitud_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormUtils.GetInstance.KeypressKeyPress(sender, e);
        }

        private void txtAlcance_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormUtils.GetInstance.KeypressKeyPress(sender, e);
        }

        private void txtClase1_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormUtils.GetInstance.KeypressKeyPress(sender, e);
        }

        private void txtClaseTurista_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormUtils.GetInstance.KeypressKeyPress(sender, e);
        }

        private void txtEquipaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormUtils.GetInstance.KeypressKeyPress(sender, e);
        }

        private void txtSalidas_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormUtils.GetInstance.KeypressKeyPress(sender, e);
        }
    }
}