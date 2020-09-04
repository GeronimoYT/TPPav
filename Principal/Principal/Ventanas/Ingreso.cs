using Principal.Clases;
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

namespace Principal
{
    public partial class formIngresar : Form
    {
        public formIngresar()
        {
            InitializeComponent();

        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario(txtUsuario.Text, txtContrasena.Text);
            string usuarioValido = "Geronimo";
            string contrasenaValida = "gerito22";

            if (txtUsuario.Text.Equals(usuarioValido) && txtContrasena.Text.Equals(contrasenaValida)) {
                //formPrincipal ventanaPrincipal = new formPrincipal(user);
                formAeropuerto ventanaAeropuerto = new formAeropuerto();
                //ventanaPrincipal.Show();
                ventanaAeropuerto.Show();
                this.Hide();
            }
            else MessageBox.Show("Ingrese un usuario y contraseña válido!");
            
        }
    }
}
