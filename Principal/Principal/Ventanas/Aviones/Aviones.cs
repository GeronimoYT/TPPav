using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Agrgados
using Principal.Clases;
using Principal.Ventanas.Aviones;
using Principal.Utils;

namespace Principal.Ventanas
{
    public partial class FormAviones : Form
    {
        private AvionesRepositorio avionesRep;
        private FormUtils formUtils;
        public FormAviones()
        {
            avionesRep = new AvionesRepositorio();
            formUtils = new FormUtils();
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Avion avion = new Avion();
            avion.numero = Convert.ToInt32(formUtils.GetValorCelda(gridAviones, 0));
            avion.idTipo = Convert.ToInt32(formUtils.GetValorCelda(gridAviones, 1));
            avion.descripcion = formUtils.GetValorCelda(gridAviones, 2);
            Modificacion_Avion ventanaModificacion = new Modificacion_Avion(this, avion);
            ventanaModificacion.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TipoAvion tipoSeleccionado = (TipoAvion)comboCategorias.SelectedItem;
            if (txtBuscar.Text != "") 
            {
                int numero = Convert.ToInt32(txtBuscar.Text);
                List<Avion> aviones = avionesRep.ObtenerAviones(tipoSeleccionado.id, numero);
                Cargar_Grilla(aviones);
            }
        }

        private void gridAviones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Aviones_Load(object sender, EventArgs e)
        {
            List<Avion> aviones = avionesRep.ObtenerAviones();
            Cargar_Grilla(aviones);

            TiposAvionRepositorio RepTipo = new TiposAvionRepositorio();
            List<TipoAvion> tipos = RepTipo.ObtenerTipos();
            var conectorDeDatos = new BindingSource();
            conectorDeDatos.DataSource = tipos;
            formUtils.CargarCombo(ref comboCategorias, conectorDeDatos, "descripcion", "id");

        }

        private void Cargar_Grilla(List<Avion> aviones)
        {
            gridAviones.Rows.Clear();

            foreach(var avion in aviones)
            {
                var fila = new String[]
                {
                    avion.numero.ToString(),
                    avion.idTipo.ToString(),
                    avion.descripcion,
                };
                gridAviones.Rows.Add(fila);
            }
        }

        private void comboCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            TipoAvion tipoSeleccionado = (TipoAvion)comboCategorias.SelectedItem;
            List<Avion> aviones = avionesRep.ObtenerAviones(tipoSeleccionado.id);
            Cargar_Grilla(aviones);
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            Alta_Avion ventanaAlta = new Alta_Avion(this);
            ventanaAlta.Show();
            this.Hide();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            Avion avion = new Avion();
            avion.numero = Convert.ToInt32(formUtils.GetValorCelda(gridAviones, 0));
            avion.idTipo = Convert.ToInt32(formUtils.GetValorCelda(gridAviones, 1));
            avion.descripcion = formUtils.GetValorCelda(gridAviones, 2);
            Baja_Avion ventanaBaja = new Baja_Avion(this, avion);
            ventanaBaja.Show();
            this.Hide();
        }
    }
}
