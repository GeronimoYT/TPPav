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
        TiposAvionRepositorio RepTipo;
        List<TipoAvion> _tipos = new List<TipoAvion>();
        List<Avion> _aviones;

        public FormAviones()
        {
            avionesRep = new AvionesRepositorio();
            RepTipo = new TiposAvionRepositorio();
            CargarTipos();
            _aviones = avionesRep.ObtenerAvionesActivos();
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Modificacion_Avion ventanaModificacion = new Modificacion_Avion(this, AvionSeleccionado());
            ventanaModificacion.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<Avion> avionesxDescripcion = FiltrarxDescripcion(Filtrarxtipo(_aviones));
            List<Avion> avionesxNumero = FiltrarxNumero(avionesxDescripcion);

            Cargar_Grilla(avionesxNumero);
        }

        private void Aviones_Load(object sender, EventArgs e)
        {
            var conectorDeDatos = new BindingSource();
            conectorDeDatos.DataSource = _tipos;
            FormUtils.GetInstance.CargarCombo(ref comboCategorias, conectorDeDatos, "descripcion", "id");

            Cargar_Grilla(_aviones);
        }

        private void Cargar_Grilla(List<Avion> aviones)
        {
            gridAviones.Rows.Clear();

            foreach (var avion in aviones)
            {
                
                var fila = new String[]
                {
                avion.numero.ToString(),
                NumeroACategoria(avion.idTipo),
                avion.descripcion,
                };
                gridAviones.Rows.Add(fila);

            }
        }

        private void comboCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cargar_Grilla(Filtrarxtipo(_aviones));
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            Alta_Avion ventanaAlta = new Alta_Avion(this);
            ventanaAlta.Show();
            this.Hide();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            Baja_Avion ventanaBaja = new Baja_Avion(this, AvionSeleccionado());
            ventanaBaja.Show();
            this.Hide();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscar_KeypressKeyPress(object sender, KeyPressEventArgs e)
        {
            FormUtils.GetInstance.KeypressNumeros(sender, e);
        }
        public void RefrescarFormulario()
        {
            _aviones = avionesRep.ObtenerAvionesActivos();
            chboxInactivos.Checked = false;
            comboCategorias.SelectedIndex = 0;
            txtNumero.Clear();
            txtDescripcion.Clear();
            Cargar_Grilla(_aviones);
        }
        private int CategoriaANumero(string tipoNombre)
        {
            int idTipo = -1;
            foreach (var tipo in _tipos)
            {
                if (tipoNombre == tipo.descripcion) { idTipo = tipo.id; }
            }
            return idTipo;
        }
        public string NumeroACategoria(int idTipo)
        {
            string tipoNombre = "";
            foreach (var tipo in _tipos)
            {
                if (tipo.id == idTipo) { tipoNombre = tipo.descripcion; }
            }
            return tipoNombre;
        }

        private void chboxInactivos_CheckedChanged(object sender, EventArgs e)
        {
            if (chboxInactivos.Checked) { _aviones = avionesRep.ObtenerAviones(); }
            else { _aviones = avionesRep.ObtenerAvionesActivos(); }
            
            Cargar_Grilla(Filtrarxtipo(_aviones));         
        }

        private List<Avion> Filtrarxtipo(List<Avion> aviones)
        {
            TipoAvion tipoSeleccionado = (TipoAvion)comboCategorias.SelectedItem;
            List<Avion> avionesxCategoria = new List<Avion>();
            if (tipoSeleccionado.id != -1)
            {
                foreach (Avion avion in aviones)
                {
                    if (avion.idTipo == tipoSeleccionado.id) { avionesxCategoria.Add(avion); }
                }
                return avionesxCategoria;
            }
            else { return _aviones; }
        }
        private List<Avion> FiltrarxDescripcion(List<Avion> aviones)
        {
            List<Avion> avionesxDescripcion = new List<Avion>();
            if (txtDescripcion.Text != "")
            {
                foreach (Avion avion in aviones)
                {
                    if (avion.descripcion.Contains(txtDescripcion.Text)) {avionesxDescripcion.Add(avion); }
                }
                return avionesxDescripcion;
            }
            else { return aviones; }
        }

        private List<Avion> FiltrarxNumero(List<Avion> aviones)
        {
            List<Avion> avionesxNumero = new List<Avion>();
            if (txtNumero.Text != "")
            {
                foreach (Avion avion in aviones)
                {
                    if (avion.numero == Convert.ToInt32(txtNumero.Text)) { avionesxNumero.Add(avion); }
                }
                return avionesxNumero;
            }
            else { return aviones; }
        }

        private void CargarTipos()
        {
            _tipos.Add(new TipoAvion(-1, "--Todos los Aviones--", 0, 0, 0, 0, 0, 0, "S"));
            foreach(TipoAvion tipo in RepTipo.ObtenerTipos())
            {
                _tipos.Add(tipo);
            }
        }
        private Avion AvionSeleccionado()
        {
            foreach(Avion avion in _aviones)
            {
                int numero = Convert.ToInt32(FormUtils.GetInstance.GetValorCelda(gridAviones, 0));
                int idTipo = CategoriaANumero(FormUtils.GetInstance.GetValorCelda(gridAviones, 1));
                if (avion.numero == numero && avion.idTipo == idTipo) { return avion; }
            }
            return new Avion();
        }
    }
}
