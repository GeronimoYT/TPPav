using Principal.Clases;
using Principal.Clases.Servicios;
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
    public partial class formPasajes : Form
    {
        private PasajesServicio _pasajesServicio;
        private PasajerosServicio _pasajerosServicio;
        private TipoPasajesServicio _tipoPasajesServicio;
        private formPrincipal _frmPrincipal;
        public formPasajes(formPrincipal principal)
        {
            _pasajesServicio = new PasajesServicio();
            _pasajerosServicio = new PasajerosServicio();
            _tipoPasajesServicio = new TipoPasajesServicio();
            _frmPrincipal = principal;
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            new formAltaPasaje(this).Show();
            this.Hide();
        }

        private void formPasajes_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            _frmPrincipal.Show();
            this.Dispose();
        }
        public void ConsultarPasajes()
        {
            var pasajes = _pasajesServicio.ObtenerPasajes();
            CargarGrilla(pasajes);
        }
        private void CargarGrilla(List<Pasaje> pasajes)
        {
            dgvPasajes.Rows.Clear();
            foreach (var pasaje in pasajes)
            {
                var fila = new String[] {
                pasaje.Id.ToString(),
                pasaje.Precio.ToString(),
                pasaje.Descripcion
                };
                dgvPasajes.Rows.Add(fila);
            }
        }
    }
}
