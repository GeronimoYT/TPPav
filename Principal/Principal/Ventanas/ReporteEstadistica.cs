using Microsoft.Reporting.WinForms;
using Principal._PAV_3K2_10_AEROLINEADataSetTableAdapters;
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
using static Principal._PAV_3K2_10_AEROLINEADataSet;

namespace Principal.Ventanas
{
    public partial class ReporteEstadistica : Form
    {
        public ReporteEstadistica()
        {
            InitializeComponent();
        }

        private void ReporteEstadistica_Load(object sender, EventArgs e)
        {
            this.rvGraficoAviones.RefreshReport();    
        }
        private void CargarReporte()
        {
            DataTable tabla = new DataTable();
            tabla = ObtenerTabla();

            var ds = new ReportDataSource("DatosTipoAvion", (DataTable)tabla);
            rvGraficoAviones.LocalReport.DataSources.Clear();
            rvGraficoAviones.LocalReport.DataSources.Add(ds);
            rvGraficoAviones.LocalReport.ReportPath = "../../Informes y Reportes/EstadisticaAvion.rdlc";
            this.rvGraficoAviones.LocalReport.Refresh();
        }

        private void rvGraficoAviones_Load(object sender, EventArgs e)
        {
            CargarReporte();
        }


        private static DataTable ObtenerTabla() {
            try
            {
                string consulta = $"SELECT ta.DescripcionTipo as Nombre, a.IdTipoAvion as Cantidad FROM Avion a JOIN TipoAvion ta ON a.IdTipoAvion = ta.IdTipoAvion";
                var obtener = DBHelper.GetDBHelper().ConsultaSQL(consulta);
                return obtener;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido realizar la operación");
            }

            return null;
        }
    }
}
