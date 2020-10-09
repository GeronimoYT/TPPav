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

<<<<<<< HEAD
=======
        

>>>>>>> master
        private void aeropuertoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formAeropuerto ventanaAeropuerto = new formAeropuerto();
            ventanaAeropuerto.Show();
        }

<<<<<<< HEAD
        private void vueloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formAltaVuelo ventanaVuelo = new formAltaVuelo();
            ventanaVuelo.Show();
        }
=======
        
>>>>>>> master

        private void pasajeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formularioPasajes = new formPasajes(this);
            formularioPasajes.Show();
            this.Hide();
        }

<<<<<<< HEAD
        private void formPrincipal_Load(object sender, EventArgs e)
        {

=======
        private void formPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
>>>>>>> master
        }
    }
}
