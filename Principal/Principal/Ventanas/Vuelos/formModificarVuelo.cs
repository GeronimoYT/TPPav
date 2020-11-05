using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal.Ventanas.Vuelos
{
    public partial class formModificarVuelo : Form
    {
        public formModificarVuelo()
        {
            InitializeComponent();
        }

        private void formModificarVuelo_Load(object sender, EventArgs e)
        {
            cargaFechasYHoras();
            cargaAviones();
            cargaAeropuertos();
            cargaEstados();
        }

        private void cargaFechasYHoras()
        { 
        }
        
        private void cargaAviones() 
        { 
        }
        private void cargaAeropuertos()
        {
        }

        private void cargaEstados()
        {
        }
    }
}
