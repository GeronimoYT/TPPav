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
    public partial class Detalle_Tipo : Form
    {
        Form _form;
        TipoAvion tipo;
        public Detalle_Tipo(Form form, TipoAvion tipoAvion)
        {
            _form = form;
            tipo = tipoAvion;
            InitializeComponent();
        }

        private void Detalle_Tipo_Load(object sender, EventArgs e)
        {
            txtDescripcion.Text = tipo.descripcion;
            txtLongitud.Text = tipo.longitud.ToString();
            txtAlcance.Text = tipo.alcance.ToString();
            txtClase1.Text = tipo.pasajerosClase1.ToString();
            txtClaseTurista.Text = tipo.pasajerosClase2.ToString();
            txtEquipaje.Text = tipo.capacidadEquipaje.ToString();
            txtSalidas.Text = tipo.salidasEmergencia.ToString();
        }


        private void CerrarFormuario()
        {
            _form.Show();
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            CerrarFormuario();
        }
    }
}
