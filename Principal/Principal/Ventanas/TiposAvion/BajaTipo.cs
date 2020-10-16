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

namespace Principal.Ventanas.TiposAvion
{
    public partial class BajaTipo : Form
    {
        private Form _formTipo;
        private TipoAvion tipoBaja;
        private TiposAvionRepositorio _tiposRepositorio;
        public BajaTipo(Form formtipo, TipoAvion tipoAvion)
        {
            _formTipo = formtipo;
            tipoBaja = tipoAvion;
            _tiposRepositorio = new TiposAvionRepositorio();
            InitializeComponent();
        }

        private void BajaAvion_Load(object sender, EventArgs e)
        {
            txtDescripcion.Text = tipoBaja.descripcion;
            txtLongitud.Text = tipoBaja.longitud.ToString();
            txtAlcance.Text = tipoBaja.alcance.ToString();
            txtClase1.Text = tipoBaja.pasajerosClase1.ToString();
            txtClaseTurista.Text = tipoBaja.pasajerosClase2.ToString();
            txtEquipaje.Text = tipoBaja.capacidadEquipaje.ToString();
            txtSalidas.Text = tipoBaja.salidasEmergencia.ToString();

            txtId.Text = tipoBaja.id.ToString();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult resultado = MessageBox.Show("Está seguro que desea realizar esta operación?", "Eliminar Tipo Avion", buttons);
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                _tiposRepositorio.BajaTipo(tipoBaja);
            }
            CerrarFormuario();
        }

        private void CerrarFormuario()
        {
            _formTipo.Show();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CerrarFormuario();
        }
    }
}
