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

namespace Principal.Ventanas
{
    public partial class FormAviones : Form
    {

        public FormAviones()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void gridAviones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Aviones_Load(object sender, EventArgs e)
        {
            AvionesRepositorio avionesRep = new AvionesRepositorio();
            List<Avion> aviones = avionesRep.ObtenerAviones();
            Cargar_Grilla(aviones);
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
    }
}
