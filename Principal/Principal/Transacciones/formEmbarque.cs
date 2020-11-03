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

                string consultaPuertaEmbarque = $"SELECT DISTINCT PuertaEmbarque FROM Embarque WHERE NroVuelo LIKE {nroVuelo}";
                var combo4 = DBHelper.GetDBHelper().ConsultaSQL(consultaPuertaEmbarque);
                cmbPuertaEmbarque.DataSource = combo4;
                cmbPuertaEmbarque.DisplayMember = "PuertaEmbarque";

                string consultaEstado = $"SELECT DISTINCT es.NombreEstado FROM Estado es, Embarque e WHERE es.Ambito = 2";
                var combo5 = DBHelper.GetDBHelper().ConsultaSQL(consultaEstado);
                cmbEstado.DataSource = combo5;
                cmbEstado.DisplayMember = "NombreEstado";

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
        }

        private void cmbTipoDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarTipoDoc(cmbNroVuelo.Text.ToString());
        }
    }
}
