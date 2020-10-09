using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
using Principal.Clases;



namespace Principal.Ventanas.Aviones
{
    public partial class Baja_Avion : Form
    {
        private Form _formAviones;
        private Avion avion;
        private AvionesRepositorio _avionesRep;
        public Baja_Avion(FormAviones formAviones, Avion avionBaja)
        {
            _formAviones = formAviones;
            _avionesRep = new AvionesRepositorio();
            avion = avionBaja;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _avionesRep.BajaAvion(avion);
            CerrarFormuario();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Baja_Avion_Load(object sender, EventArgs e)
        {
            txtNumero.Text = avion.numero.ToString();
            txtCategoria.Text = avion.idTipo.ToString();
            txtDescripcion.Text = avion.descripcion;
        }

        private void CerrarFormuario()
        {
            _formAviones.Show();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CerrarFormuario();
        }
    }
}
