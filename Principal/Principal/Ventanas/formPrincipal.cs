using Principal.Clases;
using System;
using System.Windows.Forms;
using Principal.Ventanas.TiposAvion;
using Principal.Transacciones;

using Principal.Informes_y_Reportes;


namespace Principal.Ventanas
{
    public partial class formPrincipal : Form
    {
        public formPrincipal(Usuario user)
        {
            InitializeComponent();
            lblNombreUsuario.Text = "Bienvenido " + user.NombreDeUsuario;
            lblNombreUsuario.Visible = true;
        }


        private void aeropuertoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formAeropuerto ventanaAeropuerto = new formAeropuerto();
            ventanaAeropuerto.ShowDialog();
        }

<<<<<<< HEAD
        private void vueloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formVuelo ventanaVuelo = new formVuelo();
            ventanaVuelo.ShowDialog();
            //this.Hide();
        }

        private void pasajeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formularioPasajes = new formPasajes(this);
            formularioPasajes.ShowDialog();
            //this.Hide();
        }
=======
>>>>>>> ad2dd6d4c7e10423be71e9f31e02e812c09247e1

        private void formPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void pasajeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formularioPasajeros = new formPasajeros(this);
            formularioPasajeros.ShowDialog();
            //this.Hide();
        }

        private void avionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAviones ventanaAeropuerto = new FormAviones();
            ventanaAeropuerto.ShowDialog();
        }

        private void tipoAvionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTipos tipoAvion = new FormTipos(this);
            tipoAvion.ShowDialog();
        }

        private void btnEmbarque_Click(object sender, EventArgs e)
        {
            formEmbarque ventanaEmbarque = new formEmbarque();
            ventanaEmbarque.ShowDialog();
        }

        private void estadisticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteEstadistica ventana = new ReporteEstadistica();
            ventana.ShowDialog();
        }

        private void salidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formReporte ventana = new formReporte();
            ventana.ShowDialog();
        }

        private void btnEquipaje_Click(object sender, EventArgs e)
        {
            formEquipajes ventanaEquipajes = new formEquipajes(this);
            ventanaEquipajes.Show();
        }
        private void btnPasaje_Click(object sender, EventArgs e)
        {
            var formularioPasajes = new formPasajes(this);
            formularioPasajes.ShowDialog();
        }

        private void btnVuelo_Click(object sender, EventArgs e)
        {
            formVuelo ventanaVuelo = new formVuelo();
            ventanaVuelo.ShowDialog();
        }
<<<<<<< HEAD
=======

        private void embarquesPorFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmbarquePorNroVuelo reporteEmbarque = new EmbarquePorNroVuelo();
            reporteEmbarque.ShowDialog();
        }

        private void formPrincipal_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");

        }

>>>>>>> ad2dd6d4c7e10423be71e9f31e02e812c09247e1
    }
}
