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
            cmbTipoDoc.SelectedIndex = -1;
            cmbNroDoc.SelectedIndex = -1;
        }

        

        public void CargarEmbarque()
        {            
                try
                {
                    string consultaNroVuelo = $"SELECT DISTINCT NroVuelo FROM Vuelo";
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
            if(cmbNroVuelo.SelectedIndex != -1) { 
                try
                {
                    string consultaAeropuerto = $"SELECT Nombre FROM Aeropuerto";
                    var combo2 = DBHelper.GetDBHelper().ConsultaSQL(consultaAeropuerto);
                    cmbAeropuerto.DataSource = combo2;
                    cmbAeropuerto.DisplayMember = "Nombre";



                    string consultaTipoDNI = $"SELECT DISTINCT TipoDNI FROM TipoDocumento";
                    var combo3 = DBHelper.GetDBHelper().ConsultaSQL(consultaTipoDNI);
                    cmbTipoDoc.DataSource = combo3;
                    cmbTipoDoc.DisplayMember = "TipoDNI";


                    string consultaEstado = $"SELECT DISTINCT es.NombreEstado FROM Estado es, Embarque e WHERE es.Ambito = 2";
                    //string consultaEstadoActual = $"SELECT es.NombreEstado FROM Estado es, Embarque e WHERE es.Ambito = 2 AND e.IdEstado = es.IdEstado";
                    var combo5 = DBHelper.GetDBHelper().ConsultaSQL(consultaEstado);
                    //var consultaActual = DBHelper.GetDBHelper().ConsultaSQL(consultaEstadoActual);
                    cmbEstado.DataSource = combo5;
                    cmbEstado.DisplayMember = "NombreEstado";



                    string consultaFecha = $"SELECT DISTINCT FechaHoraEmbarque FROM Embarque WHERE NroVuelo LIKE {nroVuelo}";
                    if(LeerTexto(consultaFecha) != null)
                        txtFechaEmbarque.Text = DateTime.Parse(LeerTexto(consultaFecha)).ToString("dd/MM/yyyy HH:mm");
                    else
                        txtFechaEmbarque.Text = LeerTexto(consultaFecha);
                    //MessageBox.Show(DateTime.Parse(txtFechaEmbarque.Text).ToString("dd/MM/yyyy HH:mm"));



                }
                catch (SqlException ex)
                {
                
                }
            }

        }

        private void ActualizarTipoDoc(string nroVuelo) {
            try
            {
                string consultaNroDNI = $"SELECT DISTINCT NroDNI FROM Pasajero WHERE TipoDNI LIKE '{cmbTipoDoc.Text.ToString()}'";
                var combo6 = DBHelper.GetDBHelper().ConsultaSQL(consultaNroDNI);
                cmbNroDoc.DataSource = combo6;
                cmbNroDoc.DisplayMember = "NroDNI";
            }
            catch (Exception ex)
            {
                MessageBox.Show("La consulta ejecutada es incorrecta, por favor revise nuevamente");
            }
        }

        private string ObtenerIdAeropuerto()
        {
            try { 
                string consulta = $"SELECT IdAeropuerto FROM Aeropuerto WHERE Nombre LIKE '{cmbAeropuerto.Text}'";
                string idAeropuerto = LeerTexto(consulta);
                return idAeropuerto;
            }
            catch(Exception ex) {
                MessageBox.Show("No se ha podido obtener la ID del aeropuerto");
            }

            return null;

        }


        private string ObtenerIdEstado()
        {
            try
            {
                string consulta = $"SELECT IdEstado FROM Estado WHERE NombreEstado LIKE '{cmbEstado.Text}'";
                string idEstado = LeerTexto(consulta);

                return idEstado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido obtener la ID del aeropuerto");
            }

            return null;

        }

        private void cmbNroVuelo_SelectedIndexChanged(object sender, EventArgs e)
        {            
            if (cmbNroVuelo.SelectedIndex != -1) { 
                ObtenerIdAeropuerto();
                CargarDatos(cmbNroVuelo.Text.ToString());
                btnAceptarEdicion.Enabled = true;
            }
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
            try
            {
                if (txtFechaEmbarque.MaskCompleted) {
                    if (DateTime.Parse(txtFechaEmbarque.Text) > DateTime.Now) {
                        if ((DateTime.Parse(txtFechaEmbarque.Text).Hour < 23 || DateTime.Parse(txtFechaEmbarque.Text).Hour > 0) && (DateTime.Parse(txtFechaEmbarque.Text).Minute % 30) == 0)
                        {
                            nvEmbarque.FechaHoraEmbarque = DateTime.Parse(txtFechaEmbarque.Text);
                        }
                        else
                        {
                            MessageBox.Show("Porfavor ingrese valores de Hora y Minutos válidos(0 a 23 y 0 - 30min)");
                        }
                    }
                    else {
                        MessageBox.Show("Porfavor ingrese una fecha válida!");
                    }
                    
                }
            }
            catch(Exception ex) { 
                    MessageBox.Show("Porfavor ingrese valores de Hora y Minutos válidos (0 a 23 y 0-30min)");
            }
            nvEmbarque.Aeropuerto = int.Parse(ObtenerIdAeropuerto());
            nvEmbarque.TipoDniPasajero = cmbTipoDoc.Text;
            nvEmbarque.NroDniPasajero = cmbNroDoc.Text;
            nvEmbarque.PuertaEmbarque = int.Parse(cmbPuertaEmbarque.Text);
            nvEmbarque.Estado = int.Parse(ObtenerIdEstado());

            NuevoEmbarque(nvEmbarque);
        }

        private bool NuevoEmbarque(Embarque embarque)
        {
            string cadenaDeConexion = "Data Source=200.69.137.167,11333;Initial Catalog=PAV-3K2-10-AEROLINEA;User ID=PAV-3K2-10-USER;Password=77edc00a99fe"; ;
            SqlTransaction objTransaccion = null;
            SqlConnection cn = new SqlConnection(cadenaDeConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string insert = $"INSERT INTO Embarque VALUES ('{embarque.NroVuelo}','{embarque.FechaHoraEmbarque.ToString("dd-MM-yyyy HH:mm")}','{embarque.Aeropuerto}','{embarque.TipoDniPasajero}','{embarque.NroDniPasajero}','{embarque.PuertaEmbarque}','{embarque.Estado}')";
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = insert;
                

                cn.Open();

                objTransaccion = cn.BeginTransaction("NuevoEmbarque");

                cmd.Transaction = objTransaccion;

                cmd.Connection = cn;

                cmd.ExecuteNonQuery();

                objTransaccion.Commit();

                MessageBox.Show("Transacción Realizada con éxito!");

                this.Close();

                return true;
            }
            catch (Exception ex) {
                MessageBox.Show("No se ha podido ejecutar la transacción!");
                objTransaccion.Rollback();
                return false;
            }
            finally {
                cn.Close();
            }


        }


        private string LeerTexto(string strSql) {

            string cadenaDeConexion = "Data Source=200.69.137.167,11333;Initial Catalog=PAV-3K2-10-AEROLINEA;User ID=PAV-3K2-10-USER;Password=77edc00a99fe";

            SqlConnection Conn = new SqlConnection(cadenaDeConexion);
            SqlCommand Comm1 = new SqlCommand();
            Comm1.Connection = Conn;
            Comm1.CommandType = CommandType.Text;
            Comm1.CommandText = strSql;
            Conn.Open();
            SqlDataReader DR1 = Comm1.ExecuteReader();
            if (DR1.Read())
            {
                return DR1.GetValue(0).ToString();
            }
            Conn.Close();

            return null;
        }

        private void btnEditarAeropuerto_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
