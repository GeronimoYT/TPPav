using Principal.Clases;
using Principal.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal.Ventanas
{
    public partial class formAltaVuelo : Form
    {
        public formPrincipal principal;
        private FormUtils formUtils;
                
        public object Me { get; private set; }

        public formAltaVuelo()
        {
            InitializeComponent();
            formUtils = FormUtils.GetInstance;
        }

        private void formVuelo_Load(object sender, EventArgs e)
        {
            IniciarCalendarios();
            CargaHoras();
            CargoCombo();
            LimpiarCampos();
        }

        private void IniciarCalendarios()
        {
            calendarioSalida.MinDate = DateTime.Today;
            calendarioLlegada.MinDate = DateTime.Today;
        }

        private void CargoCombo()
        {
            try
            {
                AvionesRepositorio _avionRepo = new AvionesRepositorio();
                List<Avion> aviones = _avionRepo.ObtenerAviones();
                var conectorDeDatos = new BindingSource();
                conectorDeDatos.DataSource = aviones;
                formUtils.CargarCombo(ref cmbNumAvion, conectorDeDatos, "numero", "numero");

                string consulta2 = "SELECT * FROM Aeropuerto";
                string consulta3 = "SELECT * FROM Estado WHERE AMBITO = 1";

                var combo2 = DBHelper.GetDBHelper().ConsultaSQL(consulta2);
                var combo3 = DBHelper.GetDBHelper().ConsultaSQL(consulta2);
                var combo4 = DBHelper.GetDBHelper().ConsultaSQL(consulta3);

                cmbAeropuertoOrigen.DataSource = combo2;
                cmbAeropuertoDestino.DataSource = combo3;
                cmbEstado.DataSource = combo4;

                cmbAeropuertoOrigen.DisplayMember = "domicilio";
                cmbAeropuertoOrigen.ValueMember = "idAeropuerto";
                cmbAeropuertoOrigen.SelectedIndex = -1;

                cmbAeropuertoDestino.DisplayMember = "domicilio";
                cmbAeropuertoDestino.ValueMember = "idAeropuerto";
                cmbAeropuertoDestino.SelectedIndex = -1;

                cmbEstado.DisplayMember = "NombreEstado";
                cmbEstado.ValueMember = "IdEstado";
                cmbEstado.SelectedIndex = -1;

            }
            catch (SqlException ex)
            {
                MessageBox.Show("La consulta ejecutada es incorrecta, por favor revise nuevamente");
            }
        }

        public void CargaHoras()
        {
            cmbHoraSalida.Items.Add("00:00"); cmbHoraSalida.Items.Add("01:00"); cmbHoraSalida.Items.Add("02:00"); cmbHoraSalida.Items.Add("03:00"); cmbHoraSalida.Items.Add("04:00"); cmbHoraSalida.Items.Add("05:00"); cmbHoraSalida.Items.Add("06:00"); cmbHoraSalida.Items.Add("07:00"); cmbHoraSalida.Items.Add("08:00"); cmbHoraSalida.Items.Add("09:00"); cmbHoraSalida.Items.Add("10:00"); cmbHoraSalida.Items.Add("11:00");
            cmbHoraSalida.Items.Add("12:00"); cmbHoraSalida.Items.Add("13:00"); cmbHoraSalida.Items.Add("14:00"); cmbHoraSalida.Items.Add("15:00"); cmbHoraSalida.Items.Add("16:00"); cmbHoraSalida.Items.Add("17:00"); cmbHoraSalida.Items.Add("18:00"); cmbHoraSalida.Items.Add("19:00"); cmbHoraSalida.Items.Add("20:00"); cmbHoraSalida.Items.Add("21:00"); cmbHoraSalida.Items.Add("22:00"); cmbHoraSalida.Items.Add("23:00");
            cmbHoraLlegada.Items.Add("00:00"); cmbHoraLlegada.Items.Add("01:00"); cmbHoraLlegada.Items.Add("02:00"); cmbHoraLlegada.Items.Add("03:00"); cmbHoraLlegada.Items.Add("04:00"); cmbHoraLlegada.Items.Add("05:00"); cmbHoraLlegada.Items.Add("06:00"); cmbHoraLlegada.Items.Add("07:00"); cmbHoraLlegada.Items.Add("08:00"); cmbHoraLlegada.Items.Add("09:00"); cmbHoraLlegada.Items.Add("10:00"); cmbHoraLlegada.Items.Add("11:00");
            cmbHoraLlegada.Items.Add("12:00"); cmbHoraLlegada.Items.Add("13:00"); cmbHoraLlegada.Items.Add("14:00"); cmbHoraLlegada.Items.Add("15:00"); cmbHoraLlegada.Items.Add("16:00"); cmbHoraLlegada.Items.Add("17:00"); cmbHoraLlegada.Items.Add("18:00"); cmbHoraLlegada.Items.Add("19:00"); cmbHoraLlegada.Items.Add("20:00"); cmbHoraLlegada.Items.Add("21:00"); cmbHoraLlegada.Items.Add("22:00"); cmbHoraLlegada.Items.Add("23:00");
        }

        private void cmbNumAvion_SelectedIndexChanged(object sender, EventArgs e)
        {
            Avion avion = (Avion)cmbNumAvion.SelectedItem;
            
            if (cmbNumAvion.SelectedIndex != -1)
            {
                try
                {
                    /*string consultasql = $"SELECT DescripcionTipo FROM Avion a JOIN TipoAvion tp ON a.IdTipoAvion = tp.IdTipoAvion " +
                                         $"WHERE a.NroAvion LIKE {avion.idTipo.ToString()}";

                    var res = DBHelper.GetDBHelper().ComandoSQL(consultasql);
                    txtTipoAvion.Text = res;*/

                    /*string consulta = $"SELECT DescripcionTipo FROM TipoAvion WHERE IdTipoAvion LIKE {avion.idTipo}";
                    var res = DBHelper.GetDBHelper().ConsultaSQL(consulta);
                    cmbNumAvion.DataSource = res;
                    txtTipoAvion.Text= res.ToString();*/
                    txtTipoAvion.Text = avion.idTipo.ToString();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("La consulta ejecutada es incorrecta");
                }
            }
            else
            {
                txtTipoAvion.Text = "";
            }
        }

        //select*
        //from avion a join TipoAvion ta on a.IdTipoAvion = ta.IdTipoAvion
        //where a.NroAvion like '1'

        //select v.NroVuelo, v.FechaHoraSalida, v.FechaHoraLlegada, a.Descripcion,
        //ta.DescripcionTipo, ao.Domicilio, ad.Domicilio, e.NombreEstado
        //from vuelo v
        //join avion a on v.NroAvion = a.NroAvion
        //join tipoavion ta on v.idtipoavion = ta.IdTipoAvion
        //join aeropuerto ao on v.IdAeropuerto = ao.IdAeropuerto
        //join aeropuerto ad on v.IdAeropuertoDestino = ad.IdAeropuerto
        //join estado e on v.Estado = e.IdEstado

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            if (cmbNumAvion.SelectedIndex != -1)
            {
                FormAviones Aviones = new FormAviones();
                Aviones.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("No se selecciono ningun Numero de Avion");
            }
        }

        private void btnConfirmarVuelo_Click(object sender, EventArgs e)
        {
            if (Validaciones() == false)
            {
                if (ValidacionAeropuerto() == false)
                {
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult resultado = MessageBox.Show("¿Está seguro que desea confirmar el Vuelo?", "VUELO", buttons);
                    if (resultado == System.Windows.Forms.DialogResult.Yes)
                    {
                        try
                        {

                            var fechaHoraSalida = calendarioSalida.SelectionStart.ToString("dd/MM/yyyy")+ ' ' + cmbHoraSalida.Text;
                            var fechaHoraLlegada = calendarioLlegada.SelectionStart.ToString("dd/MM/yyyy")+ ' ' + cmbHoraLlegada.Text;

                            var fechaHoraS = Convert.ToDateTime(fechaHoraSalida);
                            var fechaHoraL = Convert.ToDateTime(fechaHoraLlegada);

                            //FORMATO bd yyyy-MM-dd HH:mm

                            //CARGA DE DATOS A BD 
                            string consulta = $"INSERT INTO Vuelo (FechaHoraSalida,FechaHoraLlegada,NroAvion,IdTipoAvion,IdAeropuerto,IdAeropuertoDestino,Estado) " +
                                              $"VALUES ('{fechaHoraS.ToString("dd-MM-yyyy HH:mm")}','{fechaHoraL.ToString("dd-MM-yyyy HH:mm")}',{cmbNumAvion.SelectedValue.ToString()},{txtTipoAvion.Text},{cmbAeropuertoOrigen.SelectedValue.ToString()},{cmbAeropuertoDestino.SelectedValue.ToString()},{cmbEstado.SelectedValue.ToString()})";
                            var carga = DBHelper.GetDBHelper().ConsultaSQL(consulta);
                            MessageBox.Show("Los datos se cargaron correctamente!");
                            formVuelo ventanaVuelo = new formVuelo();
                            ventanaVuelo.Show();
                            LimpiarCampos();
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("No se ha podido Registrar el Vuelo");
                        }
                    }
                    else
                    { LimpiarCampos(); }
                }
                else
                { MessageBox.Show("Aeropuerto Origen no puede coincidir con Aeropuerto Destino"); }
            }
            else
            { MessageBox.Show("Debe completar todos los campos para poder continuar!"); }

        }

        public bool Validaciones()
        {
            bool condicion = false;
            if (cmbHoraSalida.SelectedIndex == -1)
            {   condicion = true;}
            if (cmbHoraLlegada.SelectedIndex == -1)
            {   condicion = true;}
            if (cmbNumAvion.SelectedIndex == -1)
            {   condicion = true;}
            if (cmbAeropuertoOrigen.SelectedIndex == -1)
            {   condicion = true;}
            if (cmbAeropuertoDestino.SelectedIndex == -1)
            {   condicion = true; }
            if (cmbEstado.SelectedIndex == -1)
            {   condicion = true; }

            return condicion;
        }

        public bool ValidacionAeropuerto()
        {
            bool ae = false;
            if (cmbAeropuertoOrigen.Text.ToString() == cmbAeropuertoDestino.Text.ToString())
                {ae = true;}
            return ae;
        }
                     
        private void btnCancelarVuelo_Click_1(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult resultado = MessageBox.Show("¿Está seguro que desea Salir?", "VUELO", buttons);
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    this.Close();  
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se ha podido realizar la operación");
                }
            }
        }
        
        private void LimpiarCampos()
        {
            var hoy = DateTime.Today;
            calendarioSalida.SelectionStart = hoy;
            calendarioLlegada.SelectionStart = hoy;
            cmbHoraSalida.Text = "";
            cmbHoraLlegada.Text = "";
            cmbNumAvion.SelectedIndex = -1;
            txtTipoAvion.Text = "";
            cmbAeropuertoOrigen.SelectedIndex = -1;
            cmbAeropuertoDestino.SelectedIndex = -1;
            cmbEstado.SelectedIndex = -1;

        }

    }
}