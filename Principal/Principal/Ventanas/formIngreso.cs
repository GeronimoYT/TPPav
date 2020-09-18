using Principal.Clases;
using Principal.Ventanas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            try
            {
                string consultarUser = $"SELECT * FROM Usuario WHERE '{txtUsuario.Text}' LIKE NombreUsuario AND '{txtContrasena.Text}' LIKE Contraseña";
                var usuario = DBHelper.GetDBHelper().ConsultaSQL(consultarUser);
                if(usuario.Rows.Count == 1)
                {
                    formPrincipal ventanaPrincipal = new formPrincipal(user);
                    ventanaPrincipal.Show();
                    this.Hide();
                }else MessageBox.Show("Ingrese un usuario y contraseña válido!");
            }
            catch(SqlException ex) { 
                MessageBox.Show("Consulta inválida!");
            }

        }

        private void FormIngresar_Load(object sender, EventArgs e)
        {

        }
    }
}
