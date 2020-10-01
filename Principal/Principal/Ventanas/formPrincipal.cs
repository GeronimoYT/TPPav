using Principal.Clases;
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
            ventanaAeropuerto.Show();
        }

        

        private void pasajeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formularioPasajes = new formPasajes(this);
            formularioPasajes.Show();
            this.Hide();
        }

        private void formPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
