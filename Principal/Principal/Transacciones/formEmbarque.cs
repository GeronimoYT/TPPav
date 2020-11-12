using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Principal.Clases;

namespace Principal.Transacciones
{
    public partial class formEmbarque : Form
    {
        public formEmbarque()
        {
            InitializeComponent();
            CargarEmbarque();
            cmbAeropuerto.SelectedIndex = -1;
        }

        

        public void CargarEmbarque()
        {            
                try
                {
                    string consultaNroVuelo = $"SELECT DISTINCT NroVuelo FROM Embarque";
                    var combo = DBHelper.GetDBHelper().ConsultaSQL(consultaNroVuelo);
                    cmbNroVuelo.DataSource = combo;
                    cmbNroVuelo.DisplayMember = "NroVuelo";
                    cmbNroVuelo.SelectedIndex = -1;

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("La consulta ejecutada es incorrecta, por favor revise nuevamente");
                }            
        }

       public void CargarDatos(string nroVuelo)
        {
            try
            {
                string consultaAeropuerto = $"SELECT Nombre FROM Aeropuerto";
                var combo2 = DBHelper.GetDBHelper().ConsultaSQL(consultaAeropuerto);
                cmbAeropuerto.DataSource = combo2;
                cmbAeropuerto.DisplayMember = "Nombre";



                string consultaTipoDNI = $"SELECT DISTINCT TipoDNIPasajero FROM Embarque WHERE NroVuelo LIKE {nroVuelo}";
                var combo3 = DBHelper.GetDBHelper().ConsultaSQL(consultaTipoDNI);
                cmbTipoDoc.DataSource = combo3;
                cmbTipoDoc.DisplayMember = "TipoDNIPasajero";


                string consultaEstado = $"SELECT DISTINCT es.NombreEstado FROM Estado es, Embarque e WHERE es.Ambito = 2";
                //string consultaEstadoActual = $"SELECT es.NombreEstado FROM Estado es, Embarque e WHERE es.Ambito = 2 AND e.IdEstado = es.IdEstado";
                var combo5 = DBHelper.GetDBHelper().ConsultaSQL(consultaEstado);
                //var consultaActual = DBHelper.GetDBHelper().ConsultaSQL(consultaEstadoActual);
                cmbEstado.DataSource = combo5;
                cmbEstado.DisplayMember = "NombreEstado";

                string embarque = $"SELECT * FROM Embarque WHERE NroVuelo LIKE {nroVuelo}";
                var consultaEmbarque = DBHelper.GetDBHelper().ConsultaSQL(consultaEstado);



                string consultaFecha = $"SELECT DISTINCT FechaHoraEmbarque FROM Embarque WHERE NroVuelo LIKE {nroVuelo}";
                var fechaTexto = DBHelper.GetDBHelper().ConsultaSQL(consultaEstado);

                //txtFechaEmbarque.Text = fechaTexto;


            }
            catch (SqlException ex)
            {
                
            }

        }

        private void ActualizarTipoDoc(string nroVuelo) {
            try
            {
                string consultaNroDNI = $"SELECT DISTINCT NroDNIPasajero FROM Embarque WHERE NroVuelo LIKE {nroVuelo} AND TipoDNIPasajero LIKE '{cmbTipoDoc.Text.ToString()}'";
                var combo6 = DBHelper.GetDBHelper().ConsultaSQL(consultaNroDNI);
                cmbNroDoc.DataSource = combo6;
                cmbNroDoc.DisplayMember = "NroDNIPasajero";
            }
            catch (Exception ex)
            {
                MessageBox.Show("La consulta ejecutada es incorrecta, por favor revise nuevamente");
            }
        }

        private void cmbNroVuelo_SelectedIndexChanged(object sender, EventArgs e)
        {
             CargarDatos(cmbNroVuelo.Text.ToString());
            if (cmbNroVuelo.SelectedIndex != -1)
                btnAceptarEdicion.Enabled = true;
            else
                btnAceptarEdicion.Enabled = false;
        }

        private void cmbTipoDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarTipoDoc(cmbNroVuelo.Text.ToString());
        }

        private void ActualizarCantPuertas()
        {
            try {
                string consultaCantPEmb = $"SELECT CantPuertasEmbarque FROM Aeropuerto WHERE Nombre = '{cmbAeropuerto.Text}'";
                var comboCantPuertas = DBHelper.GetDBHelper().ConsultaSQL(consultaCantPEmb);
                cmbPuertaEmbarque.DataSource = comboCantPuertas;
                cmbPuertaEmbarque.DisplayMember = "CantPuertasEmbarque";


                int cantPuertas = int.Parse(cmbPuertaEmbarque.Text);
                List<int> cant = new List<int>();
                for (int i = 0; i < cantPuertas; i++)
                {
                    cant.Add(i + 1);
                }
                cmbPuertaEmbarque.DataSource = cant;
            }
            catch (Exception ex) { }
        }

        private void cmbAeropuerto_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarCantPuertas();
        }

        private void btnAceptarEdicion_Click(object sender, EventArgs e)
        {
            //NuevoEmbarque nvEmbarque = new NuevoEmbarque(int.Parse(cmbNroVuelo.Text),DateTime.Parse(txtFechaEmbarque.Text),int.Parse(cmbAeropuerto.Text),cmbTipoDoc.Text,cmbNroDoc.Text,int.Parse(cmbPuertaEmbarque.Text),cmbEstado.Text);
            CargarNuevoEmbarque();
        }

        private void CargarNuevoEmbarque() {

            Embarque nvEmbarque = new Embarque();

            nvEmbarque.NroVuelo = int.Parse(cmbNroVuelo.Text);
            if (txtFechaEmbarque.MaskCompleted)
                nvEmbarque.FechaHoraEmbarque = DateTime.Parse(txtFechaEmbarque.Text);
            nvEmbarque.Aeropuerto = cmbAeropuerto.Text;
            nvEmbarque.TipoDniPasajero = cmbTipoDoc.Text;
            nvEmbarque.NroDniPasajero = cmbNroDoc.Text;
            nvEmbarque.PuertaEmbarque = int.Parse(cmbPuertaEmbarque.Text);
            nvEmbarque.Estado = cmbEstado.Text;

            MessageBox.Show(nvEmbarque.FechaHoraEmbarque.ToString());
        }

        private void formEmbarque_Load(object sender, EventArgs e)
        {

        }
    }
}
