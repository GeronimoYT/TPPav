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
        private formPrincipal _frmPrincipal;
        public formPasajes(formPrincipal principal)
        {
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
    }
}
