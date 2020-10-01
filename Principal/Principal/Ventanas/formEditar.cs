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
    public partial class formEditar : Form
    {
        public formEditar()
        {
            InitializeComponent();
        }

        private void txtNuevoDomicilio_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            formAeropuerto aeropuerto = new formAeropuerto();
            aeropuerto.Show();
            this.Close();
        }

        private void formEditar_Load(object sender, EventArgs e)
        {

        }
    }
}
