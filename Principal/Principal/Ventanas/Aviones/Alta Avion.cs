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
    public partial class Alta_Avion : Form
    {
        private Form _formAviones;
        public Alta_Avion(Form formAviones)
        {
            _formAviones = formAviones;
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Alta_Avion_Load(object sender, EventArgs e)
        {
            TiposAvionRepositorio RepTipo = new TiposAvionRepositorio();
            List<TipoAvion> tipos = RepTipo.ObtenerTipos();
            var conectorDeDatos = new BindingSource();
            conectorDeDatos.DataSource = tipos;
            CargarCombo(ref comboCategorias, conectorDeDatos, "descripcion", "id");
        }

        private void CargarCombo(ref ComboBox combo, BindingSource conectorDeDatos, string displayMember, string valueMember)
        {
            combo.DataSource = conectorDeDatos.DataSource;
            combo.DisplayMember = displayMember;
            combo.ValueMember = valueMember;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Avion avion = new Avion();
                var avionSeleccionado = (TipoAvion)comboCategorias.SelectedItem;
                avion.idTipo = avionSeleccionado.id;
                avion.numero = Convert.ToInt32(txtBoxId.Text);
                avion.descripcion = rTxtBoxDescripcion.Text;
                AvionesRepositorio avionesRep = new AvionesRepositorio();
                avionesRep.AltaAvion(avion);
                CerrarFormuario();
            }
            catch (Exception ex) {
                MessageBox.Show("No se ha podido realizar la operación");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CerrarFormuario();
        }
        
        private void CerrarFormuario()
        {
            _formAviones.Show();
            this.Close();
        }
    }
}
