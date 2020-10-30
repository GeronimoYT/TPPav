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
    public partial class formAltaPasaje : Form
    {
        private formPasajes _frmPasajes;
        public formAltaPasaje(formPasajes frmPasajes)
        {
            _frmPasajes = frmPasajes;
            InitializeComponent();
        }

        private void formAltaPasaje_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            _frmPasajes.Show();
            this.Dispose();
        }

    }
}
