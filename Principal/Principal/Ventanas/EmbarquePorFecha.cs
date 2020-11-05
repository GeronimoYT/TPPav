using Microsoft.Reporting.WinForms;
using Principal.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal.Ventanas
{
    public partial class EmbarquePorNroVuelo : Form
    {
        public EmbarquePorNroVuelo()
        {
            InitializeComponent();
        }

        private void EmbarquePorFecha_Load(object sender, EventArgs e)
        {

            this.rvEmNroVuelo.RefreshReport();
        }

        private void CargarReporte()
        {
            DataTable tabla = new DataTable();
            tabla = ObtenerTabla();

            var ds = new ReportDataSource("DataSetNroVuelos", (DataTable)tabla);
            rvEmNroVuelo.LocalReport.DataSources.Clear();
            rvEmNroVuelo.LocalReport.DataSources.Add(ds);
            rvEmNroVuelo.LocalReport.ReportPath = "../../Informes y Reportes/EmbarquePorFecha.rdlc";
            this.rvEmNroVuelo.LocalReport.Refresh();
        }



        private static DataTable ObtenerTabla()
        {
            try
            {
                string consulta = $"SELECT  NroVuelo, COUNT(NroVuelo) FROM Embarque GROUP BY NroVuelo";
                var obtener = DBHelper.GetDBHelper().ConsultaSQL(consulta);
                return obtener;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido realizar la operación");
            }

            return null;
        }

        private void rvEmNroVuelo_Load(object sender, EventArgs e)
        {
            CargarReporte();
        }
    }
}
