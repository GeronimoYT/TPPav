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
    public partial class FormIngresar : Form
    {
        public FormIngresar()
        {
            InitializeComponent();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            string user = "Geronimo";
            string pass = "gerito22";

            if (txtUsuario.Text == user && txtContrasena.Text == pass)
                MessageBox.Show("Bienvenido " + txtUsuario.Text);
            else MessageBox.Show("Ingrese un usaurio y contraseña válido!");
            
        }

        private void FormIngresar_Load(object sender, EventArgs e)
        {

        }
    }
}
