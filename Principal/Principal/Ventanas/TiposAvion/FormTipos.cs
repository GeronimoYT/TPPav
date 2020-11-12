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
    public partial class FormTipos : Form
    {
        Form _formPrincipal;
        TiposAvionRepositorio _tiposRepositorio;

        public FormTipos(Form formPrincipal)
        {
            _formPrincipal = formPrincipal;
            _tiposRepositorio = new TiposAvionRepositorio();
            InitializeComponent();
        }

        private void Tipos_Load(object sender, EventArgs e)
        {
            RefrescarList();
        }

        private void lboxTipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            TipoAvion tipoSelecionado = (TipoAvion)lboxTipos.SelectedItem;
            txtDescripcion.Text = tipoSelecionado.descripcion;
            txtLongitud.Text = tipoSelecionado.longitud.ToString();
            txtAlcance.Text = tipoSelecionado.alcance.ToString();
            txtClase1.Text = tipoSelecionado.pasajerosClase1.ToString();
            txtClaseTurista.Text = tipoSelecionado.pasajerosClase2.ToString();
            txtEquipaje.Text = tipoSelecionado.capacidadEquipaje.ToString();
            txtSalidas.Text = tipoSelecionado.salidasEmergencia.ToString();
            if (tipoSelecionado.EstaActivo()) { txtActivo.Text = "Si"; }
            else {txtActivo.Text = "No"; }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            AltaTipo altaTipo = new AltaTipo(this);
            altaTipo.Show();
            this.Hide();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            CerrarFormuario();
        }

        private void CerrarFormuario()
        {
            _formPrincipal.Show();
            this.Close();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            TipoAvion tipoSelecionado = (TipoAvion)lboxTipos.SelectedItem;
            BajaTipo bajaTipo = new BajaTipo(this, tipoSelecionado);
            bajaTipo.Show();
            this.Hide();
        }

        private void RefrescarList()
        {
            List<TipoAvion> tipos;
            if (chkboxInactivos.Checked) 
            { tipos = _tiposRepositorio.ObtenerTipos(); }
            else { tipos = _tiposRepositorio.ObtenerTiposActivos(); }
            
            var conectorDeDatos = new BindingSource();
            conectorDeDatos.DataSource = tipos;
            FormUtils.GetInstance.CargarList(ref lboxTipos, conectorDeDatos, "descripcion", "id");
        }

        private void RefrescarFormulario()
        {
            chkboxInactivos.Checked = false;
            RefrescarList();

        }

        private void FormTipos_VisibleChanged(object sender, EventArgs e)
        {
            RefrescarFormulario();
        }

        private void btnModificacion_Click(object sender, EventArgs e)
        {
            TipoAvion tipoSelecionado = (TipoAvion)lboxTipos.SelectedItem;
            ModificacionTipo bajaTipo = new ModificacionTipo(this, tipoSelecionado);
            bajaTipo.Show();
            this.Hide();
        }

        private void FormTipos_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            RefrescarList();
            if (chkboxInactivos.Checked) 
            {
                labelActivo.Visible = true;
                txtActivo.Visible = true;
            }
            else
            {
                labelActivo.Visible = false;
                txtActivo.Visible = false;
            }
        }
    }
}
